﻿namespace GestionSalonDeThe.ui.commandesForms
{
    partial class FormCommandes
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
            dataGridViewCommandes = new DataGridView();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommandes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCommandes
            // 
            dataGridViewCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCommandes.Location = new Point(12, 12);
            dataGridViewCommandes.Name = "dataGridViewCommandes";
            dataGridViewCommandes.RowTemplate.Height = 25;
            dataGridViewCommandes.Size = new Size(776, 319);
            dataGridViewCommandes.TabIndex = 5;
            dataGridViewCommandes.SelectionChanged += dataGridViewBoissons_SelectionChanged;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(174, 337);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 10;
            btnSupprimer.Text = "btnSupprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(93, 337);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 9;
            btnModifier.Text = "btnModifier ";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(12, 337);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "btnAjouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // FormCommandes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 372);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(dataGridViewCommandes);
            Name = "FormCommandes";
            Text = "FormCommandes";
            Load += FormCommandes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommandes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCommandes;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
    }
}