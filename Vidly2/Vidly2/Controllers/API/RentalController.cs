using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly2.DTOs;
using Vidly2.Models;

namespace Vidly2.Controllers.API
{
    public class RentalController : ApiController
    {
        private readonly ApplicationDbContext _context;
        public RentalController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult NewRent(NewRentalDTO newRental)
        {

            var customer = _context.Customers.Single(c => c.Id.Equals(newRental.CustomerId));
            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();
            //var movies2 = _context.Movies.Where(m => m.Id.Equals(newRental.MovieIds));

            foreach (var movie in movies)
            {
                if (movie.AvailableStock == 0)
                    return BadRequest("Movie is not available");

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                movie.AvailableStock -= 1;
                _context.Rentals.Add(rental);

            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
