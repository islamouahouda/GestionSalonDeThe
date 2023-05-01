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
            cbServeurs = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cbBoissons = new ComboBox();
            nudQuantite = new NumericUpDown();
            label3 = new Label();
            btnAjouterBoisson = new Button();
            dataGridViewBoissonsCommandees = new DataGridView();
            btnSupprimerBoisson = new Button();
            label4 = new Label();
            txtTotal = new TextBox();
            btnConfirmer = new Button();
            btnAnnuler = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBoissonsCommandees).BeginInit();
            SuspendLayout();
            // 
            // cbServeurs
            // 
            cbServeurs.FormattingEnabled = true;
            cbServeurs.Location = new Point(124, 57);
            cbServeurs.Name = "cbServeurs";
            cbServeurs.Size = new Size(299, 23);
            cbServeurs.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 60);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Serveur:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 90);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Boissons:";
            // 
            // cbBoissons
            // 
            cbBoissons.FormattingEnabled = true;
            cbBoissons.Location = new Point(124, 90);
            cbBoissons.Name = "cbBoissons";
            cbBoissons.Size = new Size(299, 23);
            cbBoissons.TabIndex = 3;
            // 
            // nudQuantite
            // 
            nudQuantite.Location = new Point(124, 119);
            nudQuantite.Name = "nudQuantite";
            nudQuantite.Size = new Size(299, 23);
            nudQuantite.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 129);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantité:";
            // 
            // btnAjouterBoisson
            // 
            btnAjouterBoisson.AccessibleRole = AccessibleRole.None;
            btnAjouterBoisson.Location = new Point(49, 162);
            btnAjouterBoisson.Name = "btnAjouterBoisson";
            btnAjouterBoisson.Size = new Size(184, 23);
            btnAjouterBoisson.TabIndex = 6;
            btnAjouterBoisson.Text = "btnAjouterBoisson";
            btnAjouterBoisson.UseVisualStyleBackColor = true;
            btnAjouterBoisson.Click += btnAjouterBoisson_Click;
            // 
            // dataGridViewBoissonsCommandees
            // 
            dataGridViewBoissonsCommandees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBoissonsCommandees.Location = new Point(429, 57);
            dataGridViewBoissonsCommandees.Name = "dataGridViewBoissonsCommandees";
            dataGridViewBoissonsCommandees.RowTemplate.Height = 25;
            dataGridViewBoissonsCommandees.Size = new Size(480, 172);
            dataGridViewBoissonsCommandees.TabIndex = 7;
            // 
            // btnSupprimerBoisson
            // 
            btnSupprimerBoisson.Location = new Point(248, 162);
            btnSupprimerBoisson.Name = "btnSupprimerBoisson";
            btnSupprimerBoisson.Size = new Size(175, 23);
            btnSupprimerBoisson.TabIndex = 8;
            btnSupprimerBoisson.Text = "btnSupprimerBoisson";
            btnSupprimerBoisson.UseVisualStyleBackColor = true;
            btnSupprimerBoisson.Click += btnSupprimerBoisson_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 209);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 9;
            label4.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(89, 206);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(334, 23);
            txtTotal.TabIndex = 10;
            // 
            // btnConfirmer
            // 
            btnConfirmer.Location = new Point(824, 235);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(83, 23);
            btnConfirmer.TabIndex = 11;
            btnConfirmer.Text = "btnConfirmer";
            btnConfirmer.UseVisualStyleBackColor = true;
            btnConfirmer.Click += btnConfirmer_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(743, 235);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 23);
            btnAnnuler.TabIndex = 12;
            btnAnnuler.Text = "btnAnnuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // FormAjouterCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 358);
            Controls.Add(btnAnnuler);
            Controls.Add(btnConfirmer);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(btnSupprimerBoisson);
            Controls.Add(dataGridViewBoissonsCommandees);
            Controls.Add(btnAjouterBoisson);
            Controls.Add(label3);
            Controls.Add(nudQuantite);
            Controls.Add(cbBoissons);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbServeurs);
            Name = "FormAjouterCommande";
            Text = "FormAjouterCommande";
            ((System.ComponentModel.ISupportInitialize)nudQuantite).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBoissonsCommandees).EndInit();
            ResumeLayout(false);
            PerformLayout();
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