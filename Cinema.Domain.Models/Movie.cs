using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.Models
{
    public sealed class Movie
    {
        private readonly MovieTitle title;
        private readonly DateTime date;
        private readonly Language language;
        private readonly IEnumerable<Actor> actors;
        private readonly Producer producer;

        public Movie(MovieTitle title, DateTime date, Language language, IEnumerable<Actor> actors, Producer producer)
        {
            this.title = title;
            this.date = date;
            this.language = language;
            this.actors = actors;
            this.producer = producer;
        }

        public MovieTitle Title => title;

        internal DateTime Date => date;

        internal Language Language => language;

        internal IEnumerable<Actor> Actors => actors;

        internal Producer Producer => producer;
    }
}
