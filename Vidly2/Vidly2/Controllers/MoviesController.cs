using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModels;
using System.Data.Entity;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
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
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id.Equals(id));
            return View(movie);
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