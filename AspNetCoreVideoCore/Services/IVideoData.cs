using AspNetCoreVideoCore.Entities;
using System.Collections.Generic;

namespace AspNetCoreVideoCore.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();
        Video Get(int id);
    }
}
