using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkPractice.Controllers.Models
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, DateTime dateTime) : base(nome, dateTime)
        {
        }

        public int Prestigio { get; set; }
    }
}
