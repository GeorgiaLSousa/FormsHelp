using FormsHelp.Models;
using Microsoft.EntityFrameworkCore;

namespace FormsHelp.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext()
		{
		}

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				string dbPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "helpdesk.db");
				optionsBuilder.UseSqlite($"Data Source={dbPath}");
			}
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Esta linha força o EF Core a converter o Enum em texto na hora de salvar e ler do banco
            modelBuilder.Entity<Chamado>()
                .Property(c => c.Categoria)
                .HasConversion<string>();

            // Aproveite e faça o mesmo para a Prioridade e Status se eles também salvarem como texto
            modelBuilder.Entity<Chamado>()
                .Property(c => c.Prioridade)
                .HasConversion<string>();

            modelBuilder.Entity<Chamado>()
                .Property(c => c.Status)
                .HasConversion<string>();
        }

        public DbSet<Usuario> Usuarios { get; set; }

		public DbSet<Categoria> Categorias { get; set; }

		public DbSet<Chamado> Chamados { get; set; }

		public DbSet<Comentario> Comentarios { get; set; }
	}
}
