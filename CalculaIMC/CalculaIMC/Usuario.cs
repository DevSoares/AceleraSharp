using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIMC
{
    class Usuario
    {
        public Usuario()
        {
        }

        public string Login { get; private set; }
        public string Senha { get; private set; }

        public void AlterarSenha(string novaSenha)
        {
            Senha = novaSenha;
        }

        public void CadastrarLogin(string novoLogin)
        {
            Login = novoLogin;
        }

    }
}
