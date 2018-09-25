using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.Models
{
    public sealed class Producer
    {
        private readonly string name;
        private readonly string surname;

        public Producer(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string Name => name;

        public string Surname => surname;
    }
}
