namespace GESCHANGE.Forms.Main
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPieces = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVehicules = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEntree = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSorties = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSB_RB = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.paramètresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPieces,
            this.menuVehicules,
            this.menuEntree,
            this.menuSorties});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // menuPieces
            // 
            this.menuPieces.Name = "menuPieces";
            this.menuPieces.Size = new System.Drawing.Size(145, 26);
            this.menuPieces.Text = "&Pièces";
            this.menuPieces.Click += new System.EventHandler(this.menuPieces_Click);
            // 
            // menuVehicules
            // 
            this.menuVehicules.Name = "menuVehicules";
            this.menuVehicules.Size = new System.Drawing.Size(145, 26);
            this.menuVehicules.Text = "&Véhicules";
            this.menuVehicules.Click += new System.EventHandler(this.menuVehicules_Click);
            // 
            // menuEntree
            // 
            this.menuEntree.Name = "menuEntree";
            this.menuEntree.Size = new System.Drawing.Size(145, 26);
            this.menuEntree.Text = "&Entrées";
            this.menuEntree.Click += new System.EventHandler(this.menuEntree_Click);
            // 
            // menuSorties
            // 
            this.menuSorties.Name = "menuSorties";
            this.menuSorties.Size = new System.Drawing.Size(145, 26);
            this.menuSorties.Text = "&Sorties";
            this.menuSorties.Click += new System.EventHandler(this.menuSorties_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSB_RB});
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // menuSB_RB
            // 
            this.menuSB_RB.Name = "menuSB_RB";
            this.menuSB_RB.Size = new System.Drawing.Size(245, 26);
            this.menuSB_RB.Text = "&Sauvegarde et &Restaurer";
            this.menuSB_RB.Click += new System.EventHandler(this.menuSB_RB_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 28);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(882, 525);
            this.pnlMenu.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRMA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPieces;
        private System.Windows.Forms.ToolStripMenuItem menuVehicules;
        private System.Windows.Forms.ToolStripMenuItem menuEntree;
        private System.Windows.Forms.ToolStripMenuItem menuSorties;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSB_RB;
        private System.Windows.Forms.Panel pnlMenu;
    }
}