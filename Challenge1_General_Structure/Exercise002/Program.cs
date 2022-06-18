using System;
using System.Globalization;

namespace Challenge1_General_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio, pi = 3.14159;

            Console.WriteLine("Insira o raio do circulo: ");

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * (raio * raio);

            Console.WriteLine("Área = " + area.ToString("F4", CultureInfo.InvariantCulture));
            

        }
    }
}