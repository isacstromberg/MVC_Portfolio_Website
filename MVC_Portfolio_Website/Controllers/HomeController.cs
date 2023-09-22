using Microsoft.AspNetCore.Mvc;
using MVC_Portfolio_Website.Models;
using MVC_Portfolio_Website.Repositories;
using MVC_Portfolio_Website.ViewModels;
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

            var estates = repo.GetEstates();
            var model = new HomeViewModel();
            model.Estates = estates;
            return View(model);
        }

        public IActionResult Book(int? id)
        {
            var estates = repo.GetEstates();
            var model = new HomeViewModel();
            model.Estates = estates;

            return View("Index", model);
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