using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
    public class Movie
    {
        public int Id { get; set; }                           
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdd { get; set; }
        public int Stock { get; set; }
    }
}