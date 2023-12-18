using Microsoft.AspNetCore.Http;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Repositories
{
    public class BannerRepository : IBannerRepository
    {
        private readonly AppDbContext _appDbContext;
        public BannerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Banner> Banners => _appDbContext.Banners;

        public Banner GetBannerById(int id)
        {
            return _appDbContext.Banners.Find(id);
        }

        public Banner Add(Banner banner, IFormFile photo)
        {
            AddPhoto(banner, photo);

            _appDbContext.Banners.Add(banner);
            _appDbContext.SaveChanges();
            return banner;
        }

        public Banner Edit(Banner banner, int id, IFormFile photo)
        {
            Banner b = _appDbContext.Banners.Find(id);
            if (b != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/banners", b.Banner_Image);

        
                if (photo != null)
                {
                    AddPhoto(banner, photo);
                    b.Banner_Image = banner.Banner_Image;
                }

                _appDbContext.SaveChanges();

                if (File.Exists(path) && photo != null)
                {
                    File.Delete(path);
                }
            }
            return b;
        }

        public Banner Delete(int id)
        {
            Banner b = _appDbContext.Banners.Find(id);
            if (b != null)
            {
                _appDbContext.Banners.Remove(b);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/banners", b.Banner_Image);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                _appDbContext.SaveChanges();
            }
            return b;
        }

        public void AddPhoto(Banner banner, IFormFile photo)
        {
            Random rand = new Random();
            string random = DateTime.Now.ToString("dd-MM-yyyy-HHmmss") + rand.Next(1, 1000);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/banners", random + photo.FileName);
            var stream = new FileStream(path, FileMode.Create);
            photo.CopyToAsync(stream).Wait();
            banner.Banner_Image = random + photo.FileName;
            stream.Close();
        }
    }
}
