using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkPractice.Controllers.Models
{
    public class Vendedor : Pessoa
    {
        public Vendedor(string nome, DateTime dateTime) : base(nome, dateTime)
        {
        }

        public decimal PorcentagemComissao { get; set; } = 0;
        public string Setor { get; set; }
        public decimal Salario { get; set; }
    }
}
