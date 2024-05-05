using GestaoColaboradoresUnidades.Model;
using Microsoft.EntityFrameworkCore;

namespace GestaoColaboradoresUnidades.Data
{
    public class ConectionContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Colaborador> Colaboradores { get; set; }

        public DbSet<Unidade> Unidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;" +
                "Database=gestao_colaboradores_unidades;" +
                "Username = postgres;" +
                "Password=1234");
        }

    

    }
}