using Cinema.Domain;
using Cinema.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Presentation.Wpf.ViewModels
{
   public sealed class MainViewModel
    {
        private readonly IEnumerable<Movie> movies;

        public MainViewModel(ICinemaManager cinemaManager)
        {
            movies = cinemaManager.GetMovies();
        }

        public IEnumerable<Movie> Movies => movies;
    }
}
