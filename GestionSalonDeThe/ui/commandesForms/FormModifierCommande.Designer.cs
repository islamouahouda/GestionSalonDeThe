namespace GestionSalonDeThe.ui.commandesForms
{
    partial class FormModifierCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Ajouter les composants ici
        private System.Windows.Forms.Label labelCommandeId;
        private System.Windows.Forms.TextBox textBoxCommandeId;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label labelDateCommande;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCommande;
        private System.Windows.Forms.Label labelBoissonsCommandees;
        private System.Windows.Forms.DataGridView dataGridViewBoissonsCommandees;
        private System.Windows.Forms.Button buttonModifierBoisson;
        private System.Windows.Forms.Button buttonSupprimerBoisson;
        private System.Windows.Forms.Button buttonEnregistrerModifications;
        private System.Windows.Forms.Button buttonAnnuler;

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
            this.labelCommandeId = new System.Windows.Forms.Label();
            this.textBoxCommandeId = new System.Windows.Forms.TextBox();
            this.labelClientId = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.labelDateCommande = new System.Windows.Forms.Label();
            this.dateTimePickerDateCommande = new System.Windows.Forms.DateTimePicker();
            this.labelBoissonsCommandees = new System.Windows.Forms.Label();
            this.dataGridViewBoissonsCommandees = new System.Windows.Forms.DataGridView();
            this.buttonModifierBoisson = new System.Windows.Forms.Button();
            this.buttonSupprimerBoisson = new System.Windows.Forms.Button();
            this.buttonEnregistrerModifications = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoissonsCommandees)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCommandeId
            // 
            this.labelCommandeId.Location = new System.Drawing.Point(11, 27);
            this.labelCommandeId.Name = "labelCommandeId";
            this.labelCommandeId.Size = new System.Drawing.Size(114, 31);
            this.labelCommandeId.TabIndex = 0;
            this.labelCommandeId.Text = "ID Commande :";
            // 
            // textBoxCommandeId
            // 
            this.textBoxCommandeId.Location = new System.Drawing.Point(137, 27);
            this.textBoxCommandeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCommandeId.Name = "textBoxCommandeId";
            this.textBoxCommandeId.ReadOnly = true;
            this.textBoxCommandeId.Size = new System.Drawing.Size(114, 27);
            this.textBoxCommandeId.TabIndex = 1;
            // 
            // labelClientId
            // 
            this.labelClientId.Location = new System.Drawing.Point(11, 80);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(114, 31);
            this.labelClientId.TabIndex = 2;
            this.labelClientId.Text = "ID Client :";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(137, 80);
            this.textBoxClientId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.ReadOnly = true;
            this.textBoxClientId.Size = new System.Drawing.Size(114, 27);
            this.textBoxClientId.TabIndex = 3;
            // 
            // labelClientName
            // 
            this.labelClientName.Location = new System.Drawing.Point(11, 133);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(114, 31);
            this.labelClientName.TabIndex = 4;
            this.labelClientName.Text = "Nom Client :";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(137, 133);
            this.textBoxClientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.ReadOnly = true;
            this.textBoxClientName.Size = new System.Drawing.Size(114, 27);
            this.textBoxClientName.TabIndex = 5;
            // 
            // labelDateCommande
            // 
            this.labelDateCommande.Location = new System.Drawing.Point(11, 187);
            this.labelDateCommande.Name = "labelDateCommande";
            this.labelDateCommande.Size = new System.Drawing.Size(114, 31);
            this.labelDateCommande.TabIndex = 6;
            this.labelDateCommande.Text = "Date Commande :";
            // 
            // dateTimePickerDateCommande
            // 
            this.dateTimePickerDateCommande.Location = new System.Drawing.Point(137, 187);
            this.dateTimePickerDateCommande.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDateCommande.Name = "dateTimePickerDateCommande";
            this.dateTimePickerDateCommande.Size = new System.Drawing.Size(228, 27);
            this.dateTimePickerDateCommande.TabIndex = 7;
            // 
            // labelBoissonsCommandees
            // 
            this.labelBoissonsCommandees.Location = new System.Drawing.Point(11, 240);
            this.labelBoissonsCommandees.Name = "labelBoissonsCommandees";
            this.labelBoissonsCommandees.Size = new System.Drawing.Size(114, 31);
            this.labelBoissonsCommandees.TabIndex = 8;
            this.labelBoissonsCommandees.Text = "Boissons Commandées :";
            // 
            // dataGridViewBoissonsCommandees
            // 
            this.dataGridViewBoissonsCommandees.ColumnHeadersHeight = 29;
            this.dataGridViewBoissonsCommandees.Location = new System.Drawing.Point(11, 293);
            this.dataGridViewBoissonsCommandees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBoissonsCommandees.Name = "dataGridViewBoissonsCommandees";
            this.dataGridViewBoissonsCommandees.RowHeadersWidth = 51;
            this.dataGridViewBoissonsCommandees.Size = new System.Drawing.Size(514, 267);
            this.dataGridViewBoissonsCommandees.TabIndex = 9;
            // 
            // buttonModifierBoisson
            // 
            this.buttonModifierBoisson.Location = new System.Drawing.Point(549, 293);
            this.buttonModifierBoisson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModifierBoisson.Name = "buttonModifierBoisson";
            this.buttonModifierBoisson.Size = new System.Drawing.Size(86, 31);
            this.buttonModifierBoisson.TabIndex = 10;
            this.buttonModifierBoisson.Text = "Modifier";
            this.buttonModifierBoisson.Click += new System.EventHandler(this.buttonModifierBoisson_Click_1);
            // 
            // buttonSupprimerBoisson
            // 
            this.buttonSupprimerBoisson.Location = new System.Drawing.Point(549, 347);
            this.buttonSupprimerBoisson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSupprimerBoisson.Name = "buttonSupprimerBoisson";
            this.buttonSupprimerBoisson.Size = new System.Drawing.Size(86, 31);
            this.buttonSupprimerBoisson.TabIndex = 11;
            this.buttonSupprimerBoisson.Text = "Supprimer";
            // 
            // buttonEnregistrerModifications
            // 
            this.buttonEnregistrerModifications.Location = new System.Drawing.Point(549, 480);
            this.buttonEnregistrerModifications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEnregistrerModifications.Name = "buttonEnregistrerModifications";
            this.buttonEnregistrerModifications.Size = new System.Drawing.Size(86, 31);
            this.buttonEnregistrerModifications.TabIndex = 12;
            this.buttonEnregistrerModifications.Text = "Enregistrer";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(663, 480);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(86, 31);
            this.buttonAnnuler.TabIndex = 13;
            this.buttonAnnuler.Text = "Annuler";
            // 
            // FormModifierCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.labelCommandeId);
            this.Controls.Add(this.textBoxCommandeId);
            this.Controls.Add(this.labelClientId);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.labelDateCommande);
            this.Controls.Add(this.dateTimePickerDateCommande);
            this.Controls.Add(this.labelBoissonsCommandees);
            this.Controls.Add(this.dataGridViewBoissonsCommandees);
            this.Controls.Add(this.buttonModifierBoisson);
            this.Controls.Add(this.buttonSupprimerBoisson);
            this.Controls.Add(this.buttonEnregistrerModifications);
            this.Controls.Add(this.buttonAnnuler);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormModifierCommande";
            this.Text = "FormModifierCommande";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoissonsCommandees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}


