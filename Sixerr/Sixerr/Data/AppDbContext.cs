using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sixerr.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Sixerr.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }

    public class EmployeeFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("your connection string");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
