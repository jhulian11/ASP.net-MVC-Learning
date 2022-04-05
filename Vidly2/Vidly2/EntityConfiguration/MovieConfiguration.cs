using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Vidly2.Models;

namespace Vidly2.EntityConfiguration
{
    public class MovieConfiguration:EntityTypeConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);
            Property(m => m.ReleaseDate)
                .IsRequired();
            Property(m => m.DateAdd)
                .IsRequired();
        }
    }
}