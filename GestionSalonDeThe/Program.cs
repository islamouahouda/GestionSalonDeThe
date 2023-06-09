using System;
using System.Windows.Forms;
using GestionSalonDeThe.backend.dao.sqlserver;
using GestionSalonDeThe.backend.services;
using GestionSalonDeThe.backend.services.sqlserver_services;
using Microsoft.Extensions.DependencyInjection;
using GestionSalonDeThe.backend.dao;
using System.Data.SqlClient;
using static System.Formats.Asn1.AsnWriter;

namespace GestionSalonDeThe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            // Configure Dependency Injection
            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            // Run the application with the configured services
            // L'injection dépendance

            using (var scope = serviceProvider.CreateScope())
            {
                Application.Run(new Form1(
                     "Data Source=localhost;Initial Catalog=SalonDeTheDB;Integrated Security=True",
                    scope.ServiceProvider.GetRequiredService<IServeurService>(),
                    scope.ServiceProvider.GetRequiredService<ICommandeService>(),
                    scope.ServiceProvider.GetRequiredService<IBoissonService>(),
                    scope.ServiceProvider.GetRequiredService<IBoissonCommandeeService>()));
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=SalonDeTheDB;Integrated Security=True";

            var boissonDAO = new BoissonDAO(connectionString);
            var serveurDAO = new ServeurDAO(connectionString);

            // DAO
            services.AddSingleton<IServeurDAO>(new ServeurDAO(connectionString));
            services.AddSingleton<IBoissonDAO>(new BoissonDAO(connectionString));
            services.AddSingleton<ICommandeDAO>(new CommandeDAO(connectionString, boissonDAO, serveurDAO));
            services.AddSingleton<IBoissonCommandeeDAO>(new BoissonCommandeeDAO(connectionString));

            // Services
            services.AddSingleton<IServeurService, ServeurService>();
            services.AddSingleton<ICommandeService, CommandeService>();
            services.AddSingleton<IBoissonService, BoissonService>();
            services.AddSingleton<IBoissonCommandeeService, BoissonCommandeeService>();
        }
    }
}
