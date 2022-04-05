using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Vidly2.Models;

namespace Vidly2.EntityConfiguration
{
    public class MembershipTypeConfiguration:EntityTypeConfiguration<MembershipType>
    {
        public MembershipTypeConfiguration()
        {
            Property(m => m.Name)
                .HasMaxLength(255);
        }
    }
}