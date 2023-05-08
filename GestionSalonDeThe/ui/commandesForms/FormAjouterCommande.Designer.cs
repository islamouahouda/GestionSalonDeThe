namespace GestionSalonDeThe.ui.commandesForms
{
    partial class FormAjouterCommande
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbServeurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoissons = new System.Windows.Forms.ComboBox();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAjouterBoisson = new System.Windows.Forms.Button();
            this.dataGridViewBoissonsCommandees = new System.Windows.Forms.DataGridView();
            this.btnSupprimerBoisson = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoissonsCommandees)).BeginInit();
            this.SuspendLayout();
            // 
            // cbServeurs
            // 
            this.cbServeurs.FormattingEnabled = true;
            this.cbServeurs.Location = new System.Drawing.Point(142, 76);
            this.cbServeurs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbServeurs.Name = "cbServeurs";
            this.cbServeurs.Size = new System.Drawing.Size(341, 28);
            this.cbServeurs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serveur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Boissons:";
            // 
            // cbBoissons
            // 
            this.cbBoissons.FormattingEnabled = true;
            this.cbBoissons.Location = new System.Drawing.Point(142, 120);
            this.cbBoissons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBoissons.Name = "cbBoissons";
            this.cbBoissons.Size = new System.Drawing.Size(341, 28);
            this.cbBoissons.TabIndex = 3;
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(142, 159);
            this.nudQuantite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(342, 27);
            this.nudQuantite.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantité:";
            // 
            // btnAjouterBoisson
            // 
            this.btnAjouterBoisson.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAjouterBoisson.Location = new System.Drawing.Point(56, 216);
            this.btnAjouterBoisson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjouterBoisson.Name = "btnAjouterBoisson";
            this.btnAjouterBoisson.Size = new System.Drawing.Size(210, 31);
            this.btnAjouterBoisson.TabIndex = 6;
            this.btnAjouterBoisson.Text = "btnAjouterBoisson";
            this.btnAjouterBoisson.UseVisualStyleBackColor = true;
            this.btnAjouterBoisson.Click += new System.EventHandler(this.btnAjouterBoisson_Click_1);
            // 
            // dataGridViewBoissonsCommandees
            // 
            this.dataGridViewBoissonsCommandees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoissonsCommandees.Location = new System.Drawing.Point(490, 76);
            this.dataGridViewBoissonsCommandees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBoissonsCommandees.Name = "dataGridViewBoissonsCommandees";
            this.dataGridViewBoissonsCommandees.RowHeadersWidth = 51;
            this.dataGridViewBoissonsCommandees.RowTemplate.Height = 25;
            this.dataGridViewBoissonsCommandees.Size = new System.Drawing.Size(549, 229);
            this.dataGridViewBoissonsCommandees.TabIndex = 7;
            // 
            // btnSupprimerBoisson
            // 
            this.btnSupprimerBoisson.Location = new System.Drawing.Point(283, 216);
            this.btnSupprimerBoisson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupprimerBoisson.Name = "btnSupprimerBoisson";
            this.btnSupprimerBoisson.Size = new System.Drawing.Size(200, 31);
            this.btnSupprimerBoisson.TabIndex = 8;
            this.btnSupprimerBoisson.Text = "btnSupprimerBoisson";
            this.btnSupprimerBoisson.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(102, 275);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(381, 27);
            this.txtTotal.TabIndex = 10;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(942, 313);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(95, 31);
            this.btnConfirmer.TabIndex = 11;
            this.btnConfirmer.Text = "btnConfirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(849, 313);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(86, 31);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "btnAnnuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormAjouterCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 477);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSupprimerBoisson);
            this.Controls.Add(this.dataGridViewBoissonsCommandees);
            this.Controls.Add(this.btnAjouterBoisson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudQuantite);
            this.Controls.Add(this.cbBoissons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbServeurs);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAjouterCommande";
            this.Text = "FormAjouterCommande";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoissonsCommandees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbServeurs;
        private Label label1;
        private Label label2;
        private ComboBox cbBoissons;
        private NumericUpDown nudQuantite;
        private Label label3;
        private Button btnAjouterBoisson;
        private DataGridView dataGridViewBoissonsCommandees;
        private Button btnSupprimerBoisson;
        private Label label4;
        private TextBox txtTotal;
        private Button btnConfirmer;
        private Button btnAnnuler;
    }
}