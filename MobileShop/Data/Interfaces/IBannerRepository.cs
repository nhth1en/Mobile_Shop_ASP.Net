using Microsoft.AspNetCore.Http;
using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Interfaces
{
    public interface IBannerRepository
    {
        IEnumerable<Banner> Banners { get; }
        Banner GetBannerById(int id);
        Banner Add(Banner banner, IFormFile photo);
        Banner Edit(Banner banner, int id, IFormFile photo);
        Banner Delete(int id);
        void AddPhoto(Banner banner, IFormFile photo);
    }
}
