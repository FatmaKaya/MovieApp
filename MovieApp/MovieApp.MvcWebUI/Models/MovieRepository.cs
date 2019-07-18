using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.MvcWebUI.Models
{
    public static class MovieRepository
    {
        private static List<Movie> movies = null;
        static MovieRepository()
        {
            movies = new List<Movie>() {
                new Movie(){Id=1,Name="image 1",Image="1.jpeg"},
                new Movie(){Id=2,Name="image 2",Image="2.jpeg"},
                new Movie(){Id=3,Name="image 3",Image="3.jpeg"},
                new Movie(){Id=4,Name="image 4",Image="4.jpeg"},
                new Movie(){Id=5,Name="image 5",Image="5.jpeg"},
                new Movie(){Id=6,Name="image 6",Image="6.jpeg"},
                new Movie(){Id=7,Name="image 7",Image="7.jpeg"},
                new Movie(){Id=8,Name="image 8",Image="8.jpeg"},
                new Movie(){Id=9,Name="image 9",Image="9.jpeg"},
            };
        }
        
        public static List<Movie> Movies
        {
            get
            {
                return movies;
            }
        }
        public static void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
        public static Movie GetById(int id)
        {
            return movies.FirstOrDefault(movie => movie.Id == id);
        }

    }
}
