using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2003-10-10"),
                        Genre = "Drama",
                        Price = 7.99M,
                        Rating = "PG",
                        ImageName = "besttwoyears.jpg"
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-2-1"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG",
                        ImageName = "singlesward.jpg"
                    },

                    new Movie
                    {
                        Title = "The Work and the Glory",
                        ReleaseDate = DateTime.Parse("2005-5-3"),
                        Genre = "Drama",
                        Price = 9.99M,
                        Rating = "PG",
                        ImageName = "workandtheglory.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Price = 3.99M,
                        Rating = "PG",
                        ImageName = "meetthemormons.jpg"
                    }
                    );
                    context.SaveChanges();
            }
        }
    }
}
