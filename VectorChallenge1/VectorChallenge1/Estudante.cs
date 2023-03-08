using System;
using System.Globalization;

namespace VectorChallenge1
{
    class Estudante
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        // Iniciando objetos dessa classe com construtores
        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + "," + Email;
        }
    }
}
