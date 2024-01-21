using Microsoft.AspNetCore.Mvc;
using vbinterfaces;

namespace webapi1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController(ILogger<HelloController> logger, IClass1 class1) : ControllerBase
    {
        //add constructor to inject IClass1
        private readonly IClass1 _class1 = class1;


        private readonly ILogger<HelloController> _logger = logger;

        [HttpGet(Name = "Hello")]
        public string Get()
        {
            _logger.LogInformation("Hello");
            return _class1.GetHello();
        }
    }
}
