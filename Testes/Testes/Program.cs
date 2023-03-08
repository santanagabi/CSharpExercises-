using System;
using System.Collections.Generic;
using System.Globalization;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista vazia
            // nodo = cada elemento da lista
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("list count: " + list.Count);

            // Find recebe como argumento uma função que faz o teste 
            // expressão lambda = função anonima
            string s1 = list.Find(x => x[0] == 'A');

            string s2 = list.FindLast(x => x[0] == 'A');

            Console.WriteLine("First 'A': " + s1);
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("first position " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("last position " + pos2);

            // filtro
            Console.WriteLine(" ----------------------------------------- ");
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // Remover
            list.RemoveRange(2, 2);
            Console.WriteLine(" ----------------------------------------- ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(" ----------------------------------------- ");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}