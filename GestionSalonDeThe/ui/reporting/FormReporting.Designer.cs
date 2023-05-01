namespace GestionSalonDeThe.ui.reporting
{
    partial class FormReporting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Button btnVentesParServeur;
        private System.Windows.Forms.Button btnEtatQuantites;

        private void InitializeComponent()
        {
            dataGridViewReport = new DataGridView();
            btnVentesParServeur = new Button();
            btnEtatQuantites = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(14, 14);
            dataGridViewReport.Margin = new Padding(4, 3, 4, 3);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.Size = new Size(905, 434);
            dataGridViewReport.TabIndex = 0;
            // 
            // btnVentesParServeur
            // 
            btnVentesParServeur.Location = new Point(14, 455);
            btnVentesParServeur.Margin = new Padding(4, 3, 4, 3);
            btnVentesParServeur.Name = "btnVentesParServeur";
            btnVentesParServeur.Size = new Size(175, 27);
            btnVentesParServeur.TabIndex = 1;
            btnVentesParServeur.Text = "Ventes par serveur";
            btnVentesParServeur.UseVisualStyleBackColor = true;
            btnVentesParServeur.Click += btnVentesParServeur_Click;
            // 
            // btnEtatQuantites
            // 
            btnEtatQuantites.Location = new Point(196, 455);
            btnEtatQuantites.Margin = new Padding(4, 3, 4, 3);
            btnEtatQuantites.Name = "btnEtatQuantites";
            btnEtatQuantites.Size = new Size(175, 27);
            btnEtatQuantites.TabIndex = 2;
            btnEtatQuantites.Text = "État des quantités";
            btnEtatQuantites.UseVisualStyleBackColor = true;
            btnEtatQuantites.Click += btnEtatQuantites_Click;
            // 
            // FormReporting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btnEtatQuantites);
            Controls.Add(btnVentesParServeur);
            Controls.Add(dataGridViewReport);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormReporting";
            Text = "FormReporting";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}