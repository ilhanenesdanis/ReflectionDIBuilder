using ReflectionDIBuilder.Abstract;
using ReflectionDIBuilder.Attribute;
using ReflectionDIBuilder.Enums;

namespace ReflectionDIBuilder.Concrete
{
    [Injectable(typeof(IProductRepository), DependencyInjectionScope.Scoped)]
    public class ProductRepository : IProductRepository
    {
    }
}
