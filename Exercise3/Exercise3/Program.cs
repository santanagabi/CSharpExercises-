using System;
using System.Globalization;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine(nome);

            Console.WriteLine("\nQuantos quartos têm na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine(quartos);

            Console.WriteLine("\nEntre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine("\nEntre com seu último nome, idade e altura (na mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}