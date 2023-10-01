using RedisProject.September.Data.Entities;
using RedisProject.September.Model;

namespace RedisProject.September.Interfaces
{
    public interface IProductService
    {
        public Task<List<ProductionDTO>> GetAllProduction();
    }
}
