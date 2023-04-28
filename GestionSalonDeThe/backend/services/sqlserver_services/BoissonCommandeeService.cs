using GestionSalonDeThe.BACKEND.ENTITIES;
using GestionSalonDeThe.backend.dao;
using System.Collections.Generic;

namespace GestionSalonDeThe.backend.services.sqlserver_services
{
    public class BoissonCommandeeService : IBoissonCommandeeService
    {
        private readonly IBoissonCommandeeDAO _boissonCommandeeDAO;

        public BoissonCommandeeService(IBoissonCommandeeDAO boissonCommandeeDAO)
        {
            _boissonCommandeeDAO = boissonCommandeeDAO;
        }

        public List<BoissonCommandee> GetAllBoissonsCommandees()
        {
            return _boissonCommandeeDAO.GetAllBoissonsCommandees();
        }

        public BoissonCommandee GetBoissonCommandee(int idBoisson, int idCommande)
        {
            return _boissonCommandeeDAO.GetBoissonCommandee(idBoisson, idCommande);
        }

        public void AddBoissonCommandee(BoissonCommandee boissonCommandee)
        {
            _boissonCommandeeDAO.AddBoissonCommandee(boissonCommandee);
        }

        public void UpdateBoissonCommandee(BoissonCommandee boissonCommandee)
        {
            _boissonCommandeeDAO.UpdateBoissonCommandee(boissonCommandee);
        }

        public void DeleteBoissonCommandee(int idBoisson, int idCommande)
        {
            _boissonCommandeeDAO.DeleteBoissonCommandee(idBoisson, idCommande);
        }
    }
}
