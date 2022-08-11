using Microsoft.AspNetCore.Mvc;
using MVC_WebApp.Models;

namespace MVC_WebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            return View(dogs);
        }
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //  return View("index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "Okej go back";
        }
    }
}
