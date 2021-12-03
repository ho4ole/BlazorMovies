using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        List<Movie> movies;
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(3000);
            movies = new List<Movie>()
     {
        new Movie(){Title = "Taxi",  ReleaseDate = new DateTime(2003, 2, 6) },
        new Movie(){Title = "Mulan",  ReleaseDate = new DateTime(2006, 10, 19) },
        new Movie(){Title = "Baby Driver",  ReleaseDate = new DateTime(2016, 1, 23) }
     };
        }


        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
