using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SPAProjectMovies.Models
{
    public class SPAProjectMoviesContext : DbContext
    {
        public SPAProjectMoviesContext (DbContextOptions<SPAProjectMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<SPAProjectMovies.Models.Movie> Movie { get; set; }
    }
}
