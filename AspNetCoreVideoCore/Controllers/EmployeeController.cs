using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideoCore.Controllers
{
    [Route("company/[controller]/[action]")]
    public class EmployeeController
    {
        public string Index()
        {
            return "Hello from Employee";
        }

        public string Name()
        {
            return "Jonas";
        }

        public string Country()
        {
            return "Sweden";
        }

    }
}
