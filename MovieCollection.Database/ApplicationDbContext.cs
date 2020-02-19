using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieCollection.Models;
using System;

namespace MovieCollection.Database
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<People> Peoples {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoviePeople>()
                .HasKey(t => new { t.PeopleId, t.MovieId });

            modelBuilder.Entity<Premiere>()
                .HasKey(t => new { t.Country, t.MovieId });

            modelBuilder.Entity<MoviePeople>()
                .HasOne(mv => mv.Movie)
                .WithMany(mv => mv.MoviePeoples)
                .HasForeignKey(mv => mv.MovieId);

            modelBuilder.Entity<MoviePeople>()
                .HasOne(mv => mv.People)
                .WithMany(mv => mv.MoviePeoples)
                .HasForeignKey(mv => mv.PeopleId);

            modelBuilder.Entity<MovieGenre>()
                .HasKey(t => new { t.MovieId, t.GenreId });

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Movie)
                .WithMany(mg => mg.MovieGenres)
                .HasForeignKey(mg => mg.MovieId);

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Genre)
                .WithMany(mg => mg.MovieGenres)
                .HasForeignKey(mg => mg.GenreId);

            modelBuilder.Entity<MovieCountry>()
                .HasKey(t => new { t.CountryId, t.MovieId });

            modelBuilder.Entity<MovieCountry>()
                .HasOne(mg => mg.Movie)
                .WithMany(mg => mg.MovieCountries)
                .HasForeignKey(mg => mg.MovieId);

           modelBuilder.Entity<MovieCountry>()
                .HasOne(mg => mg.Country)
                .WithMany(mg => mg.MovieCountries)
                .HasForeignKey(mg => mg.CountryId);
        }

    }
}
