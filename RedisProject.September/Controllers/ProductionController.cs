using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedisProject.September.Interfaces;

namespace RedisProject.September.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionController : ControllerBase
    {
        private readonly IProductService _pservice;
        public ProductionController(IProductService pservice)
        {
            _pservice = pservice;
        }

        [HttpGet("production/getall")]
        public IActionResult GetAll()
        {
            return Ok(_pservice.GetAllProduction());
        }
    }
}
