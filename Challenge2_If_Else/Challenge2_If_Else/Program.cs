using System;

namespace Challenge2_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("NEGATIVO");
            }

            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }

        }
    }
}