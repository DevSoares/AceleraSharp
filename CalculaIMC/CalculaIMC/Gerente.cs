using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIMC
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, float peso, float altura) : base(nome, idade, peso, altura)
        {
        }

        public void FecharCaixa(List<double> vendas)
        {
            Console.WriteLine($"Parabéns {Nome}, a loja vendeu um total de {vendas.Sum()}");
        }
    }
}
