namespace GestionSalonDeThe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            serveursToolStripMenuItem = new ToolStripMenuItem();
            gestionnaireDesServerusToolStripMenuItem = new ToolStripMenuItem();
            boissonsToolStripMenuItem = new ToolStripMenuItem();
            gestionnaireDesBoissonsToolStripMenuItem = new ToolStripMenuItem();
            commandesToolStripMenuItem = new ToolStripMenuItem();
            gestionnaireDeCommandesToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(475, 517);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Debug";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 517);
            button2.Name = "button2";
            button2.Size = new Size(265, 23);
            button2.TabIndex = 1;
            button2.Text = "Gestionnaire de Serveurs";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { serveursToolStripMenuItem, boissonsToolStripMenuItem, commandesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(562, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // serveursToolStripMenuItem
            // 
            serveursToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionnaireDesServerusToolStripMenuItem });
            serveursToolStripMenuItem.Name = "serveursToolStripMenuItem";
            serveursToolStripMenuItem.Size = new Size(63, 20);
            serveursToolStripMenuItem.Text = "Serveurs";
            // 
            // gestionnaireDesServerusToolStripMenuItem
            // 
            gestionnaireDesServerusToolStripMenuItem.Name = "gestionnaireDesServerusToolStripMenuItem";
            gestionnaireDesServerusToolStripMenuItem.Size = new Size(208, 22);
            gestionnaireDesServerusToolStripMenuItem.Text = "Gestionnaire des Serveurs";
            gestionnaireDesServerusToolStripMenuItem.Click += gestionnaireDesServerusToolStripMenuItem_Click;
            // 
            // boissonsToolStripMenuItem
            // 
            boissonsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionnaireDesBoissonsToolStripMenuItem });
            boissonsToolStripMenuItem.Name = "boissonsToolStripMenuItem";
            boissonsToolStripMenuItem.Size = new Size(65, 20);
            boissonsToolStripMenuItem.Text = "Boissons";
            // 
            // gestionnaireDesBoissonsToolStripMenuItem
            // 
            gestionnaireDesBoissonsToolStripMenuItem.Name = "gestionnaireDesBoissonsToolStripMenuItem";
            gestionnaireDesBoissonsToolStripMenuItem.Size = new Size(210, 22);
            gestionnaireDesBoissonsToolStripMenuItem.Text = "Gestionnaire des boissons";
            gestionnaireDesBoissonsToolStripMenuItem.Click += gestionnaireDesBoissonsToolStripMenuItem_Click;
            // 
            // commandesToolStripMenuItem
            // 
            commandesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionnaireDeCommandesToolStripMenuItem });
            commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            commandesToolStripMenuItem.Size = new Size(87, 20);
            commandesToolStripMenuItem.Text = "Commandes";
            // 
            // gestionnaireDeCommandesToolStripMenuItem
            // 
            gestionnaireDeCommandesToolStripMenuItem.Name = "gestionnaireDeCommandesToolStripMenuItem";
            gestionnaireDeCommandesToolStripMenuItem.Size = new Size(227, 22);
            gestionnaireDeCommandesToolStripMenuItem.Text = "Gestionnaire de Commandes";
            gestionnaireDeCommandesToolStripMenuItem.Click += gestionnaireDeCommandesToolStripMenuItem_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 488);
            button3.Name = "button3";
            button3.Size = new Size(265, 23);
            button3.TabIndex = 3;
            button3.Text = "Gestionnaire de Boissons";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 459);
            button4.Name = "button4";
            button4.Size = new Size(265, 23);
            button4.TabIndex = 4;
            button4.Text = "Gestionnaire de Commandes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 430);
            button5.Name = "button5";
            button5.Size = new Size(265, 23);
            button5.TabIndex = 5;
            button5.Text = "Form Reporting";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 552);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem serveursToolStripMenuItem;
        private ToolStripMenuItem gestionnaireDesServerusToolStripMenuItem;
        private ToolStripMenuItem boissonsToolStripMenuItem;
        private ToolStripMenuItem gestionnaireDesBoissonsToolStripMenuItem;
        private Button button3;
        private ToolStripMenuItem commandesToolStripMenuItem;
        private ToolStripMenuItem gestionnaireDeCommandesToolStripMenuItem;
        private Button button4;
        private Button button5;
    }
}