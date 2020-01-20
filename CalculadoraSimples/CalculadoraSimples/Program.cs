using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            bool trava1 = false;
            int valor1 = 0;
            int valor2 = 0;
            do
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Digite Valor numero 1: ");
                    valor1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite Valor numero 2: ");
                    valor2 = int.Parse(Console.ReadLine());

                    trava1 = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Pressione qualquer tecla");
                    Console.ReadKey();

                }

            } while (trava1 == false);

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(@"Escolha uma das opções
                    1 - Somar
                    2 - Subtrair Segundo do Primeiro
                    3 - Subtrair Primeiro do Segundo
                    4 - Multiplicar
                    5 - Dividir Primeiro pelo Segundo
                    6 - Dividir Segundo pelo Primeiro
                    7 - Potenciar Primeiro pelo Segundo
                    8 - Potenciar Segundo pelo Primeiro
                    9 - Sair");

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine(SomaDoisValores(valor1, valor2));
                        break;

                    case 2:
                        Console.WriteLine(SubtraiSegundoDoPrimeiro(valor1, valor2));
                        break;

                    case 3:
                        Console.WriteLine(SubtraiPrimeiroDoSegundo(valor1, valor2));
                        break;

                    case 4:
                        Console.WriteLine(Multiplicar(valor1, valor2));
                        break;

                    case 5:
                        Console.WriteLine(DividirPrimeiroPeloSegundo(valor1, valor2));
                        break;

                    case 6:
                        Console.WriteLine(DividirSegundoPeloPrimeiro(valor1, valor2));
                        break;

                    case 7:
                        Console.WriteLine(PotenciarPrimeiroSegundo(valor1, valor2));
                        break;

                    case 8:
                        Console.WriteLine(PotenciarSegundoPrimeiro(valor1, valor2));
                        break;

                    case 9:
                        opcao = 9;
                        break;

                    default:
                        Console.WriteLine("Opção não disponível.");
                        break;
                }
                Console.ReadKey();

            } while (opcao != 9);
        }

        public static int SomaDoisValores(int param1, int param2)
        {
            return param1 + param2;
        }

        public static int SubtraiPrimeiroDoSegundo(int param1, int param2)
        {
            int valorRetorno = param2 - param1;
            return valorRetorno;
        }

        public static int SubtraiSegundoDoPrimeiro(int param1, int param2)
        {
            int valorRetorno = param1 - param2;
            return valorRetorno;
        }

        public static float Multiplicar(int param1, int param2)
        {
            return param1 * param2;
        }

        public static float DividirPrimeiroPeloSegundo(float param1, float param2)
        {
            float valorRetorno = param1 / param2;
            return valorRetorno;
        }

        public static float DividirSegundoPeloPrimeiro(float param1, float param2)
        {
            float valorRetorno = param2 / param1;
            return valorRetorno;
        }

        public static double PotenciarPrimeiroSegundo(float param1, float param2)
        {
            return Math.Pow(param1, param2);
        }

        public static double PotenciarSegundoPrimeiro(float param1, float param2)
        {
            return Math.Pow(param2, param1);
        }

    }
}
