using GestionSalonDeThe.BACKEND.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThe.backend.dao
{
    public interface IBoissonCommandeeDAO
    {
        List<BoissonCommandee> GetAllBoissonsCommandees();
        BoissonCommandee GetBoissonCommandee(int idBoisson, int idCommande);
        void AddBoissonCommandee(BoissonCommandee boissonCommandee);
        void UpdateBoissonCommandee(BoissonCommandee boissonCommandee);
        void DeleteBoissonCommandee(int idBoisson, int idCommande);
    }
}
