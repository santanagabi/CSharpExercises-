using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int num_in = 0;
            int num_out = 0;

            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    num_in = num_in + 1;
                }
                else
                {
                    num_out = num_out + 1;
                }
               
            }
            Console.WriteLine(num_in + " in");
            Console.WriteLine(num_out + " out");
        }
    }
}