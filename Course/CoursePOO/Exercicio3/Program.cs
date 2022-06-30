using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " 
                + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO! ");
                Console.Write("FALTARAM " + aluno.NotaRestante() + " PONTOS");
            }                       

        }
    }
}