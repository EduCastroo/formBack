using Cadastro.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Usuario> Usuarios {get; set;}
    }
}