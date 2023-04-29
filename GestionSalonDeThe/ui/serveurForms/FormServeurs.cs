using GestionSalonDeThe.backend.services;
using GestionSalonDeThe.BACKEND.ENTITIES;
using GestionSalonDeThe.ui.serveurForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSalonDeThe.ui
{
    public partial class FormServeurs : Form
    {
        private IServeurService _serveurService;

        public FormServeurs(IServeurService serveurService)
        {
            InitializeComponent();
            _serveurService = serveurService;
            LoadServeurs();
        }

        private void LoadServeurs()
        {
            List<Serveur> serveurs = _serveurService.GetAllServeurs();
            dataGridViewServeurs.DataSource = serveurs;
            UpdateButtons();
        }

        private int GetSelectedServeurId()
        {
            if (dataGridViewServeurs.SelectedRows.Count > 0)
            {
                return (int)dataGridViewServeurs.SelectedRows[0].Cells["IdServeur"].Value;
            }
            return -1;
        }


        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            using (FormAjouterServeur formAjouterServeur = new FormAjouterServeur())
            {
                DialogResult result = formAjouterServeur.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Serveur newServeur = formAjouterServeur.GetServeur();
                    _serveurService.AddServeur(newServeur);
                    LoadServeurs();
                }
            }
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            int idServeur = GetSelectedServeurId();
            if (idServeur != -1)
            {
                Serveur serveur = _serveurService.GetServeurById(idServeur);
                using (FormModifierServeur formModifierServeur = new FormModifierServeur(serveur))
                {
                    DialogResult result = formModifierServeur.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Serveur updatedServeur = formModifierServeur.GetServeur();
                        _serveurService.UpdateServeur(updatedServeur);
                        LoadServeurs();
                    }
                }
            }
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            int idServeur = GetSelectedServeurId();
            if (idServeur != -1)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce serveur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _serveurService.DeleteServeur(idServeur);
                    LoadServeurs();
                }
            }
        }

        private void dataGridViewServeurs_SelectionChanged_1(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void dataGridViewServeurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            bool hasSelectedRow = dataGridViewServeurs.SelectedRows.Count > 0;
            btnModifier.Enabled = hasSelectedRow;
            btnSupprimer.Enabled = hasSelectedRow;
        }

        private void FormServeurs_Load(object sender, EventArgs e)
        {

        }
    }
}
