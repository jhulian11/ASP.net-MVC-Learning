using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly2.DTOs;
using Vidly2.Models;

namespace Vidly2.Controllers.API
{
    public class MoviesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/movies

        [HttpGet]
        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies.Include(m => m.Genre).ToList().Select(Mapper.Map<Movie, MovieDto>);
        }

        //GET /api/movies/1

        [HttpGet]
        public MovieDto GetMovie(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id.Equals(id));

            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Movie,MovieDto>(movie);
        }

        //POST /api/movies

        [HttpPost]
        public MovieDto CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);

            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return movieDto;
        }

        //PUT /api/mvoies/1

        [HttpPut]
        public void EditMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id.Equals(id));

            if(movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(movieDto,movieInDb);

            //movieInDb.Name = movie.Name;
            //movieInDb.ReleaseDate = movie.ReleaseDate;
            //movieInDb.DateAdd = movie.DateAdd;
            //movieInDb.GenreId = movie.GenreId;
            //movieInDb.Stock = movie.Stock;

            _context.SaveChanges();
        }

        //DELETE /api/movies/1

        [HttpDelete]

        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id.Equals(id));

            if (movie != null) _context.Movies.Remove(movie);
            _context.SaveChanges();
        }


    }
}
