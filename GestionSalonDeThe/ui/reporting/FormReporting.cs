using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSalonDeThe.ui.reporting
{
    public partial class FormReporting : Form
    {

        private string _connectionString;

        public FormReporting(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void btnVentesParServeur_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT s.IdServeur, s.Nom, COUNT(c.IdCommande) as NombreVentes FROM Serveurs s LEFT JOIN Commandes c ON s.IdServeur = c.IdServeur GROUP BY s.IdServeur, s.Nom", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewReport.DataSource = dataTable;
                }
            }
        }


        private void btnEtatQuantites_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT b.IdBoisson, b.Designation, b.QteStock - SUM(bc.QuantiteCommandee) as QuantiteRestante  FROM Boissons b  LEFT JOIN BoissonsCommandees bc ON b.IdBoisson = bc.IdBoisson  GROUP BY b.IdBoisson, b.Designation, b.QteStock", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewReport.DataSource = dataTable;
                }
            }
        }
    }
}
