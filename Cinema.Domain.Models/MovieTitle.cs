namespace Cinema.Domain.Models
{
    internal class MovieTitle
    {
        private readonly string name;

        public MovieTitle(string name)
        {
            this.name = name;
        }

        public string Name => name;
    }
}