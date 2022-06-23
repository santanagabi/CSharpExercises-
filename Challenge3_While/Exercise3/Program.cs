using System;

namespace Exercise3;
class Program
{
    static void Main(string[] args)
    {
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;

        Console.WriteLine("Insira um número de 1 até 4: ");
        int tipo = int.Parse(Console.ReadLine());

        while (tipo != 4)
        {
            if (tipo == 1)
            {
                alcool++;
            }
            else if (tipo == 2)
            {
                gasolina++;
            }
            else if (tipo == 3)
            {
                diesel++;
            }

            tipo = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
    }
}