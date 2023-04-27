using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionSalonDeThe.BACKEND.ENTITIES
{
    public class Commande
    {
        public int IdCommande { get; set; }
        public DateTime DateCom { get; set; }
        public TimeSpan HeureCom { get; set; }
        public int IdServeur { get; set; } // Clé étrangère
        public Serveur Serveur { get; set; } // Relation avec la classe Serveur
        public List<BoissonCommandee> BoissonsCommandees { get; set; } // Liste des boissons commandées

        public Commande()
        {
            BoissonsCommandees = new List<BoissonCommandee>();
        }

        public Commande(int idCommande, DateTime dateCom, TimeSpan heureCom, Serveur serveur)
        {
            IdCommande = idCommande;
            DateCom = dateCom;
            HeureCom = heureCom;
            Serveur = serveur;
            BoissonsCommandees = new List<BoissonCommandee>();
        }

        public void AjouterBoissonCommandee(BoissonCommandee boissonCommandee)
        {
            BoissonsCommandees.Add(boissonCommandee);
        }

        public void AfficherCommande()
        {
            Console.WriteLine($"Id: {IdCommande}, Date: {DateCom}, Heure: {HeureCom}, Serveur: {Serveur.Nom} {Serveur.Prenom}");
            Console.WriteLine("Boissons commandées:");
            foreach (var boissonCommandee in BoissonsCommandees)
            {
                Console.WriteLine($"  - {boissonCommandee.Boisson.Designation} (Quantité: {boissonCommandee.QuantiteCommandee})");
            }
        }
    }
}