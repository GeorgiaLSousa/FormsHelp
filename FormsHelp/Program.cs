using FormsHelp.Data;
using FormsHelp.Repositories;
using FormsHelp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace FormsHelp
{
    internal class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            // BD SQLLite
            string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "helpdesk.db");
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite($"Data Source={dbPath}"));

            // REGISTRO DAS DEPENDÊNCIAS
            services.AddScoped<UsuarioService>();
            services.AddScoped<UsuarioRepositories>();

            services.AddScoped<ChamadoService>();
            services.AddScoped<ChamadoRepositories>();


            // Registrar os formulários para que possam receber injeção de dependência
            services.AddTransient<UI.Login>();
            services.AddTransient<UI.Cadastro>();
            services.AddTransient<UI.DetalheAnalista>();
            services.AddTransient<UI.DashboardCliente>();
            services.AddTransient<UI.DashboardAnalista>();
            services.AddTransient<UI.NovoChamado>();
            services.AddTransient<UI.DetalhesUsuario>();
            services.AddTransient<UI.AtualizarChamado>();

            ServiceProvider = services.BuildServiceProvider();

            // Lidar com o Banco de Dados (Migrations)
            using (var scope = ServiceProvider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                // Apenas em ambiente de desenvolvimento, em produção seria melhor gerenciar por fora
                var hasPendingMigrations = db.Database.GetPendingMigrations().Any();

                if (hasPendingMigrations)
                {
                    // Alerta: Caso precise recriar o banco
                    // db.Database.EnsureDeleted(); // apaga tudo
                    db.Database.Migrate();       // recria com migrations
                }
            }

            // Iniciar a aplicação resolvendo o formulário inicial da Injeção de Dependências
            // Iniciar a aplicação resolvendo o formulário 'DetalheAnalista' através da injeção de dependência
            Application.Run(ServiceProvider.GetRequiredService<UI.Login>());
        }
    }
}
