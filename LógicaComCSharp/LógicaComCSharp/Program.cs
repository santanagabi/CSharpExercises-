using System;

namespace Switch // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "gabi";

            switch (valor)
            {
                case "joao":
                    Console.WriteLine("Não é ela!");
                    break;
                case "marcelo":
                    Console.WriteLine("Não é ela!");
                    break;
                case "gabi":
                    Console.WriteLine("É esta! ");
                    break;
                default:
                    Console.WriteLine("Não achei");
                    break ;
            }
        }
    }
}
