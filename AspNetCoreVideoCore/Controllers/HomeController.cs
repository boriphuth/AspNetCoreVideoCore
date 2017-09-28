using AspNetCoreVideoCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideoCore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var model = new Video { Id = 1, Title = "Shreck" };
            return View(model);
        }
    }
}
