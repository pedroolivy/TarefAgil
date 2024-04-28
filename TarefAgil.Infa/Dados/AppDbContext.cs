using Microsoft.EntityFrameworkCore;
using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Infa.Dados
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Tarefas> Tarefas { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
