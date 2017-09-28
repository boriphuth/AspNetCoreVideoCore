using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideoCore.Controllers
{
    [Route("company/[controller]/[action]")]
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "Hello from Employee";
        }

        public ContentResult Name()
        {
            return Content("Jonas");
        }

        public string Country()
        {
            return "Sweden";
        }

    }
}
