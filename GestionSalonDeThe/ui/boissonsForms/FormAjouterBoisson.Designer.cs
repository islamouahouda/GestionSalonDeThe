namespace GestionSalonDeThe.ui.boissonsForms
{
    partial class FormAjouterBoisson
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
            btnAnnuler = new Button();
            btnAjouter = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNom = new TextBox();
            txtPrix = new TextBox();
            txtQteStock = new TextBox();
            SuspendLayout();
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(128, 137);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 23);
            btnAnnuler.TabIndex = 3;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(209, 137);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Confirmer";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 4;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 5;
            label2.Text = "Prix";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 6;
            label3.Text = "Quantité en stock";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(52, 19);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(227, 23);
            txtNom.TabIndex = 7;
            // 
            // txtPrix
            // 
            txtPrix.Location = new Point(52, 45);
            txtPrix.Name = "txtPrix";
            txtPrix.Size = new Size(227, 23);
            txtPrix.TabIndex = 8;
            // 
            // txtQteStock
            // 
            txtQteStock.Location = new Point(118, 74);
            txtQteStock.Name = "txtQteStock";
            txtQteStock.Size = new Size(161, 23);
            txtQteStock.TabIndex = 9;
            // 
            // FormAjouterBoisson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 193);
            Controls.Add(txtQteStock);
            Controls.Add(txtPrix);
            Controls.Add(txtNom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAnnuler);
            Controls.Add(btnAjouter);
            Name = "FormAjouterBoisson";
            Text = "FormAjouterBoisson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnnuler;
        private Button btnAjouter;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNom;
        private TextBox txtPrix;
        private TextBox txtQteStock;
    }
}