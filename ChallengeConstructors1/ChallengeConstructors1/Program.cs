using System;

namespace ChallengeConstructors1
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa maria = new Pessoa();
            maria.Nome = "Maria Alice";
            maria.Endereco = "Goiania";
            maria.Telefone = "(XX) 0000-000";

            Pessoa jonas = new Pessoa("Jonas", "Feira de Santana", "(99)999-9999");

            Console.WriteLine("--------- Primeira Pessoa -----------");
            Console.WriteLine("Nome completo " + maria.Nome);
            Console.WriteLine("Seu endereço é: " + maria.Endereco);
            Console.WriteLine("Seu telefone é: " + maria.Telefone);

            Console.WriteLine("--------- Segunda Pessoa ----------");
            Console.WriteLine("Nome completo: " + jonas.Nome);
            Console.WriteLine("Seu endereço é: " + jonas.Endereco);
            Console.WriteLine("Seu telefone é: " + jonas.Telefone);
        }
    }
}