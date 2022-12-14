namespace GESCHANGE.Forms.Sub
{
    partial class frmListEntrees
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLigne = new System.Windows.Forms.Label();
            this.dgvEntrees = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piesNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.rdoPieces = new System.Windows.Forms.RadioButton();
            this.rdoRefference = new System.Windows.Forms.RadioButton();
            this.rdoFournisseur = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblLigne);
            this.groupBox2.Controls.Add(this.dgvEntrees);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 365);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affichage";
            // 
            // lblLigne
            // 
            this.lblLigne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLigne.AutoSize = true;
            this.lblLigne.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLigne.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLigne.Location = new System.Drawing.Point(787, 23);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLigne.Size = new System.Drawing.Size(47, 14);
            this.lblLigne.TabIndex = 7;
            this.lblLigne.Text = "ligne";
            this.lblLigne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvEntrees
            // 
            this.dgvEntrees.AllowUserToAddRows = false;
            this.dgvEntrees.AllowUserToDeleteRows = false;
            this.dgvEntrees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntrees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntrees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvEntrees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEntrees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEntrees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nom,
            this.Refference,
            this.Quantite,
            this.Note,
            this.piesNom});
            this.dgvEntrees.Location = new System.Drawing.Point(6, 43);
            this.dgvEntrees.MultiSelect = false;
            this.dgvEntrees.Name = "dgvEntrees";
            this.dgvEntrees.ReadOnly = true;
            this.dgvEntrees.RowHeadersWidth = 24;
            this.dgvEntrees.RowTemplate.Height = 24;
            this.dgvEntrees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrees.Size = new System.Drawing.Size(828, 316);
            this.dgvEntrees.TabIndex = 6;
            this.dgvEntrees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntrees_CellDoubleClick);
            this.dgvEntrees.Click += new System.EventHandler(this.dgvEntrees_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "entr_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "entr_Fournisseur";
            this.Nom.HeaderText = "Fournisseur";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Refference
            // 
            this.Refference.DataPropertyName = "entr_Date";
            this.Refference.HeaderText = "Date";
            this.Refference.Name = "Refference";
            this.Refference.ReadOnly = true;
            // 
            // Quantite
            // 
            this.Quantite.DataPropertyName = "entr_Refference";
            this.Quantite.HeaderText = "Refference";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "entr_Quantite";
            this.Note.HeaderText = "Quantite";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // piesNom
            // 
            this.piesNom.DataPropertyName = "pies_Nom";
            this.piesNom.HeaderText = "Pièce";
            this.piesNom.Name = "piesNom";
            this.piesNom.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.rdoDate);
            this.groupBox1.Controls.Add(this.rdoPieces);
            this.groupBox1.Controls.Add(this.rdoRefference);
            this.groupBox1.Controls.Add(this.rdoFournisseur);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Location = new System.Drawing.Point(654, 24);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(66, 27);
            this.rdoDate.TabIndex = 7;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "Date";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.rdoDate_CheckedChanged);
            // 
            // rdoPieces
            // 
            this.rdoPieces.AutoSize = true;
            this.rdoPieces.Location = new System.Drawing.Point(578, 24);
            this.rdoPieces.Name = "rdoPieces";
            this.rdoPieces.Size = new System.Drawing.Size(70, 27);
            this.rdoPieces.TabIndex = 6;
            this.rdoPieces.TabStop = true;
            this.rdoPieces.Text = "Pièce";
            this.rdoPieces.UseVisualStyleBackColor = true;
            this.rdoPieces.CheckedChanged += new System.EventHandler(this.rdoPieces_CheckedChanged);
            // 
            // rdoRefference
            // 
            this.rdoRefference.AutoSize = true;
            this.rdoRefference.Location = new System.Drawing.Point(505, 24);
            this.rdoRefference.Name = "rdoRefference";
            this.rdoRefference.Size = new System.Drawing.Size(67, 27);
            this.rdoRefference.TabIndex = 5;
            this.rdoRefference.TabStop = true;
            this.rdoRefference.Text = "Reff.";
            this.rdoRefference.UseVisualStyleBackColor = true;
            this.rdoRefference.CheckedChanged += new System.EventHandler(this.rdoRefference_CheckedChanged);
            // 
            // rdoFournisseur
            // 
            this.rdoFournisseur.AutoSize = true;
            this.rdoFournisseur.Location = new System.Drawing.Point(419, 24);
            this.rdoFournisseur.Name = "rdoFournisseur";
            this.rdoFournisseur.Size = new System.Drawing.Size(80, 27);
            this.rdoFournisseur.TabIndex = 4;
            this.rdoFournisseur.TabStop = true;
            this.rdoFournisseur.Text = "Fourn.";
            this.rdoFournisseur.UseVisualStyleBackColor = true;
            this.rdoFournisseur.CheckedChanged += new System.EventHandler(this.rdoFournisseur_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::GESCHANGE.Properties.Resources.icons8_supprimer_le_fichier_36;
            this.btnDelete.Location = new System.Drawing.Point(733, 16);
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
            this.btnNew.Location = new System.Drawing.Point(784, 16);
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
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche";
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(110, 22);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(126, 27);
            this.dtp1.TabIndex = 6;
            this.dtp1.Visible = false;
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // dtp2
            // 
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp2.Location = new System.Drawing.Point(283, 23);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(126, 27);
            this.dtp2.TabIndex = 8;
            this.dtp2.Visible = false;
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // frmListEntrees
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
            this.Name = "frmListEntrees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des entrées";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListEntrees_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvEntrees;
        public System.Windows.Forms.Label lblLigne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Refference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn piesNom;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoPieces;
        private System.Windows.Forms.RadioButton rdoRefference;
        private System.Windows.Forms.RadioButton rdoFournisseur;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
    }
}