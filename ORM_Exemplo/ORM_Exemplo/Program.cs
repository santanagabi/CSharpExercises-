﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ORM_Exemplo
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Filme> Filme { get; set; }
    }

    public class Filme
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int GeneroId { get; set; }

        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }
    }

    // Classe de contexto = inicia o Entity Framework
    // Importa do bacno de daods DbContext
    public class ApplicationContext : DbContext
    {
        // Tabelas do banco de dados
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Filme> Filme { get; set; }

        // Configuração do Entity Framework
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configurando qual banco de dados vou usar 
            // No caso SQL Server
            optionsBuilder.UseSqlServer(@"Server=./SQLEXPRESS;Database=orm;Trusted_Connection=True");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}