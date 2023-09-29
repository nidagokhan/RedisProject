using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedisProject.September.Interfaces;
using RedisProject.September.Model;

namespace RedisProject.September.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CacheController : ControllerBase
    {
        private readonly ICacheServices _cacheServices;
        public CacheController(ICacheServices cacheServices)
        {
            _cacheServices= cacheServices;
        }

        [HttpGet("cache")]
        public async Task<IActionResult> Get(string key)
        {
            return Ok(await _cacheServices.GetValueAsync(key));
        }

        [HttpPost("cache")]
        public async Task<IActionResult> Post([FromBody] CacheRequestModel model)
        {
            await _cacheServices.SetValueAsync(model.Key, model.Value);
            return Ok();
        }

        [HttpDelete("cache")]
        public async Task<IActionResult> Delete(string key)
        {
            await _cacheServices.Clear(key);
            return Ok();
        }
    }
}
