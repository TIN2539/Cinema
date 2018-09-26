using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Data;
using Cinema.Domain.Models;

namespace Cinema.Domain
{
    public class CinemaManager : ICinemaManager
    {
        private readonly ICinemaDataService dataService;

        public CinemaManager(ICinemaDataService dataService)
        {
            this.dataService = dataService;
        }

        public IEnumerable<Movie> GetMovies()
        {
            ICinemaDataGateway dataGateway = dataService.OpenDataGateway();
            IEnumerable<Movie> movies = dataGateway.GetMovies();
            dataService.CloseDataGateway(dataGateway);
            return movies;
        }
    }
}
