using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericActivity
{
    class Pessoa
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} | Age {Age}";
        }
    }
}
