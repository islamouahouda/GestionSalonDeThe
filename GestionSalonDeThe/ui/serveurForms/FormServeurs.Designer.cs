namespace GestionSalonDeThe.ui
{
    partial class FormServeurs
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
            dataGridViewServeurs = new DataGridView();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServeurs).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewServeurs
            // 
            dataGridViewServeurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServeurs.Location = new Point(12, 12);
            dataGridViewServeurs.Name = "dataGridViewServeurs";
            dataGridViewServeurs.RowTemplate.Height = 25;
            dataGridViewServeurs.Size = new Size(776, 319);
            dataGridViewServeurs.TabIndex = 0;
            dataGridViewServeurs.CellClick += dataGridViewServeurs_CellClick;
            dataGridViewServeurs.SelectionChanged += dataGridViewServeurs_SelectionChanged_1;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(12, 337);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "btnAjouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click_1;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(93, 337);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 2;
            btnModifier.Text = "btnModifier ";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click_1;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(174, 337);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "btnSupprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click_1;
            // 
            // FormServeurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(dataGridViewServeurs);
            Name = "FormServeurs";
            Text = "FormServeurs";
            ((System.ComponentModel.ISupportInitialize)dataGridViewServeurs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewServeurs;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
    }
}