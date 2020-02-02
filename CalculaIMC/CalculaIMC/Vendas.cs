using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIMC
{
    public class Vendas
    {
        public List<double> valores { get; set; }

        public Vendas(List<double> valores)
        {
            this.valores = valores;
        }

        public Vendas()
        {
            this.valores = new List<double>();
        }
    }
}
