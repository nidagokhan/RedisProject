using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using RedisProject.September.Interfaces;
using RedisProject.September.Model;
using StackExchange.Redis;
using System.Text.Json.Serialization;

namespace RedisProject.September.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICacheServices _services;
        public CategoryService(ICacheServices services)
        {
            _services = services;
        }
        static List<CategoryDTO> categories => new()
        {
        new CategoryDTO { CategoryID = 1, CategoryName = "Electronic" },
        new CategoryDTO { CategoryID = 2, CategoryName = "Clothes" }
        };

        public List<CategoryDTO> GetAllCategory()
        {
            return GetCategoriesFromCache();
        }

        private List<CategoryDTO> GetCategoriesFromCache()
        {
            return _services.GetOrAdd("allcategories", () => { return categories; });
        }
    }
}
