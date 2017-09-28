using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideoCore.Controllers
{
    [Route("employee")]
    public class EmployeeController
    {
        [Route("")]
        public string Index()
        {
            return "Hello from Employee";
        }
        [Route("name")]
        public string Name()
        {
            return "Jonas";
        }

        [Route("country")]
        public string Country()
        {
            return "Sweden";
        }

    }
}
