using HaileyHullingerAssignment3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HaileyHullingerAssignment3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //action for loading the podcast page
        //will return the view with the same name as method
        public IActionResult Podcast()
        {
            return View();
        }

        //action for loadig the MovieForm page
        //simply loading the page, not accepting any information
        //will return the view with the same name as method
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }


        //action for getting the movie information in httppost, once the button on the form is pressed
        //will return the confirmation view for when after the submit button has been pressed 
        [HttpPost]
        public IActionResult MovieForm(MovieResponse movieResponse)
        {
            //proof that the model is linking to the form, shows up in debug window
            //Debug.WriteLine(movieResponse.Title + " has been added");
            TempStorage.AddMovie(movieResponse);
            return View("Confirmation", movieResponse);
        }


        //action for loading the MovieList page
        public IActionResult MovieList()
        {
            
            return View(TempStorage.Movies);
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
