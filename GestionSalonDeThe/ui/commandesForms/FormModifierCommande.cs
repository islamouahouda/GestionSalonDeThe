using GestionSalonDeThe.backend.dao.sqlserver;
using GestionSalonDeThe.backend.dao;
using GestionSalonDeThe.backend.services;
using GestionSalonDeThe.BACKEND.ENTITIES;
using GestionSalonDeThe.ui.boissonsForms;
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
    public partial class FormModifierCommande : Form
    {
        private Commande commande;
        private List<BoissonCommandee> boissonsCommandees;
        private ICommandeService _commandeService;
        private IServeurService _serveurService;

        public FormModifierCommande(Commande commande, ICommandeService commandeService, IServeurService serveurService)
        {
            InitializeComponent();
            this.commande = commande;
            this._commandeService = commandeService;
            this._serveurService = serveurService;
            ChargerInformationsCommande();
        }

        private void ChargerInformationsCommande()
        {
            textBoxClientId.Text = commande.IdServeur.ToString(); // Utilisez IdServeur au lieu d'IdClient
            textBoxClientName.Text = commande.Serveur.Nom; // Utilisez Serveur.Nom au lieu de NomClient
            dateTimePickerDateCommande.Value = commande.DateCom; // Utilisez DateCom au lieu de Date

            // Charger les boissons commandées pour cette commande
            boissonsCommandees = _commandeService.RecupererBoissonsCommandees(commande.IdCommande); // Utilisez IdCommande au lieu d'Id
            dataGridViewBoissonsCommandees.DataSource = boissonsCommandees;
        }

        private void buttonModifierBoisson_Click(object sender, EventArgs e)
        {
            /*if (dataGridViewBoissonsCommandees.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewBoissonsCommandees.SelectedRows[0].Index;
                BoissonCommandee boissonAmodifier = boissonsCommandees[selectedIndex];

                // Remplacez "FormModifierBoisson" par le nom de votre formulaire de modification de boisson
                FormModifierBoisson formModifierBoisson = new FormModifierBoisson(boissonAmodifier);
                DialogResult result = formModifierBoisson.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Mettre à jour la liste des boissons commandées et rafraîchir la grille de données
                    boissonsCommandees[selectedIndex] = formModifierBoisson.BoissonModifiee;
                    dataGridViewBoissonsCommandees.DataSource = null;
                    dataGridViewBoissonsCommandees.DataSource = boissonsCommandees;
                }
            }*/
        }

        private void buttonSupprimerBoisson_Click(object sender, EventArgs e)
        {
            /*if (dataGridViewBoissonsCommandees.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewBoissonsCommandees.SelectedRows[0].Index;
                BoissonCommandee boissonASupprimer = boissonsCommandees[selectedIndex];

                // Supprimer la boisson commandée de la liste et rafraîchir la grille de données
                boissonsCommandees.RemoveAt(selectedIndex);
                dataGridViewBoissonsCommandees.DataSource = null;
                dataGridViewBoissonsCommandees.DataSource = boissonsCommandees;

                // Supprimer la boisson commandée de la base de données
                // Remplacez "IBOISSONCOMMANDEEDAO" par le nom de l'interface DAO pour les boissons commandées
                IBOISSONCOMMANDEEDAO boissonCommandeeDAO = new BoissonCommandeeDAO(); // Utilisez votre implémentation DAO ici
                boissonCommandeeDAO.DeleteBoissonCommandee(boissonASupprimer.Id);
            }*/
        }

        private void buttonEnregistrerModifications_Click(object sender, EventArgs e)
        {
            commande.DateCom = dateTimePickerDateCommande.Value; // Utilisez DateCom au lieu de Date
            _commandeService.UpdateCommande(commande); // Utilisez UpdateCommande au lieu de MettreAJourCommande
            DialogResult = DialogResult.OK;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
