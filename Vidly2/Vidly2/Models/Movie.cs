﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Vidly2.Models
{
    public class Movie
    {
        public int Id { get; set; }                           
        public string Name { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdd { get; set; }

        [Display(Name = "Number in Stock")]
        public int Stock { get; set; }
    }
}