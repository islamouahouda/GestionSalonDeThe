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
    public partial class FormModifierBoisson : Form
    {
        private Boisson _boisson;

        public FormModifierBoisson(Boisson boisson)
        {
            InitializeComponent();
            _boisson = boisson;
            LoadBoissonData();
        }

        private void LoadBoissonData()
        {
            txtNom.Text = _boisson.Designation;
            txtPrix.Text = _boisson.Prix.ToString();
            txtQteStock.Text = _boisson.QteStock.ToString();
        }

        public Boisson GetBoisson()
        {
            return _boisson;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Validation des données saisies

            _boisson.Designation = txtNom.Text;
            _boisson.Prix = decimal.Parse(txtPrix.Text);
            _boisson.QteStock = int.Parse(txtQteStock.Text);

            DialogResult = DialogResult.OK;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
