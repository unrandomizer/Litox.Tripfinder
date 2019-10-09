using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Litox.Tripfinder
{
    public class Context : DbContext
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder)
        {
            contextOptionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=litoxdb;Trusted_Connection=True;");
        }
    }
}
