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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            // initialiser le backend
            InitializeBackend(); 
            Application.Run(new Form1());
        }

        private static void InitializeBackend()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=SalonDeTheDB;Integrated Security=True";

            // DAO instances
            var serveurDAO = new GestionSalonDeThe.backend.dao.sqlserver.ServeurDAO(connectionString);
            var commandeDAO = new GestionSalonDeThe.backend.dao.sqlserver.CommandeDAO(connectionString);
            var boissonDAO = new GestionSalonDeThe.backend.dao.sqlserver.BoissonDAO(connectionString);
            var boissonCommandeeDAO = new GestionSalonDeThe.backend.dao.sqlserver.BoissonCommandeeDAO(connectionString);

            // Service instances
            var serveurService = new GestionSalonDeThe.backend.services.sqlserver_services.ServeurService(serveurDAO);
            var commandeService = new GestionSalonDeThe.backend.services.sqlserver_services.CommandeService(commandeDAO);
            var boissonService = new GestionSalonDeThe.backend.services.sqlserver_services.BoissonService(boissonDAO);
            var boissonCommandeeService = new GestionSalonDeThe.backend.services.sqlserver_services.BoissonCommandeeService(boissonCommandeeDAO);

            // Pass the service instances to your forms or other classes as needed
            // Example: var form1 = new Form1(serveurService, commandeService, boissonService, boissonCommandeeService);
        }
    }
}