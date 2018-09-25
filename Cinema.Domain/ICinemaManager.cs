using Cinema.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain
{
    public interface ICinemaManager
    {
        IEnumerable<Movie> GetMovies();
    }
}
