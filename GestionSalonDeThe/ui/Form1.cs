using GestionSalonDeThe.backend.services;
using GestionSalonDeThe.ui;
using GestionSalonDeThe.ui.boissonsForms;
using System.Text;

namespace GestionSalonDeThe
{
    public partial class Form1 : Form
    {
        private readonly IServeurService _serveurService;
        private readonly ICommandeService _commandeService;
        private readonly IBoissonService _boissonService;
        private readonly IBoissonCommandeeService _boissonCommandeeService;

        public Form1(IServeurService serveurService, ICommandeService commandeService, IBoissonService boissonService, IBoissonCommandeeService boissonCommandeeService)
        {
            _serveurService = serveurService;
            _commandeService = commandeService;
            _boissonService = boissonService;
            _boissonCommandeeService = boissonCommandeeService;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int serveurCount = _serveurService.GetAllServeurs().Count;
            int commandeCount = _commandeService.GetAllCommandes().Count;
            int boissonCount = _boissonService.GetAllBoissons().Count;
            int boissonCommandeeCount = _boissonCommandeeService.GetAllBoissonsCommandees().Count;

            var serveurs = _serveurService.GetAllServeurs();
            var commandes = _commandeService.GetAllCommandes();

            var serveurAvecLePlusDeCommandes = serveurs.OrderByDescending(s => commandes.Count(c => c.IdServeur == s.IdServeur)).FirstOrDefault();

            string debugInfo = $"Debug Info:\n" +
                               $"- Serveurs: {serveurCount}\n" +
                               $"- Commandes: {commandeCount}\n" +
                               $"- Boissons: {boissonCount}\n" +
                               $"- Boissons commandées: {boissonCommandeeCount}\n" +
                               $"- Serveur avec le plus de commandes: {(serveurAvecLePlusDeCommandes == null ? "N/A" : serveurAvecLePlusDeCommandes.ToString())}";

            MessageBox.Show(debugInfo, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormServeurs fs = new FormServeurs(_serveurService);
            fs.Show();
        }

        private void gestionnaireDesServerusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServeurs fs = new FormServeurs(_serveurService);
            fs.Show();
        }

        private void gestionnaireDesBoissonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBoissons bs = new FormBoissons(_boissonService);
            bs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBoissons bs = new FormBoissons(_boissonService);
            bs.Show();
        }


        //util pour le debug
        string GetTop3Items<T>(IList<T> items)
        {
            StringBuilder sb = new StringBuilder();
            int count = Math.Min(3, items.Count);
            for (int i = 0; i < count; i++)
            {
                sb.AppendLine($"  - {items[i].ToString()}");
            }
            return sb.ToString();
        }
    }
}