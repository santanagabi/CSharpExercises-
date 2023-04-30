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
        }
    }
}
