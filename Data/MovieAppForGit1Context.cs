using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorWebAppMovies.Models;

namespace MovieAppForGit1.Data
{
    public class MovieAppForGit1Context : DbContext
    {
        public MovieAppForGit1Context (DbContextOptions<MovieAppForGit1Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorWebAppMovies.Models.Movie> Movie { get; set; } = default!;
    }
}
