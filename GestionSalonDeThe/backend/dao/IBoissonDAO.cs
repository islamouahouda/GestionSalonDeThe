using GestionSalonDeThe.BACKEND.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThe.backend.dao
{
    public interface IBoissonDAO
    {
        List<Boisson> GetAllBoissons();
        Boisson GetBoissonById(int idBoisson);
        void AddBoisson(Boisson boisson);
        void UpdateBoisson(Boisson boisson);
        void DeleteBoisson(int idBoisson);
    }
}
