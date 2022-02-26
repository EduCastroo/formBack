using Cadastro.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.API.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base (options) {}

        public DbSet<Usuario> Usuarios {get; set;}
    }
}