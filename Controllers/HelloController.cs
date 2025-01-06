
using Microsoft.AspNetCore.Mvc;

namespace JHeredia_MC_1_SayHelloEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        
        public List<string> greeting = new();

        [HttpPost]
        [Route("SayHello/{userName}")]
        public List<string> sayHello(string userName)
        {
            string hi = "Hello, " + userName;
            greeting.Add(hi);
            
            return greeting;
        }


    }
}