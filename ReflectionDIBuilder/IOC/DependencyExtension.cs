using ReflectionDIBuilder.Attribute;
using ReflectionDIBuilder.Enums;
using System.Reflection;

namespace ReflectionDIBuilder.IOC
{
    public static class DependencyExtension
    {
        public static void AddDependency(this IServiceCollection services)
        {

            var types = Assembly.GetExecutingAssembly()
                  .ExportedTypes
                  .Where(x => x.GetCustomAttributes(typeof(InjectableAttribute), true).Length > 0)
                  .ToList();

            foreach (var type in types)
            {
                var attributes = (InjectableAttribute[])type.GetCustomAttributes(typeof(InjectableAttribute),
                true);

                var implementedInterface = attributes[0].ImplementedInterface;
                switch (attributes[0].Scope)
                {
                    case DependencyInjectionScope.Scoped:
                        services.AddScoped(implementedInterface, type);
                        break;
                    case DependencyInjectionScope.Transient:
                        services.AddTransient(implementedInterface, type);
                        break;
                    case DependencyInjectionScope.Singleton:
                        services.AddSingleton(implementedInterface, type);
                        break;
                }
            }


        }
    }
}
