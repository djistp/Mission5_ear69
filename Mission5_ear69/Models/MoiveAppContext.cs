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
        public DbSet <Category> Categories { get; set; }
        //seeding data

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryId=1, CategoryName= "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Television" }
                );


            mb.Entity<MovieResponse>().HasData(
            new MovieResponse
            { 
                MovieId = 1,
                CategoryId=2,
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
                 CategoryId = 3,
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
                  CategoryId = 3,
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
