using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FitnessAppV2.Models;
using ApplicationModels.FitnessAppV2.Models;

namespace FitnessAppV2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FitnessClassType> FitnessClassType { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<FitnessClass> FitnessClass { get; set; }
        public DbSet<RegistrationRecord> RegistrationRecord { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
