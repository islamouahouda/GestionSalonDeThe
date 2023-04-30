using GestionSalonDeThe.backend.services;
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

        public FormCommandes(ICommandeService commandeService, IServeurService serveurService)
        {
            InitializeComponent();
            _commandeService = commandeService;
            _serveurService = serveurService;
            LoadCommandes();
        }

        private void FormCommandes_Load(object sender, EventArgs e)
        {

        }

        private void LoadCommandes()
        {
            List<Commande> commandes = _commandeService.GetAllCommandes();
            dataGridViewBoissons.DataSource = commandes;
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            bool hasSelectedRow = dataGridViewBoissons.SelectedRows.Count > 0;
            btnModifier.Enabled = hasSelectedRow;
            btnSupprimer.Enabled = hasSelectedRow;
        }
        private int GetSelectedCommandeId()
        {
            if (dataGridViewBoissons.SelectedRows.Count > 0)
            {
                return (int)dataGridViewBoissons.SelectedRows[0].Cells["IdCommande"].Value;
            }
            return -1;
        }

        //ajouter une commande
        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

        //modifier une commande
        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

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
