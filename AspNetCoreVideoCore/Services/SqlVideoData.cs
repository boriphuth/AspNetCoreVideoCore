﻿using AspNetCoreVideoCore.Data;
using AspNetCoreVideoCore.Entities;
using System.Collections.Generic;

namespace AspNetCoreVideoCore.Services
{
    public class SqlVideoData : IVideoData
    {
        private VideoDbContext _db;

        public SqlVideoData(VideoDbContext db)
        {
            _db = db;
        }

        public void Add(Video video)
        {
            _db.Add(video);
            _db.SaveChanges();
        }

        public Video Get(int id)
        {
            return _db.Find<Video>(id);
        }

        public IEnumerable<Video> GetAll()
        {
            return _db.Videos;
        }
    }
}