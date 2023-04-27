using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalonDeThe.BACKEND.ENTITIES
{
    public class Boisson
    {
        public int IdBoisson { get; set; }
        public string Designation { get; set; }
        public decimal Prix { get; set; }
        public int QteStock { get; set; }

        public Boisson() { }

        public Boisson(int idBoisson, string designation, decimal prix, int qteStock)
        {
            IdBoisson = idBoisson;
            Designation = designation;
            Prix = prix;
            QteStock = qteStock;
        }

        public void AfficherBoisson()
        {
            Console.WriteLine($"Id: {IdBoisson}, Designation: {Designation}, Prix: {Prix}, Stock: {QteStock}");
        }
    }
}