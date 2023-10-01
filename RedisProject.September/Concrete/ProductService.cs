using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using RedisProject.September.Data.Context;
using RedisProject.September.Data.Entities;
using RedisProject.September.Interfaces;
using RedisProject.September.Model;

namespace RedisProject.September.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IDistributedCache _cache;
        private readonly MyDBContext _context;

        public ProductService(IDistributedCache cache, MyDBContext context)
        {
            _cache = cache;
            _context = context;
        }


        public async Task<List<ProductionDTO>> GetAllProduction()
        {

            //string result = await _cache.GetStringAsync("Production");

            //if (string.IsNullOrEmpty(result))
            //{
            //    await _cache.SetStringAsync("Production", JsonConvert.SerializeObject(productionDTO));
            //    return productionDTO;
            //}
            //productionDTO = JsonConvert.DeserializeObject<List<ProductionDTO>>(result);
            //return productionDTO;
        }
    }
}
