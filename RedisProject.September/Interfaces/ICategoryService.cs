using RedisProject.September.Model;

namespace RedisProject.September.Interfaces
{
    public interface ICategoryService
    {
        public Task<List<CategoryDTO>> GetAllCategory();
    }
}
