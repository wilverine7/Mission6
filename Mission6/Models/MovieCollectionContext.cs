using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base (options)
        {

        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }



        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Action/Adventure"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName ="Comedy"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Family"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Horror/Suspense"
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Miscellaneous"
                },
                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Television"
                },
                new Category
                {
                    CategoryId = 8,
                    CategoryName = "VHS"
                }

                );

            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieId = 1,
                    MovieTitle = "Avengers, The",
                    CategoryId = 1,
                    Year = 2012,
                    DirectorFirstName = "Joss",
                    DirectorLastName = "Whedon",
                    Rating = "PG-13"
                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    MovieTitle = "Back to the Future",
                    CategoryId = 2,
                    Year = 1985,
                    DirectorFirstName = "Robert",
                    DirectorLastName = "Zemeckis",
                    Rating = "PG"

                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    MovieTitle = "About Time",
                    CategoryId = 3,
                    Year = 2013,
                    DirectorFirstName = "Richard",
                    DirectorLastName = "Curtis",
                    Rating = "R",
                    Edited = true

                }
                );
        }
    }
}
