using System;
using System.Collections.Generic;

namespace Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            // Adicionando elementos na minha lista inserindo no final da lista
            list.Add("Maria");
            list.Add("Anna");
            list.Add("Katy");
            list.Add("Alexa");
            // Insert = você escolhe aonde quer inserir
            list.Insert(1, "Maia");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Count = conat quantos elementos da lista possui
            Console.WriteLine("List count: " + list.Count);

            // Encontrar o primeiro ou último elemento da lista 
            string s1 = list.Find(x => x[0] == 'M');
            Console.WriteLine("First 'M' " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            // Primeira ou última posição de elemento da lista que satisfaça um predicado
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            // Filtrar a lista
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // Remover elementos da list
            list.RemoveRange(2, 2);
            Console.WriteLine("----------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Removendo todos
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Removendo elemento pela posição dele
            // Removendo elemento de uma faixa
        }
    }
}