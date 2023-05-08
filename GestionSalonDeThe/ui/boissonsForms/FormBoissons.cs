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

namespace GestionSalonDeThe.ui.boissonsForms
{
    public partial class FormBoissons : Form
    {
        private IBoissonService _boissonService;

        public FormBoissons(IBoissonService boissonService)
        {
            InitializeComponent();
            _boissonService = boissonService;
            LoadBoissons();
        }
        private void LoadBoissons()
        {
            List<Boisson> boissons = _boissonService.GetAllBoissons();
            dataGridViewBoissons.DataSource = boissons;
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            bool hasSelectedRow = dataGridViewBoissons.SelectedRows.Count > 0;
            btnModifier.Enabled = hasSelectedRow;
            btnSupprimer.Enabled = hasSelectedRow;
        }
        private int GetSelectedBoissonId()
        {
            if (dataGridViewBoissons.SelectedRows.Count > 0)
            {
                return (int)dataGridViewBoissons.SelectedRows[0].Cells["IdBoisson"].Value;
            }
            return -1;
        }

        private void FormBoissons_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (FormAjouterBoisson formAjouterBoisson = new FormAjouterBoisson())
            {
                DialogResult result = formAjouterBoisson.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Boisson newBoisson = formAjouterBoisson.GetBoisson();
                    _boissonService.AddBoisson(newBoisson);
                    LoadBoissons();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int idBoisson = GetSelectedBoissonId();
            if (idBoisson != -1)
            {
                Boisson boisson = _boissonService.GetBoissonById(idBoisson);
                using (FormModifierBoisson formModifierBoisson = new FormModifierBoisson(boisson))
                {
                    DialogResult result = formModifierBoisson.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Boisson updatedBoisson = formModifierBoisson.GetBoisson();
                        _boissonService.UpdateBoisson(updatedBoisson);
                        LoadBoissons();
                    }
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int idBoisson = GetSelectedBoissonId();
            if (idBoisson != -1)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette boisson ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _boissonService.DeleteBoisson(idBoisson);
                    LoadBoissons();
                }
            }
        }

        private void dataGridViewBoissons_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtons();

        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {

        }
    }
}
