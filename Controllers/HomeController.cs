using Eterna.DAL;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        private readonly EternaDbContext _context;

        public HomeController(EternaDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            List<Feature> features = _context.Features.ToList();

            List<Service> services = _context.Services.ToList();

            HomeVIewModel homeViewModel = new HomeVIewModel()
            {
                Features = features,
                Services = services
            };
            return View(homeViewModel);
        }

        public IActionResult DetailF(int id)
        {
            List<Feature> features = new List<Feature>
            {

                new Feature{
                    Id = 1,
                    Icon = "<i class=\"bi bi-card-checklist\"></i>",
                    Title = "Lorem Ipsum",
                    Body = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident" },
                new Feature
                {
                    Id = 2,
                    Icon = "<i class=\"bi bi-bar-chart\"></i>",
                    Title = "Dolor Sitema",
                    Body = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
                new Feature
                {
                    Id = 3,
                    Icon ="<i class=\"bi bi-binoculars\"></i>",
                    Title="Lorem Ipsum",
                    Body ="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                }
            };

            var element = features.Find(x => x.Id == id);

            return View(element);
        }

    //    public IActionResult DetailS(int id)
    //    {
    //        List<Service> services = new List<Service>
    //        {  
    //            new Service(1,"<i class=\"bx bxl-dribbble\"></i>","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
    //            new Service(2,"<i class=\"bx bx-file\"></i>","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
    //            new Service(3,"<i class=\"bx bx-tachometer\"></i>","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
    //            new Service(4,"<i class=\"bx bx-world\"></i>","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
    //            new Service(5,"<i class=\"bx bx-slideshow\"></i>","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"),
    //            new Service(6,"<i class=\"bx bx-arch\"></i>","Lorem Ipsum","Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi")
    //       };

    //        var element = services.Find(x => x.Id == id);

    //        return View(element);
    //    }
    }
}
