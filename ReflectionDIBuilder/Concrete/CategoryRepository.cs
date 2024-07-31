using ReflectionDIBuilder.Abstract;
using ReflectionDIBuilder.Attribute;
using ReflectionDIBuilder.Enums;
using ReflectionDIBuilder.Models;

namespace ReflectionDIBuilder.Concrete
{
    [Injectable(typeof(ICategoryRepository), DependencyInjectionScope.Scoped)]
    public class CategoryRepository : ICategoryRepository
    {
        public async Task<List<Category>> GetAllCategory()
        {
            return await Task.FromResult(new List<Category>()
            {
                new Category { Id = 1,Name="Ayakkabı"},
                new Category { Id = 2,Name="Eldiven"},
                new Category { Id = 3,Name="Dış Giyim"},
                new Category { Id = 4,Name="Monitör"},
                new Category { Id = 5,Name="Kaban"},
                new Category { Id = 6,Name="T-Shirt"},
                new Category { Id = 7,Name="Şapka"},
                new Category { Id = 8,Name="Çanta"},
            });
        }
    }
}
