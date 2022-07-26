using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 linhas e 3 colunas
            double[,] mat = new double[2, 3];

            // Quantos elementos a matriz possui no total
            Console.WriteLine(mat.Length);

            // Quantidade de linhas
            Console.WriteLine(mat.Rank);

            // Dimensão 0 tem 2 linhas
            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1));
        }
    }
}