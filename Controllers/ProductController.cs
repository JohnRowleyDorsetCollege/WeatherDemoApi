using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherDemoApi.Models;

namespace WeatherDemoApi.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Product product = new Product();

        [HttpGet("list")]

        public List<string> GetList()
        {

            return product.List();
        }

        [HttpGet("item/{id}")]

        public string GetItem(int id)
        {

            return product.List().ToArray()[id];
        }
    }
}
