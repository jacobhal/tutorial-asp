using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TutorialASP.Models;
using TutorialASP.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TutorialASP.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult AllMovies()
        {
            var movies = new List<Movie>
            {
                new Movie { Name = "Shrek" },
                new Movie { Name = "Star Wars" }
            };

            var viewModel = new AllMoviesViewModel { Movies = movies };

            return View(viewModel);
        }
        // GET: /<controller>/random
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer>
            {
                new Customer { Name = "C1" },
                new Customer { Name = "C2" }
            };

            var viewModel = new RandomMovieViewModel { Movie = movie, Customers = customers };

            // This is what return View(movie) does
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model

            //return Content("Hej ");
            //return NotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month); 
        }
    }
}
