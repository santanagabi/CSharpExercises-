using System;

namespace ORM_Exemplo
{
    public class Genero
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }

    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int GeneroId { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}