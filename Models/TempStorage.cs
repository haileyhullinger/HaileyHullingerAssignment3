using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaileyHullingerAssignment3.Models
{
    public class TempStorage
    {
        //crete new list
        private static List<MovieResponse> movies = new List<MovieResponse>();

        //fill the list
        public static IEnumerable<MovieResponse> Movies => movies;

        public static void AddMovie(MovieResponse movie)
        {
            movies.Add(movie);
        }
    }

    
}
