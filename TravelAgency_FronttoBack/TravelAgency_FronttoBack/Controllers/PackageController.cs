using Microsoft.AspNetCore.Mvc;
using TravelAgency_FronttoBack.Models;

namespace TravelAgency_FronttoBack.Controllers
{
    public class PackageController : Controller
    {
        List<Package> packages = new List<Package>
        {
            new Package
            {
                Id = 1,
                Description = "--------",
                Price = 8,
                Location = "Norway",
                Duration = 7,
                ImageUrl = "location-1.jpg"
            },
            new Package
            {
                Id = 2,
                Description = "--------",
                Price = 88,
                Location = "Italy",
                Duration = 6,
                ImageUrl = "location-2.jpg"
            },
            new Package
            {
                Id = 3,
                Description = "--------",
                Price = 888,
                Location = "Rome",
                Duration = 5,
                ImageUrl = "location-3.jpg"
            }
        };
        public IActionResult Index()
        {
            return View(packages);
        }
    }
}
