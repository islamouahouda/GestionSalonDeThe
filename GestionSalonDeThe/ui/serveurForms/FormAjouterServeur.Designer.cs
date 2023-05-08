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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomServeur = new System.Windows.Forms.TextBox();
            this.txtPrenomServeur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(264, 159);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(86, 31);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Confirmer";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(171, 159);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(86, 31);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "nom du serveur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "prénom du serveur";
            // 
            // txtNomServeur
            // 
            this.txtNomServeur.Location = new System.Drawing.Point(168, 40);
            this.txtNomServeur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomServeur.Name = "txtNomServeur";
            this.txtNomServeur.Size = new System.Drawing.Size(181, 27);
            this.txtNomServeur.TabIndex = 6;
            // 
            // txtPrenomServeur
            // 
            this.txtPrenomServeur.Location = new System.Drawing.Point(168, 79);
            this.txtPrenomServeur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrenomServeur.Name = "txtPrenomServeur";
            this.txtPrenomServeur.Size = new System.Drawing.Size(181, 27);
            this.txtPrenomServeur.TabIndex = 7;
            // 
            // FormAjouterServeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 216);
            this.Controls.Add(this.txtPrenomServeur);
            this.Controls.Add(this.txtNomServeur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAjouterServeur";
            this.Text = "FormAjouterServeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAjouter;
        private Button btnAnnuler;
        private Label label2;
        private Label label3;
        private TextBox txtNomServeur;
        private TextBox txtPrenomServeur;
    }
}