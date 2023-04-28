using GestionSalonDeThe.BACKEND.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThe.backend.services
{
    public interface IBoissonService
    {
        List<Boisson> GetAllBoissons();
        Boisson GetBoissonById(int idBoisson);
        void AddBoisson(Boisson boisson);
        void UpdateBoisson(Boisson boisson);
        void DeleteBoisson(int idBoisson);
    }
}
