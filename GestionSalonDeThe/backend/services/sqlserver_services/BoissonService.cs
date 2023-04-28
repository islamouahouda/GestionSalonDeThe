using GestionSalonDeThe.BACKEND.ENTITIES;
using GestionSalonDeThe.backend.dao;
using System.Collections.Generic;

namespace GestionSalonDeThe.backend.services.sqlserver_services
{
    public class BoissonService : IBoissonService
    {
        private readonly IBoissonDAO _boissonDAO;

        public BoissonService(IBoissonDAO boissonDAO)
        {
            _boissonDAO = boissonDAO;
        }

        public List<Boisson> GetAllBoissons()
        {
            return _boissonDAO.GetAllBoissons();
        }

        public Boisson GetBoissonById(int idBoisson)
        {
            return _boissonDAO.GetBoissonById(idBoisson);
        }

        public void AddBoisson(Boisson boisson)
        {
            _boissonDAO.AddBoisson(boisson);
        }

        public void UpdateBoisson(Boisson boisson)
        {
            _boissonDAO.UpdateBoisson(boisson);
        }

        public void DeleteBoisson(int idBoisson)
        {
            _boissonDAO.DeleteBoisson(idBoisson);
        }
    }
}
