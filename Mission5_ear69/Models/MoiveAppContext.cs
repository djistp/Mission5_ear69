using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission5_ear69.Models
{
    //models stuff to seed my database
    public class MoiveAppContext : DbContext
    {
        public MoiveAppContext (DbContextOptions<MoiveAppContext> options) : base(options)
        {


        }
        public DbSet <MovieResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
            new MovieResponse
            { 
                MovieId = 1,
                Category="Comedy",
                Title="This is the End",
                Year=2013,
                Director="Seth Rogen/EvenGoldberg",
                Rating="R",
                Edit= false,
                Lent="no",
                Notes="Funny film",
            },
             new MovieResponse
             {
                 MovieId = 2,
                 Category = "Drama",
                 Title = "LightHouse",
                 Year = 2019,
                 Director = "Robert Eggers",
                 Rating = "R",
                 Edit = false,
                 Lent = "no",
                 Notes = "Willem Dafoe is the best actor",
             },
              new MovieResponse
              {
                  MovieId = 3,
                  Category = "Drama",
                  Title = "Everything Everywhere All At Once",
                  Year = 2022,
                  Director = "Daniel Brothers",
                  Rating = "R",
                  Edit = false,
                  Lent = "no",
                  Notes = "The best movie ever made",
              }
            );
        }
    }
}
