using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistenteDoProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Bom dia professor!";
            string mensagemTecleAlgo = "Pressione uma tecla para sair";
            List<double> notas = new List<double>();
            string sairMenu = string.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine(title);
                try
                {
                    Console.WriteLine($"Digite a nota Nº {notas.Count + 1} do aluno");
                    notas.Add(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Todas as notas Foram Lidas?");
                    sairMenu = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n{mensagemTecleAlgo}");
                    Console.ReadKey();
                }

            } while (sairMenu != "s");

            double media = CalcularMedia(notas);
            Console.Clear();
            Console.WriteLine($"Média do 'Joãozinho' é: {media}");
            double valorMax = double.Parse(ConfigurationManager.AppSettings["valorMax"]);
            double valorMedio = double.Parse(ConfigurationManager.AppSettings["valorMedio"]);
            double valorMin = double.Parse(ConfigurationManager.AppSettings["valorMin"]);

            if (media >= valorMax)
            {
                Console.WriteLine($"Passou 'Joãozinho' PORRA\n{mensagemTecleAlgo}");
            }
            else if (media < valorMedio && media > valorMin)
            {
                Console.WriteLine($"Caraio 'Joãozinho' que vacilo\n{mensagemTecleAlgo}");
            }
            else
            {
                Console.WriteLine($"'Joãozinho' ano que vem tu consegue\n{mensagemTecleAlgo}");
            }
            Console.ReadKey();
        }

        public static double CalcularMedia(List<double> notas)
        {
            return notas.Sum() / notas.Count;
        }
    }
}
