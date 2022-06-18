using System;
using System.Globalization;

namespace Exercise004
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, horas;
            double valorHora, salario;

            num = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine($"NUMBER = {num}");
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
           
        }
    }
}