using GestionSalonDeThe.BACKEND.ENTITIES;
using GestionSalonDeThe.backend.dao;
using System.Collections.Generic;

namespace GestionSalonDeThe.backend.services.sqlserver_services
{
    public class CommandeService : ICommandeService
    {
        private readonly ICommandeDAO _commandeDAO;

        public CommandeService(ICommandeDAO commandeDAO)
        {
            _commandeDAO = commandeDAO;
        }

        public List<Commande> GetAllCommandes()
        {
            return _commandeDAO.GetAllCommandes();
        }

        public Commande GetCommandeById(int idCommande)
        {
            return _commandeDAO.GetCommandeById(idCommande);
        }

        public void AddCommande(Commande commande)
        {
            _commandeDAO.AddCommande(commande);
        }

        public void UpdateCommande(Commande commande)
        {
            _commandeDAO.UpdateCommande(commande);
        }

        public void DeleteCommande(int idCommande)
        {
            _commandeDAO.DeleteCommande(idCommande);
        }

        public List<BoissonCommandee> RecupererBoissonsCommandees(int idCommande)
        {
            return _commandeDAO.GetBoissonsCommandeesByCommandeId(idCommande);
        }

    }
}
