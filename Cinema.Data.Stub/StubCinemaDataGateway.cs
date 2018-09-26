using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Domain.Models;

namespace Cinema.Data.Stub
{
    public class StubCinemaDataGateway : ICinemaDataGateway
    {
        public IEnumerable<Movie> GetMovies()
        {
            return new[]
            {
                new Movie(
                    new MovieTitle("Star Wars. The Last Jedi"),
                    new DateTime(2017, 12, 15),
                    new Language("English"),
                    new[]
                    {
                        new Actor("Mark", "Hamill"),
                        new Actor("Harrison", "Ford"),
                        new Actor("Ewan", "McGregor")
                    },
                    new Producer("Rian", "Johnson")
               )
            };
        }
    }
}
