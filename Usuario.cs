using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora_Platzi
{
    public class Usuario
    {
        protected string nome;
        public string Nome { get { return nome; } }

        protected string login;
        public string Login { get { return login; } }

        protected string senha;
        public string Senha { get { return senha; } }
    }
}