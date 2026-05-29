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

		public DbSet<Usuario> Usuarios { get; set; }

		public DbSet<Categoria> Categorias { get; set; }

		public DbSet<Chamado> Chamados { get; set; }

		public DbSet<Comentario> Comentarios { get; set; }
	}
}
