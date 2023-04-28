using GestionSalonDeThe.BACKEND.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThe.backend.dao.sqlserver
{
    public class BoissonDAO : IBoissonDAO
    {
        private string _connectionString;

        public BoissonDAO(string connectionString)
        {
            _connectionString = connectionString;
        }

        void IBoissonDAO.AddBoisson(Boisson boisson)
        {
            throw new NotImplementedException();
        }

        void IBoissonDAO.DeleteBoisson(int idBoisson)
        {
            throw new NotImplementedException();
        }

        List<Boisson> IBoissonDAO.GetAllBoissons()
        {
            throw new NotImplementedException();
        }

        Boisson IBoissonDAO.GetBoissonById(int idBoisson)
        {
            throw new NotImplementedException();
        }

        void IBoissonDAO.UpdateBoisson(Boisson boisson)
        {
            throw new NotImplementedException();
        }
    }
}
