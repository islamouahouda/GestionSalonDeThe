namespace GestionSalonDeThe.ui.boissonsForms
{
    partial class FormModifierBoisson
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
            txtQteStock = new TextBox();
            txtPrix = new TextBox();
            txtNom = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAnnuler = new Button();
            btnAjouter = new Button();
            SuspendLayout();
            // 
            // txtQteStock
            // 
            txtQteStock.Location = new Point(151, 90);
            txtQteStock.Name = "txtQteStock";
            txtQteStock.Size = new Size(161, 23);
            txtQteStock.TabIndex = 17;
            // 
            // txtPrix
            // 
            txtPrix.Location = new Point(85, 61);
            txtPrix.Name = "txtPrix";
            txtPrix.Size = new Size(227, 23);
            txtPrix.TabIndex = 16;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(85, 35);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(227, 23);
            txtNom.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 93);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 14;
            label3.Text = "Quantité en stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 69);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 13;
            label2.Text = "Prix";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 38);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 12;
            label1.Text = "Nom";
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(299, 153);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 23);
            btnAnnuler.TabIndex = 11;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(380, 153);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 10;
            btnAjouter.Text = "Confirmer";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // FormModifierBoisson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 200);
            Controls.Add(txtQteStock);
            Controls.Add(txtPrix);
            Controls.Add(txtNom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAnnuler);
            Controls.Add(btnAjouter);
            Name = "FormModifierBoisson";
            Text = "FormModifierBoisson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQteStock;
        private TextBox txtPrix;
        private TextBox txtNom;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAnnuler;
        private Button btnAjouter;
    }
}