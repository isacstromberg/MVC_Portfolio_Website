using Microsoft.AspNetCore.Mvc;
using MVC_Portfolio_Website.Models;
using MVC_Portfolio_Website.Repositories;
using System.Diagnostics;

namespace MVC_Portfolio_Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEstateRepo repo;

        public HomeController(IEstateRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            IEstateRepo repo = new MockData();
            repo.AddEstate(new Estate(4));
            var estates = repo.GetEstates();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}