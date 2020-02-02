using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendas = new List<double>();

            var joao = new Gerente( "Joao", 25, 70, 1.7f);
            var leo = new Funcionario( "Leonardo", 25, 70, 1.7f);
            
            vendas = joao.VenderProduto(vendas, 342.24);
            vendas = leo.VenderProduto(vendas, 178.89);

            joao.FecharCaixa(vendas);
            Console.WriteLine("\nThe mamata is Over");

            var nomes = new List<string>() { "Marcelinho", "Joana", "Paulinho" };
            var idades = new List<int>() { 30, 25, 50 };
            var pesos = new List<float>() { 120, 50, 80 };
            var alturas = new List<float>() { 1.90f, 1.6f, 1.7f };
            var pessoas = new List<Pessoa>();

            for (int i = 0; i < nomes.Count(); i++)
                pessoas.Add(new Pessoa(nomes[i], idades[i], pesos[i], alturas[i]));

            foreach (Pessoa p in pessoas)
            {
                VerificaIMC(p);
            }
        }

        static float CalculaIMC(Pessoa pessoa)
        {
            return (pessoa.Peso / (float)(Math.Pow(pessoa.Altura, 2)));
        }

        static void VerificaIMC(Pessoa pessoa)
        {
            float valorIMC = CalculaIMC(pessoa);

            if (valorIMC < 18.5){
                Console.WriteLine($"{pessoa.Nome} - Abaixo do Peso");
            }else if ((valorIMC>18.6) && (valorIMC<25))
            {
                Console.WriteLine($"{pessoa.Nome} - Peso Normal");
            }else if((valorIMC > 25) && (valorIMC < 30))
            {
                Console.WriteLine($"{pessoa.Nome} - Sobrepeso");
            }
            else
            {
                Console.WriteLine($"{pessoa.Nome} - Obesidade");
            }
        }
    }
}
