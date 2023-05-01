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
    public partial class FormCommandes : Form
    {
        private ICommandeService _commandeService;
        private IServeurService _serveurService;
        private IBoissonService _boissonService;

        public FormCommandes(ICommandeService commandeService, IServeurService serveurService, IBoissonService boissonService)
        {
            InitializeComponent();
            _commandeService = commandeService;
            _serveurService = serveurService;
            LoadCommandes();
            _boissonService = boissonService;
        }

        private void LoadCommandes()
        {
            List<Commande> commandes = _commandeService.GetAllCommandes();
            dataGridViewCommandes.DataSource = commandes;
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            bool hasSelectedRow = dataGridViewCommandes.SelectedRows.Count > 0;
            btnModifier.Enabled = hasSelectedRow;
            btnSupprimer.Enabled = hasSelectedRow;
        }
        private int GetSelectedCommandeId()
        {
            if (dataGridViewCommandes.SelectedRows.Count > 0)
            {
                return (int)dataGridViewCommandes.SelectedRows[0].Cells["IdCommande"].Value;
            }
            return -1;
        }

        //ajouter une commande
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormAjouterCommande formAjouterCommande = new FormAjouterCommande(_commandeService, _serveurService, _boissonService);
            DialogResult result = formAjouterCommande.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Recharger la liste des commandes après l'ajout
                LoadCommandes();
            }
        }

        //modifier une commande
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridViewCommandes.SelectedRows.Count > 0)
            {
                int selectedCommandeId = Convert.ToInt32(dataGridViewCommandes.SelectedRows[0].Cells["IdCommande"].Value);
                Commande selectedCommande = _commandeService.GetCommandeById(selectedCommandeId);

                FormModifierCommande formModifierCommande = new FormModifierCommande(selectedCommande, _commandeService, _serveurService);
                DialogResult result = formModifierCommande.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Recharger la liste des commandes après la modification
                    LoadCommandes();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une commande à modifier.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //supprimer la commande
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int idCommande = GetSelectedCommandeId();
            if (idCommande != -1)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette commande ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _commandeService.DeleteCommande(idCommande);
                    LoadCommandes();
                }
            }
        }

        private void dataGridViewBoissons_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }
    }
}
