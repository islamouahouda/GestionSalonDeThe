using GestionSalonDeThe.backend.services;
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
            // TODO: Charger la liste des commandes et mettre à jour le DataGridView
        }

        private void UpdateButtons()
        {
            // TODO: Activer ou désactiver les boutons Détails et Supprimer en fonction de la sélection
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
