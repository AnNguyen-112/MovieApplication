
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        { }
        

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        // Adding OnModelCreating method for composite key setup
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Ensure base configurations are applied

            modelBuilder.Entity<Favorite>()
        .HasKey(f => new { f.MovieId, f.UserId });

            modelBuilder.Entity<Review>()
        .HasKey(r => new { r.MovieId, r.UserId });

            modelBuilder.Entity<Purchase>()
        .HasKey(r => new { r.MovieId, r.UserId });

            modelBuilder.Entity<UserRole>()
        .HasKey(r => new { r.RoleId, r.UserId });




            // Defining composite key for MovieCast
            modelBuilder.Entity<MovieCast>()
                .HasKey(mc => new { mc.CastId, mc.Character, mc.MovieId });

            // Defining composite key for MovieGenre as an example
            modelBuilder.Entity<MovieGenre>()
                .HasKey(mg => new { mg.GenreId, mg.MovieId });
        }

    }
}
