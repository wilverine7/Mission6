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

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieId = 1,
                    MovieTitle = "Avengers, The",
                    Category ="Action/Adventure",
                    Year = 2012,
                    DirectorFirstName = "Joss",
                    DirectorLastName = "Whedon",
                    Rating = "PG-13"
                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    MovieTitle = "Back to the Future",
                    Category = "Comedy",
                    Year = 1985,
                    DirectorFirstName = "Robert",
                    DirectorLastName = "Zemeckis",
                    Rating = "PG"

                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    MovieTitle = "About Time",
                    Category = "Drama",
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
