using System;
using System.Globalization;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double preco;
            if (codigo == 1)
            {
                preco = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                preco = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                preco = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                preco = quantidade * 2.0;
            }
            else
            {
                preco = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}