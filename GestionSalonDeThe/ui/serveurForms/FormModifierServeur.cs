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
    public partial class FormModifierServeur : Form
    {
        private Serveur _serveur;

        public FormModifierServeur(Serveur serveur)
        {
            InitializeComponent();
            _serveur = serveur;
            LoadServeurData();
        }

        private void LoadServeurData()
        {
            txtIdServeur.Text = _serveur.IdServeur.ToString();
            txtNomServeur.Text = _serveur.Nom;
            txtPrenomServeur.Text = _serveur.Prenom;
        }

        private void FormModifierServeur_Load(object sender, EventArgs e)
        {

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
        public Serveur GetServeur()
        {
            Serveur serveur = new Serveur
            {
                IdServeur = int.Parse(txtIdServeur.Text),
                Nom = txtNomServeur.Text,
                Prenom = txtPrenomServeur.Text
            };

            return serveur;
        }
    }
}
