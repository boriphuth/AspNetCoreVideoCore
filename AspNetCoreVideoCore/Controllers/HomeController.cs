using AspNetCoreVideoCore.Models;
using AspNetCoreVideoCore.Services;
using AspNetCoreVideoCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AspNetCoreVideoCore.Controllers
{
    public class HomeController : Controller
    {
        private IVideoData _videos;

        public HomeController(IVideoData videos)
        {
            _videos = videos;
        }

        public ViewResult Index()
        {
            var model = _videos.GetAll().Select(video =>
                new VideoViewModel
                {
                    Id = video.Id,
                    Title = video.Title,
                    Genre = Enum.GetName(typeof(Genres), video.GenreId)
                });

            return View(model);
        }
    }
}
