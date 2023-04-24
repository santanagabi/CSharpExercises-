using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ORM_Entity_Framework
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }

        // Cada genero pode estar associado a 1 ou mais filmes
        public ICollection<Filme> Filme { get; set; }
    }

    public class ApplicationContext : DbContext
    {
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Filme> Filme { get; set; }

        // Configuração do Entity Framework -> relacionamentos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Qual o banco de dados vamos usar
            // Server=.\MSSQLSERVER1 -> usando o meu
            optionsBuilder.UseSqlServer(@"Server=.\MSSQLSERVER1;Database=orm;Trusted_Connection=True;");
        }
    }

    public class Filme
    {
        // Key = chave e auto-incrementa
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int GeneroId { get; set; }

        [ForeignKey("GeneroId")]

        public Genero Genero { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationContext())
            {
                // Adicionando novo genero
                var genero = new Genero()
                {
                    Descricao = "Fantasia"
                };
                context.Genero.Add(genero);
                context.SaveChanges();

                // Adicionando novo filme
                var filme = new Filme()
                {
                    Titulo = "Harry Potter",
                    GeneroId = genero.Id
                };
                context.Filme.Add(filme);
                context.SaveChanges();
            }
        }
    }
}
