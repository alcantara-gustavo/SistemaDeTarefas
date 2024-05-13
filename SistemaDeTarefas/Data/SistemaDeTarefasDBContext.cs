using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data

{
    public class SistemaDeTarefasDBContext : DbContext //herdando DB criado
    {
        public SistemaDeTarefasDBContext(DbContextOptions<SistemaDeTarefasDBContext> options) //construtor criado usando a abreviação ctor
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; } //representação da tabela de usuarios no nosso banco de dados
        public DbSet<TarefaModel> Tarefa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
