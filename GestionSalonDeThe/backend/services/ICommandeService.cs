﻿using GestionSalonDeThe.BACKEND.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThe.backend.services
{
    public interface ICommandeService
    {
        List<Commande> GetAllCommandes();
        Commande GetCommandeById(int idCommande);
        void AddCommande(Commande commande);
        void UpdateCommande(Commande commande);
        void DeleteCommande(int idCommande);
    }
}
