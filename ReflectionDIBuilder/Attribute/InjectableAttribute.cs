using ReflectionDIBuilder.Enums;

namespace ReflectionDIBuilder.Attribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class InjectableAttribute : System.Attribute
    {
        public Type ImplementedInterface { get; }
        public DependencyInjectionScope Scope { get; }

        public InjectableAttribute(Type implementedInterface, DependencyInjectionScope scope)
        {
            ImplementedInterface = implementedInterface;
            Scope = scope;
        }
    }
}
