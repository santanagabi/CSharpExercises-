using System;
using System.Globalization;

namespace Exercise005;

class Program
{
    static void Main(string[] args)
    {
        int codigo1, codigo2, num1, num2;
        double valor1, valor2, total;

        string[] valores = Console.ReadLine().Split(' ');
        codigo1 = int.Parse(valores[0]);
        num1 = int.Parse(valores[1]);
        valor1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        valores = Console.ReadLine().Split(' ');
        codigo2 = int.Parse(valores[0]);
        num2 = int.Parse(valores[1]);
        valor2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        total = num1 * valor1 + num2 * valor2;

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

    }
}