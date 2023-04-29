namespace GestionSalonDeThe.ui.serveurForms
{
    partial class FormModifierServeur
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
            txtPrenomServeur = new TextBox();
            txtNomServeur = new TextBox();
            txtIdServeur = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAnnuler = new Button();
            btnAjouter = new Button();
            SuspendLayout();
            // 
            // txtPrenomServeur
            // 
            txtPrenomServeur.Location = new Point(137, 89);
            txtPrenomServeur.Name = "txtPrenomServeur";
            txtPrenomServeur.Size = new Size(159, 23);
            txtPrenomServeur.TabIndex = 15;
            // 
            // txtNomServeur
            // 
            txtNomServeur.Location = new Point(137, 60);
            txtNomServeur.Name = "txtNomServeur";
            txtNomServeur.Size = new Size(159, 23);
            txtNomServeur.TabIndex = 14;
            // 
            // txtIdServeur
            // 
            txtIdServeur.Enabled = false;
            txtIdServeur.Location = new Point(134, 31);
            txtIdServeur.Name = "txtIdServeur";
            txtIdServeur.Size = new Size(162, 23);
            txtIdServeur.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 94);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 12;
            label3.Text = "prénom du serveur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 64);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 11;
            label2.Text = "nom du serveur";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 34);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 10;
            label1.Text = " ID du serveur";
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(621, 397);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 23);
            btnAnnuler.TabIndex = 9;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(702, 397);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "Confirmer";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // FormModifierServeur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrenomServeur);
            Controls.Add(txtNomServeur);
            Controls.Add(txtIdServeur);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAnnuler);
            Controls.Add(btnAjouter);
            Name = "FormModifierServeur";
            Text = "FormModifierServeur";
            Load += FormModifierServeur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrenomServeur;
        private TextBox txtNomServeur;
        private TextBox txtIdServeur;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAnnuler;
        private Button btnAjouter;
    }
}