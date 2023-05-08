namespace GestionSalonDeThe.ui.boissonsForms
{
    partial class FormBoissons
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dataGridViewBoissons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoissons)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(199, 449);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(86, 31);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "btnSupprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(106, 449);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(86, 31);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "btnModifier ";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(14, 449);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(86, 31);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "btnAjouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // dataGridViewBoissons
            // 
            this.dataGridViewBoissons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoissons.Location = new System.Drawing.Point(14, 16);
            this.dataGridViewBoissons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBoissons.Name = "dataGridViewBoissons";
            this.dataGridViewBoissons.RowHeadersWidth = 51;
            this.dataGridViewBoissons.RowTemplate.Height = 25;
            this.dataGridViewBoissons.Size = new System.Drawing.Size(887, 425);
            this.dataGridViewBoissons.TabIndex = 4;
            // 
            // FormBoissons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 492);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dataGridViewBoissons);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBoissons";
            this.Text = "FormBoissons";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoissons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private DataGridView dataGridViewBoissons;
    }
}