using BlazorMovies.Shared.Entities;
using System.Collections.Generic;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies() 
        { 
          return new List<Movie>()
          { 
            new Movie(){Title = "TaxiDriver",  ReleaseDate = new DateTime(1991, 2, 6) },
            new Movie(){Title = "Mulan",  ReleaseDate = new DateTime(2006, 10, 19) },
            new Movie(){Title = "Baby Driver",  ReleaseDate = new DateTime(2016, 1, 23) }
          
          };
        }
    }
}
