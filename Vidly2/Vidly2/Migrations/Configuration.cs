using Vidly2.Models;

namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly2.Models.ApplicationDbContext context)
        {
            context.Genres.AddOrUpdate(g => g.Id, new Genre
            {
                Id = 1,
                Name = "Comedy"
            });

            context.Genres.AddOrUpdate(g => g.Id, new Genre
            {
                Id = 2,
                Name = "Action"
            });

            context.Genres.AddOrUpdate(g => g.Id, new Genre
            {
                Id = 3,
                Name = "Adventure"
            });

            context.Genres.AddOrUpdate(g => g.Id, new Genre
            {
                Id = 4,
                Name = "Romance"
            });

            context.Movies.AddOrUpdate(m => m.Id, new Movie
            {
                Id = 1,
                Name = "John Wick",
                GenreId = 2,
                ReleaseDate = new DateTime(2014, 9, 29),
                DateAdd = DateTime.Now,
                Stock = 5

            });

            context.Movies.AddOrUpdate(m => m.Id, new Movie
            {
                Id = 2,
                Name = "Lord Of The Rings",
                GenreId = 3,
                ReleaseDate = new DateTime(2001, 12, 19),
                DateAdd = DateTime.Now,
                Stock = 11

            });

            context.Movies.AddOrUpdate(m => m.Id, new Movie
            {
                Id = 3,
                Name = "Free Guy",
                GenreId = 1,
                ReleaseDate = new DateTime(2021, 8, 19),
                DateAdd = DateTime.Now,
                Stock = 7

            });

        }
    }
}
