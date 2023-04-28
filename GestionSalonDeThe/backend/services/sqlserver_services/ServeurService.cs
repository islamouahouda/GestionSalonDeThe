using GestionSalonDeThe.backend.dao;
using GestionSalonDeThe.BACKEND.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThe.backend.services.sqlserver_services
{
    public class ServeurService : IServeurService
    {
        private readonly IServeurDAO _serveurDAO;

        public ServeurService(IServeurDAO serveurDAO)
        {
            _serveurDAO = serveurDAO;
        }

        public List<Serveur> GetAllServeurs()
        {
            return _serveurDAO.GetAllServeurs();
        }

        public Serveur GetServeurById(int idServeur)
        {
            return _serveurDAO.GetServeurById(idServeur);
        }

        public void AddServeur(Serveur serveur)
        {
            _serveurDAO.AddServeur(serveur);
        }

        public void UpdateServeur(Serveur serveur)
        {
            _serveurDAO.UpdateServeur(serveur);
        }

        public void DeleteServeur(int idServeur)
        {
            _serveurDAO.DeleteServeur(idServeur);
        }
    }
}
