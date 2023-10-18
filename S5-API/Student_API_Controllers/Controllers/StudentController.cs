using Microsoft.AspNetCore.Mvc;

namespace Student_API_Controllers.Controllers
{

    [ApiController]
    [Route("/api/[controller]")]
    public class StudentController : ControllerBase
    {

        [HttpGet]
        public string Hello(string Name)
        {
            return "Hello " + Name;
        }

        /*
        [HttpGet("hello")]  -> /api/Hello/hello
        public string Get()

        [HttpGet("{id}")]  -> /api/Hello/5
        public string Get(int id)
        */



    }

}
