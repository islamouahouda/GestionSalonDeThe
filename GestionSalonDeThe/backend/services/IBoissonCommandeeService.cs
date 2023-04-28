using GestionSalonDeThe.BACKEND.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThe.backend.services
{
    public interface IBoissonCommandeeService
    {
        List<BoissonCommandee> GetAllBoissonsCommandees();
        BoissonCommandee GetBoissonCommandee(int idBoisson, int idCommande);
        void AddBoissonCommandee(BoissonCommandee boissonCommandee);
        void UpdateBoissonCommandee(BoissonCommandee boissonCommandee);
        void DeleteBoissonCommandee(int idBoisson, int idCommande);
    }
}
