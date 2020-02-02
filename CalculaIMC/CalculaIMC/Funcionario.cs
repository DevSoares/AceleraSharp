using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIMC
{
    class Funcionario : Pessoa
    {
        public Funcionario(string nome, int idade, float peso, float altura) :base(nome, idade, peso, altura)
        {
        }

        public List<double> VenderProduto(List<double> vendas, double precoProduto)
        {
            vendas.Add(precoProduto);
            CongratularFuncionário(precoProduto);
            return vendas;
        }

        private void CongratularFuncionário(double precoProduto)
        {
            Console.WriteLine($"Parabéns {Nome}, você vendeu um produto de {precoProduto} reais.");
        }
    }
}
