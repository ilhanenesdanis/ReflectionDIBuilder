using ReflectionDIBuilder.Models;

namespace ReflectionDIBuilder.Abstract
{
    
    public interface ICategoryRepository:IRepository
    {
        Task<List<Category>> GetAllCategory();
    }
}
