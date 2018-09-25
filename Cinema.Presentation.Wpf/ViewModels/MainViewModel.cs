using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Presentation.Wpf.ViewModels
{
   public sealed class MainViewModel
    {
        private readonly IEnumerable<string> movies;

        public MainViewModel()
        {
            movies = new[] { "Criminal", "Trash", "Scary" };
        }

        public IEnumerable<string> Movies => movies;
    }
}
