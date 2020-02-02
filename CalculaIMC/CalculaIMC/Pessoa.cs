using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIMC
{
    class Pessoa : Usuario
    {
        public Pessoa(string nome, int idade, float peso, float altura): base()
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
    }
}
