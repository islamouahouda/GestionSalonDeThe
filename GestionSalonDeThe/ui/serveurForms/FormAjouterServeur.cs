using GestionSalonDeThe.BACKEND.ENTITIES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSalonDeThe.ui.serveurForms
{
    public partial class FormAjouterServeur : Form
    {
        public FormAjouterServeur()
        {
            InitializeComponent();
        }

        public Serveur GetServeur()
        {
            Serveur serveur = new Serveur
            {
                IdServeur = 0,
                Nom = txtNomServeur.Text,
                Prenom = txtPrenomServeur.Text
            };

            return serveur;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Validation des données saisies

            DialogResult = DialogResult.OK;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
