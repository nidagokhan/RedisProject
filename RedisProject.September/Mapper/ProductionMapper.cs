using AutoMapper;
using RedisProject.September.Data.Entities;
using RedisProject.September.Model;

namespace RedisProject.September.Mapper
{
    public class ProductionMapper:Profile
    {
        public ProductionMapper()
        {
            CreateMap<Production, ProductionDTO>();
            CreateMap<ProductionDTO, Production>();
        }
    }
}
