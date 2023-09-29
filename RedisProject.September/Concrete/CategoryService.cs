using RedisProject.September.Interfaces;
using RedisProject.September.Model;
using StackExchange.Redis;

namespace RedisProject.September.Concrete
{
    public class CategoryService : ICategoryService
    {
        static List<CategoryModel> categories = new List<CategoryModel>()
        {
            new CategoryModel {CategoryID=1,Name="Giyim"},
            new CategoryModel {CategoryID=2,Name="Kozmetik"},
            new CategoryModel {CategoryID=3,Name="Ayakkabı"},
            new CategoryModel {CategoryID=4,Name="Çanta"},
            new CategoryModel {CategoryID=5,Name="Aksesuar"}
        };

        public ICacheServices CacheServices { get; }
        public CategoryService(ICacheServices cacheServices)
        {
            CacheServices = cacheServices;
        }
        public List<CategoryModel> GetAllCategory()
        {
            return GetCategoriesFromCache();
        }

        private List<CategoryModel> GetCategoriesFromCache()
        {
            return CacheServices.GetOrAdd("allcategories", () => { return categories; });
        }
    }
}
