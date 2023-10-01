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
        private readonly IDistributedCache _cache;

        public CategoryService(IDistributedCache cache)
        {
            _cache = cache;
        }

        static List<CategoryDTO> categories = new List<CategoryDTO>()
        {
            new CategoryDTO {CategoryID=1,Name="Giyim"},
            new CategoryDTO {CategoryID=2,Name="Kozmetik"},
            new CategoryDTO {CategoryID=3,Name="Ayakkabı"},
            new CategoryDTO {CategoryID=4,Name="Çanta"},
            new CategoryDTO {CategoryID=5,Name="Aksesuar"}
        };

        public async Task<List<CategoryDTO>> GetAllCategory()
        {          
            string result = await _cache.GetStringAsync("Category");

            if (string.IsNullOrEmpty(result))
            {
                await _cache.SetStringAsync("Category",JsonConvert.SerializeObject(categories));
                return categories;
            }
            categories=JsonConvert.DeserializeObject<List<CategoryDTO>>(result);
            return categories;

        }
    }
}
