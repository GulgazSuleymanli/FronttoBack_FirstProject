using Microsoft.AspNetCore.Mvc;
using TravelAgency_FronttoBack.Models;

namespace TravelAgency_FronttoBack.Controllers
{
    public class HomeController : Controller
    {
        List<CustomService> customServices= new List<CustomService>
        {
            new CustomService
            {
                Id = 1,
                Title = "Travel Management",
                Description = "--------",
                IconClass = "fas fa-bus-alt"
            },
            new CustomService
            {
                Id = 2,
                Title = "Hotels",
                Description = "--------",
                IconClass = "fas fa-hotel"
            },
            new CustomService
            {
                Id = 3,
                Title = "Guide",
                Description = "--------",
                IconClass = "far fa-address-book"
            },
            new CustomService
            {
                Id = 4,
                Title = "Assistance",
                Description = "--------",
                IconClass = "fas fa-headset"
            },
            new CustomService
            {
                Id = 5,
                Title = "Consulting",
                Description = "--------",
                IconClass = "fas fa-comments"
            },
            new CustomService
            {
                Id = 6,
                Title = "Leisure Services",
                Description = "--------",
                IconClass = "fas fa-icons"
            }
        };


        public IActionResult Index()
        {
            return View(customServices);
        }
    }
}
