using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.Models
{
    internal sealed class Language
    {
        private readonly string name;

        public Language(string name)
        {
            this.name = name;
        }

        public string Name => name;
    }
}
