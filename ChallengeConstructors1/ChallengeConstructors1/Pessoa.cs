using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeConstructors1
{
    class Pessoa
    {
        public string Nome;

        public string Endereco;

        public string Telefone;

        // Construtor default
        public Pessoa() { }

        // Construtor
        public Pessoa(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public string primeiroNome()
        {
            return Nome;
        }
    }
}
