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
            labelCommandeId = new Label();
            textBoxCommandeId = new TextBox();
            labelClientId = new Label();
            textBoxClientId = new TextBox();
            labelClientName = new Label();
            textBoxClientName = new TextBox();
            labelDateCommande = new Label();
            dateTimePickerDateCommande = new DateTimePicker();
            labelBoissonsCommandees = new Label();
            dataGridViewBoissonsCommandees = new DataGridView();
            buttonModifierBoisson = new Button();
            buttonSupprimerBoisson = new Button();
            buttonEnregistrerModifications = new Button();
            buttonAnnuler = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBoissonsCommandees).BeginInit();
            SuspendLayout();
            // 
            // labelCommandeId
            // 
            labelCommandeId.Location = new Point(10, 20);
            labelCommandeId.Name = "labelCommandeId";
            labelCommandeId.Size = new Size(100, 23);
            labelCommandeId.TabIndex = 0;
            labelCommandeId.Text = "ID Commande :";
            // 
            // textBoxCommandeId
            // 
            textBoxCommandeId.Location = new Point(120, 20);
            textBoxCommandeId.Name = "textBoxCommandeId";
            textBoxCommandeId.ReadOnly = true;
            textBoxCommandeId.Size = new Size(100, 23);
            textBoxCommandeId.TabIndex = 1;
            // 
            // labelClientId
            // 
            labelClientId.Location = new Point(10, 60);
            labelClientId.Name = "labelClientId";
            labelClientId.Size = new Size(100, 23);
            labelClientId.TabIndex = 2;
            labelClientId.Text = "ID Client :";
            // 
            // textBoxClientId
            // 
            textBoxClientId.Location = new Point(120, 60);
            textBoxClientId.Name = "textBoxClientId";
            textBoxClientId.ReadOnly = true;
            textBoxClientId.Size = new Size(100, 23);
            textBoxClientId.TabIndex = 3;
            // 
            // labelClientName
            // 
            labelClientName.Location = new Point(10, 100);
            labelClientName.Name = "labelClientName";
            labelClientName.Size = new Size(100, 23);
            labelClientName.TabIndex = 4;
            labelClientName.Text = "Nom Client :";
            // 
            // textBoxClientName
            // 
            textBoxClientName.Location = new Point(120, 100);
            textBoxClientName.Name = "textBoxClientName";
            textBoxClientName.ReadOnly = true;
            textBoxClientName.Size = new Size(100, 23);
            textBoxClientName.TabIndex = 5;
            // 
            // labelDateCommande
            // 
            labelDateCommande.Location = new Point(10, 140);
            labelDateCommande.Name = "labelDateCommande";
            labelDateCommande.Size = new Size(100, 23);
            labelDateCommande.TabIndex = 6;
            labelDateCommande.Text = "Date Commande :";
            // 
            // dateTimePickerDateCommande
            // 
            dateTimePickerDateCommande.Location = new Point(120, 140);
            dateTimePickerDateCommande.Name = "dateTimePickerDateCommande";
            dateTimePickerDateCommande.Size = new Size(200, 23);
            dateTimePickerDateCommande.TabIndex = 7;
            // 
            // labelBoissonsCommandees
            // 
            labelBoissonsCommandees.Location = new Point(10, 180);
            labelBoissonsCommandees.Name = "labelBoissonsCommandees";
            labelBoissonsCommandees.Size = new Size(100, 23);
            labelBoissonsCommandees.TabIndex = 8;
            labelBoissonsCommandees.Text = "Boissons Commandées :";
            // 
            // dataGridViewBoissonsCommandees
            // 
            dataGridViewBoissonsCommandees.Location = new Point(10, 220);
            dataGridViewBoissonsCommandees.Name = "dataGridViewBoissonsCommandees";
            dataGridViewBoissonsCommandees.Size = new Size(450, 200);
            dataGridViewBoissonsCommandees.TabIndex = 9;
            // 
            // buttonModifierBoisson
            // 
            buttonModifierBoisson.Location = new Point(480, 220);
            buttonModifierBoisson.Name = "buttonModifierBoisson";
            buttonModifierBoisson.Size = new Size(75, 23);
            buttonModifierBoisson.TabIndex = 10;
            buttonModifierBoisson.Text = "Modifier";
            buttonModifierBoisson.Click += buttonModifierBoisson_Click;
            // 
            // buttonSupprimerBoisson
            // 
            buttonSupprimerBoisson.Location = new Point(480, 260);
            buttonSupprimerBoisson.Name = "buttonSupprimerBoisson";
            buttonSupprimerBoisson.Size = new Size(75, 23);
            buttonSupprimerBoisson.TabIndex = 11;
            buttonSupprimerBoisson.Text = "Supprimer";
            buttonSupprimerBoisson.Click += buttonSupprimerBoisson_Click;
            // 
            // buttonEnregistrerModifications
            // 
            buttonEnregistrerModifications.Location = new Point(480, 360);
            buttonEnregistrerModifications.Name = "buttonEnregistrerModifications";
            buttonEnregistrerModifications.Size = new Size(75, 23);
            buttonEnregistrerModifications.TabIndex = 12;
            buttonEnregistrerModifications.Text = "Enregistrer";
            buttonEnregistrerModifications.Click += buttonEnregistrerModifications_Click;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Location = new Point(580, 360);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(75, 23);
            buttonAnnuler.TabIndex = 13;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // FormModifierCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCommandeId);
            Controls.Add(textBoxCommandeId);
            Controls.Add(labelClientId);
            Controls.Add(textBoxClientId);
            Controls.Add(labelClientName);
            Controls.Add(textBoxClientName);
            Controls.Add(labelDateCommande);
            Controls.Add(dateTimePickerDateCommande);
            Controls.Add(labelBoissonsCommandees);
            Controls.Add(dataGridViewBoissonsCommandees);
            Controls.Add(buttonModifierBoisson);
            Controls.Add(buttonSupprimerBoisson);
            Controls.Add(buttonEnregistrerModifications);
            Controls.Add(buttonAnnuler);
            Name = "FormModifierCommande";
            Text = "FormModifierCommande";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBoissonsCommandees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}


