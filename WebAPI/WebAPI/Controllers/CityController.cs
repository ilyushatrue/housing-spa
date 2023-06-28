using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Atlanta", "New York" };
        }
        [HttpGet("{id}")]
        public City GetCity(int id)
        {
            IEnumerable<City> cities = new List<City>()
            {
                new City { Id = 1, Name = "Atlanta"},
                new City { Id = 2, Name = "New York"},
            };
            return cities.FirstOrDefault(c => c.Id == id);
        }
    }
}
