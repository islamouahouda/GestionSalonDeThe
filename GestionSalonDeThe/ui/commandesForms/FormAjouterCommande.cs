using GestionSalonDeThe.backend.services;
using GestionSalonDeThe.backend.services.sqlserver_services;
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

namespace GestionSalonDeThe.ui.commandesForms
{
    public partial class FormAjouterCommande : Form
    {
        private List<Serveur> serveurs;
        private List<Boisson> boissons;
        private List<BoissonCommandee> boissonsCommandees;
        private ICommandeService _commandeService;
        private IServeurService _serveurService;
        private IBoissonService _boissonService;

        public FormAjouterCommande(ICommandeService commandeService, IServeurService serveurService, IBoissonService boissonService)
        {
            InitializeComponent();
            _commandeService = commandeService;
            _serveurService = serveurService;
            _boissonService = boissonService;
            LoadServeurs();
            LoadBoissons();
            boissonsCommandees = new List<BoissonCommandee>();
            UpdateTotal();
        }

        private void LoadServeurs()
        {
            serveurs = _serveurService.GetAllServeurs();

            cbServeurs.DataSource = serveurs;
            cbServeurs.DisplayMember = "Nom";
            cbServeurs.ValueMember = "IdServeur";
        }

        private void LoadBoissons()
        {
            boissons = _boissonService.GetAllBoissons();

            cbBoissons.DataSource = boissons;
            cbBoissons.DisplayMember = "Designation";
            cbBoissons.ValueMember = "IdBoisson";
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            Serveur selectedServeur = cbServeurs.SelectedItem as Serveur;

            if (selectedServeur != null && boissonsCommandees.Count > 0)
            {
                Commande nouvelleCommande = new Commande
                {
                    Serveur = selectedServeur,
                    IdServeur = selectedServeur.IdServeur, // Ajoutez cette ligne pour définir la valeur IdServeur
                    BoissonsCommandees = boissonsCommandees,
                    DateCom = DateTime.Now,
                    HeureCom = DateTime.Now.TimeOfDay
                };

                // Ajoutez la commande à votre base de données en utilisant le service
                _commandeService.AddCommande(nouvelleCommande);

                MessageBox.Show("La commande a été ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un serveur et ajouter au moins une boisson à la commande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAjouterBoisson_Click(object sender, EventArgs e)
        {
            Boisson selectedBoisson = cbBoissons.SelectedItem as Boisson;
            int quantite = (int)nudQuantite.Value;

            if (selectedBoisson != null && quantite > 0)
            {
                BoissonCommandee boissonCommandee = new BoissonCommandee
                {
                    Boisson = selectedBoisson,
                    QuantiteCommandee = quantite
                };

                boissonsCommandees.Add(boissonCommandee);
                UpdateDataGridView();
                UpdateTotal();
            }
        }

        private void btnSupprimerBoisson_Click(object sender, EventArgs e)
        {
            BoissonCommandee selectedBoissonCommandee = dataGridViewBoissonsCommandees.CurrentRow.DataBoundItem as BoissonCommandee;
            if (selectedBoissonCommandee != null)
            {
                boissonsCommandees.Remove(selectedBoissonCommandee);
                UpdateDataGridView();
                UpdateTotal();
            }
        }

        private void UpdateDataGridView()
        {
            dataGridViewBoissonsCommandees.DataSource = null;
            dataGridViewBoissonsCommandees.DataSource = boissonsCommandees;
        }

        private void UpdateTotal()
        {
            double total = 0;
            foreach (BoissonCommandee boissonCommandee in boissonsCommandees)
            {
                total += (double)boissonCommandee.Boisson.Prix * (double)boissonCommandee.QuantiteCommandee;
            }
            txtTotal.Text = total.ToString("0.00");
        }

        private void btnAjouterBoisson_Click_1(object sender, EventArgs e)
        {

        }
    }
}
