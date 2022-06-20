using System;
using System.Globalization;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            // ([0,25], (25,50], (50,75], (75,100]) 
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num < 0.0 || num > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (num <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (num <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (num <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}