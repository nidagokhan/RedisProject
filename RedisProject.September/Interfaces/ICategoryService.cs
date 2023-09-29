using RedisProject.September.Model;

namespace RedisProject.September.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryModel> GetAllCategory();
    }
}
