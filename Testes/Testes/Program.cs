using System;
using System.Collections.Generic;
using System.Globalization;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matriz = bidimensional
            double[,] mat = new double[2, 3]; // matriz 2 linhas e 3 colunas

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank); // linhas = 2
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));

        }
    }
}