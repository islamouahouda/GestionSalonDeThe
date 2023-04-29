namespace GestionSalonDeThe.ui.serveurForms
{
    partial class FormAjouterServeur
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
            btnAjouter = new Button();
            btnAnnuler = new Button();
            label1 = new Label();
            txtIdServeur = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNomServeur = new TextBox();
            txtPrenomServeur = new TextBox();
            SuspendLayout();
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(364, 165);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 0;
            btnAjouter.Text = "Confirmer";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(283, 165);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 23);
            btnAnnuler.TabIndex = 1;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 52);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = " ID du serveur";
            // 
            // txtIdServeur
            // 
            txtIdServeur.Location = new Point(145, 49);
            txtIdServeur.Name = "txtIdServeur";
            txtIdServeur.Size = new Size(162, 23);
            txtIdServeur.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 82);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "nom du serveur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 112);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 4;
            label3.Text = "prénom du serveur";
            // 
            // txtNomServeur
            // 
            txtNomServeur.Location = new Point(148, 78);
            txtNomServeur.Name = "txtNomServeur";
            txtNomServeur.Size = new Size(159, 23);
            txtNomServeur.TabIndex = 6;
            // 
            // txtPrenomServeur
            // 
            txtPrenomServeur.Location = new Point(148, 107);
            txtPrenomServeur.Name = "txtPrenomServeur";
            txtPrenomServeur.Size = new Size(159, 23);
            txtPrenomServeur.TabIndex = 7;
            // 
            // FormAjouterServeur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 215);
            Controls.Add(txtPrenomServeur);
            Controls.Add(txtNomServeur);
            Controls.Add(txtIdServeur);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAnnuler);
            Controls.Add(btnAjouter);
            Name = "FormAjouterServeur";
            Text = "FormAjouterServeur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAjouter;
        private Button btnAnnuler;
        private Label label1;
        private TextBox txtIdServeur;
        private Label label2;
        private Label label3;
        private TextBox txtNomServeur;
        private TextBox txtPrenomServeur;
    }
}