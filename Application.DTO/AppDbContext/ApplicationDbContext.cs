using Microsoft.EntityFrameworkCore;
using Application.Model;
using System.Diagnostics.CodeAnalysis;

namespace Application.DTO.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configuration());
        }
    }

}
