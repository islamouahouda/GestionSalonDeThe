using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionSalonDeThe.BACKEND.ENTITIES
{
    public class BoissonCommandee
    {
        public int IdBoisson { get; set; } // Clé étrangère
        public Boisson Boisson { get; set; } // Relation avec la classe Boisson
        public int IdCommande { get; set; } // Clé étrangère
        public Commande Commande { get; set; } // Relation avec la classe Commande
        public int QuantiteCommandee { get; set; }

        public BoissonCommandee() { }

        public BoissonCommandee(Boisson boisson, Commande commande, int quantiteCommandee)
        {
            IdBoisson = boisson.IdBoisson;
            Boisson = boisson;
            IdCommande = commande.IdCommande;
            Commande = commande;
            QuantiteCommandee = quantiteCommandee;
        }

        public void AfficherBoissonCommandee()
        {
            Console.WriteLine($"Boisson: {Boisson.Designation}, Commande Id: {IdCommande}, Quantité: {QuantiteCommandee}");
        }
    }
}