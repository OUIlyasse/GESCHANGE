namespace GESCHANGE.Forms.Sub
{
    partial class frmListVehicules
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
            this.lblLigne = new System.Windows.Forms.Label();
            this.condMle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlMarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condUnite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlMle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVehicules = new System.Windows.Forms.DataGridView();
            this.vlID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicules)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLigne
            // 
            this.lblLigne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLigne.AutoSize = true;
            this.lblLigne.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLigne.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLigne.Location = new System.Drawing.Point(779, 17);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLigne.Size = new System.Drawing.Size(47, 14);
            this.lblLigne.TabIndex = 1;
            this.lblLigne.Text = "ligne";
            this.lblLigne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // condMle
            // 
            this.condMle.DataPropertyName = "cond_Mle";
            this.condMle.HeaderText = "Mle FA";
            this.condMle.MinimumWidth = 6;
            this.condMle.Name = "condMle";
            this.condMle.ReadOnly = true;
            // 
            // condGrade
            // 
            this.condGrade.DataPropertyName = "grd_Libelle";
            this.condGrade.HeaderText = "Grade";
            this.condGrade.MinimumWidth = 6;
            this.condGrade.Name = "condGrade";
            this.condGrade.ReadOnly = true;
            // 
            // condPrenom
            // 
            this.condPrenom.DataPropertyName = "cond_Prenom";
            this.condPrenom.HeaderText = "Prénom";
            this.condPrenom.MinimumWidth = 6;
            this.condPrenom.Name = "condPrenom";
            this.condPrenom.ReadOnly = true;
            // 
            // condNom
            // 
            this.condNom.DataPropertyName = "cond_Nom";
            this.condNom.HeaderText = "Nom";
            this.condNom.MinimumWidth = 6;
            this.condNom.Name = "condNom";
            this.condNom.ReadOnly = true;
            // 
            // vlMarque
            // 
            this.vlMarque.DataPropertyName = "vl_Marque";
            this.vlMarque.HeaderText = "Marque";
            this.vlMarque.MinimumWidth = 6;
            this.vlMarque.Name = "vlMarque";
            this.vlMarque.ReadOnly = true;
            // 
            // vlGenre
            // 
            this.vlGenre.DataPropertyName = "vl_Genre";
            this.vlGenre.HeaderText = "Genre";
            this.vlGenre.MinimumWidth = 6;
            this.vlGenre.Name = "vlGenre";
            this.vlGenre.ReadOnly = true;
            // 
            // condUnite
            // 
            this.condUnite.DataPropertyName = "cond_Unite";
            this.condUnite.HeaderText = "Unite";
            this.condUnite.MinimumWidth = 6;
            this.condUnite.Name = "condUnite";
            this.condUnite.ReadOnly = true;
            // 
            // vlMle
            // 
            this.vlMle.DataPropertyName = "vl_Matricule";
            this.vlMle.HeaderText = "Matricule";
            this.vlMle.MinimumWidth = 6;
            this.vlMle.Name = "vlMle";
            this.vlMle.ReadOnly = true;
            // 
            // dgvVehicules
            // 
            this.dgvVehicules.AllowUserToAddRows = false;
            this.dgvVehicules.AllowUserToDeleteRows = false;
            this.dgvVehicules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVehicules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicules.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvVehicules.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVehicules.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVehicules.ColumnHeadersHeight = 30;
            this.dgvVehicules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vlID,
            this.vlMle,
            this.vlGenre,
            this.vlMarque,
            this.condNom,
            this.condPrenom,
            this.condGrade,
            this.condMle,
            this.condUnite});
            this.dgvVehicules.Location = new System.Drawing.Point(6, 37);
            this.dgvVehicules.MultiSelect = false;
            this.dgvVehicules.Name = "dgvVehicules";
            this.dgvVehicules.ReadOnly = true;
            this.dgvVehicules.RowHeadersWidth = 24;
            this.dgvVehicules.RowTemplate.Height = 24;
            this.dgvVehicules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicules.Size = new System.Drawing.Size(828, 324);
            this.dgvVehicules.TabIndex = 2;
            this.dgvVehicules.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicules_CellDoubleClick);
            this.dgvVehicules.Click += new System.EventHandler(this.dgvVehicules_Click);
            // 
            // vlID
            // 
            this.vlID.DataPropertyName = "vl_ID";
            this.vlID.HeaderText = "vlID";
            this.vlID.MinimumWidth = 6;
            this.vlID.Name = "vlID";
            this.vlID.ReadOnly = true;
            this.vlID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvVehicules);
            this.groupBox2.Controls.Add(this.lblLigne);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 367);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affichage";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::GESCHANGE.Properties.Resources.icons8_supprimer_le_fichier_36;
            this.btnDelete.Location = new System.Drawing.Point(733, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.AutoSize = true;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::GESCHANGE.Properties.Resources.icons8_nouveau_fichier_36;
            this.btnNew.Location = new System.Drawing.Point(784, 14);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(45, 42);
            this.btnNew.TabIndex = 2;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(110, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(303, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // frmListVehicules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(882, 525);
            this.Name = "frmListVehicules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des vehicules";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListVehicules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicules)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn condMle;
        private System.Windows.Forms.DataGridViewTextBoxColumn condGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn condPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn condNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlMarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn condUnite;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlMle;
        public System.Windows.Forms.DataGridView dgvVehicules;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblLigne;
    }
}