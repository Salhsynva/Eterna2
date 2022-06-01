using Eterna.DAL;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class ServiceController : Controller
    {
        private readonly EternaDbContext _context;

        public ServiceController(EternaDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();
            return View(services);
        }

        //public IActionResult Detail(int id)
        //{
        //    List<Service> services = new List<Service>()
        //    {
        //        new Service(1,"bx bxl-dribbble","Sed ut perspiciatis","Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"),
        //        new Service(2,"bx bx-file","Sed ut perspiciatis","Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"),
        //        new Service(3,"bx bx-tachometer","Sed ut perspiciatis","Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"),
        //        new Service(4,"bx bx-world","Sed ut perspiciatis","Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"),
        //        new Service(5,"bx bx-slideshow","Sed ut perspiciatis","Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"),
        //        new Service(6,"bx bx-arch","Sed ut perspiciatis","Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia")

        //    };

        //    Service element = services.Find(x => x.Id == id);

        //    return View(element);
        //}
    }
}
