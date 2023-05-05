using GestionSalonDeThe.BACKEND.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThe.backend.dao
{
    //Ceci s'appel CRUD
    public interface IServeurDAO
    {
        List<Serveur> GetAllServeurs();
        Serveur GetServeurById(int idServeur);
        void AddServeur(Serveur serveur);
        void UpdateServeur(Serveur serveur);
        void DeleteServeur(int idServeur);
    }
}
