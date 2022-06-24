using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int n = int.Parse(Console.ReadLine());

            int fatoracao = 1;
            for (int i = 1; i <= n; i++)
            {
                fatoracao = fatoracao * i;
            }
            Console.WriteLine(fatoracao);
        }
    }
}