using AspNetCoreVideoCore.Models;
using System.Collections.Generic;

namespace AspNetCoreVideoCore.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();
    }
}
