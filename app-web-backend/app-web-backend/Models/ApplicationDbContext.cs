using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    public class ApplicationDbContext : DbContext
    {
        // passa do startup as configurações e coloca no contexto da aplicação
        // configuração do entity framework
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // criar o banco de dados
            // ferramentas -> gerenciador de pacotes -> console gerenciador de pacotes
            // comandos migrations
            // 1 - add-migration "Nome da Migration"
            // 2 - update-database
        }

        // criar veiculos e configurando a tabela no banco de dados
        // coleção de veiculos
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
