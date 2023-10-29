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
            int selectedEstate = 0;
            var estates = repo.GetEstates();

            //var newEstate = new Estate()
            //{
            //    Model = "Timmerstuga",
            //    Name = "Lorem stuga",
            //    IsToggled = false,
            //};
            //repo.AddEstate(newEstate);
            foreach (var estate in estates)
            {
                    selectedEstate = estates[1].Id;
            }
            List<Estate> estatesToDisplay = new List<Estate>
            {
            estates[0],
            estates[1],
            estates[2]
            };
            var model = new HomeViewModel();
            model.Estates = estates;
            model.SelectedEstate = selectedEstate;
            model.DisplayedEstates = estatesToDisplay;
            return View(model);
        }

        public IActionResult Book(int? id)
        {
     
            var estates = repo.GetEstates();
            var model = new HomeViewModel();
            model.Estates = estates;

            return View("Index", model);
        }

        public IActionResult ToggleNextEstate(int selectedEstate)
        {
            int nextEstate = selectedEstate + 1;
            var estates = repo.GetEstates();
            List<Estate> estatesToDisplay = new List<Estate>();
            bool checkIfOutOfBounds = false;
            foreach (var estate in estates)
            {
                
                if (nextEstate > estate.Id)
                {
                    checkIfOutOfBounds = true;
                }
                else
                {
                    checkIfOutOfBounds = false;
                }
            }
            foreach (var estate in estates)
            {

                if(checkIfOutOfBounds == true)
                {
                   estates.Sort((a, b) => a.Id.CompareTo(b.Id));
                    int getIndex = estates.Count();
                    estatesToDisplay.Add(estates[getIndex - 1]);
                    estatesToDisplay.Add(estates[0]);
                    estatesToDisplay.Add(estates[1]);
                    nextEstate = estates[0].Id;
                    break;

                }

                if (selectedEstate == estate.Id)
                {
                    foreach (var cabin in estates)
                    {
                        if (cabin.Id == nextEstate - 1)
                        {
                            estatesToDisplay.Add(cabin);
                        }
                        if (cabin.Id == nextEstate)
                        {
                            estatesToDisplay.Add(cabin);
                        }
                        if (cabin.Id == nextEstate + 1)
                        {
                            estatesToDisplay.Add(cabin);
                        }


                       
                    }
                }

            }

            if (estatesToDisplay.Count < 3)
            {
           
                int counter = 0;
                foreach (var estate in estates)
                {
                    counter++;
                    if (counter == 1)
                    {
                        estatesToDisplay.Add(estate);
                        break;
                    }

               
                }
            }
           
            var model = new HomeViewModel();
            model.Estates = estates;
            model.SelectedEstate = nextEstate;
            model.DisplayedEstates = estatesToDisplay;

            return View("Index", model);
        }

        public IActionResult TogglePreviousEstate(int selectedEstate)
        {
            int nextEstate = selectedEstate - 1;
            var estates = repo.GetEstates();
            List<Estate> estatesToDisplay = new List<Estate>();
            bool checkIfOutOfBounds = false;

            foreach (var estate in estates)
            {

                if (nextEstate < estate.Id)
                {
                    checkIfOutOfBounds = true;
                }
                else
                {
                    checkIfOutOfBounds = false;
                    break;
                }
            }

            foreach (var estate in estates)
            {

                if (checkIfOutOfBounds == true)
                {
                    estates.Sort((a, b) => a.Id.CompareTo(b.Id));
                    int getIndex = estates.Count();
                    estatesToDisplay.Add(estates[getIndex - 2]);
                    estatesToDisplay.Add(estates[getIndex - 1]);
                    estatesToDisplay.Add(estates[0]);
                    nextEstate = estates[getIndex - 1].Id;
                    break;

                }

                if (selectedEstate == estate.Id)
                {
                    foreach (var cabin in estates)
                    {
                        if (cabin.Id == nextEstate - 1)
                        {
                            estatesToDisplay.Add(cabin);
                        }
                        if (cabin.Id == nextEstate)
                        {
                            estatesToDisplay.Add(cabin);
                        }
                        if (cabin.Id == nextEstate + 1)
                        {
                            estatesToDisplay.Add(cabin);
                        }
                    }
                }


            }

            if (estatesToDisplay.Count < 3)
            {
                List<Estate> resetEstatesToDisplay = new List<Estate>();
                int counter = 0;
                foreach (var estate in estates)
                {
                    counter++;
                    int getLastEstate = estates.Count;
                    if (counter == getLastEstate)
                    {
                        resetEstatesToDisplay.Add(estate);
                        break;
                    }
                }

                resetEstatesToDisplay.Add(estatesToDisplay[0]);
                resetEstatesToDisplay.Add(estatesToDisplay[1]);
                estatesToDisplay.Clear();
                foreach (var estate in resetEstatesToDisplay)
                {
                    estatesToDisplay.Add(estate);
                }
            }

            var model = new HomeViewModel();
            model.Estates = estates;
            model.SelectedEstate = nextEstate;
            model.DisplayedEstates = estatesToDisplay;
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