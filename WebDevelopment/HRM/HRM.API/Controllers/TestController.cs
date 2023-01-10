using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;
using System.Net.Security;

namespace HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("Greet")]
        public string[] Greet()
        {
            string[] greets = { "Hello", "Hi", "Namastey", "Namaskar", "Hey" };
            return greets;
        }

        [HttpGet("people")]
        public List<person> GetPeople()
        {
            var mancheharu = new List<person>
            {
            new person {name = "Ram Shrestha", Age = 15 },
            new person {name = "krishna magar", Age = 17 },
            new person {name = "Ram Shrestha" , Age = 19 }

            };

            return mancheharu;

        }



    }
    public class person
    {
        public string name { get; set; }
        public int Age { get; set; }


    }
}




