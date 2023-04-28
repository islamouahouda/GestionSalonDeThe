using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionSalonDeThe.BACKEND.ENTITIES
{
    public class Serveur
    {
        public int IdServeur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Serveur() { }

        public Serveur(int idServeur, string nom, string prenom)
        {
            IdServeur = idServeur;
            Nom = nom;
            Prenom = prenom;
        }

        public void AfficherServeur()
        {
            Console.WriteLine($"Id: {IdServeur}, Nom: {Nom}, Prénom: {Prenom}");
        }

        public override string ToString()
        {
            return $"{Prenom}, {Nom}";
        }

    }
}