﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkPractice.Controllers.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, DateTime dataNascimento)
        {
            PessoaId = pessoaId;
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get { return DateTime.Now.Year - DataNascimento.Year; } }
    }
}
