using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = GetMovies().SingleOrDefault(c => c.Name.Equals("Shrek"));
            var customers = new List<Customer>
            {
                new Customer(){Name = "Junior"},
                new Customer(){Name = "Ronaldo"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customer = customers
            };

            return View(viewModel);
        }

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Name = "Shrek"},
                new Movie(){Name = "Vikings"},
                new Movie(){Name = "Lord of the Rings"}

            };
        }


    }
}