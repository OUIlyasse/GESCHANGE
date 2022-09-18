namespace GESCHANGE.Forms.Sub
{
    partial class frmBD_RD
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lnkChoose = new System.Windows.Forms.LinkLabel();
            this.pbProcess = new System.Windows.Forms.ProgressBar();
            this.lblPourc = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBakups = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBakups)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dossier de sauvegarde";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(204, 26);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(340, 27);
            this.txtFolder.TabIndex = 1;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(116, 154);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(199, 43);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "&Sauvegarder";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lnkChoose
            // 
            this.lnkChoose.AutoSize = true;
            this.lnkChoose.Location = new System.Drawing.Point(561, 28);
            this.lnkChoose.Name = "lnkChoose";
            this.lnkChoose.Size = new System.Drawing.Size(63, 23);
            this.lnkChoose.TabIndex = 3;
            this.lnkChoose.TabStop = true;
            this.lnkChoose.Text = "Choisir";
            this.lnkChoose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChoose_LinkClicked);
            // 
            // pbProcess
            // 
            this.pbProcess.Location = new System.Drawing.Point(40, 104);
            this.pbProcess.Name = "pbProcess";
            this.pbProcess.Size = new System.Drawing.Size(603, 23);
            this.pbProcess.TabIndex = 4;
            this.pbProcess.Visible = false;
            // 
            // lblPourc
            // 
            this.lblPourc.Location = new System.Drawing.Point(256, 77);
            this.lblPourc.Name = "lblPourc";
            this.lblPourc.Size = new System.Drawing.Size(171, 24);
            this.lblPourc.TabIndex = 5;
            this.lblPourc.Text = "--";
            this.lblPourc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPourc.Visible = false;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(367, 154);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(199, 43);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "&Restaurer";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBakups);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 221);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sauvegardes";
            // 
            // dgvBakups
            // 
            this.dgvBakups.AllowUserToAddRows = false;
            this.dgvBakups.AllowUserToDeleteRows = false;
            this.dgvBakups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBakups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBakups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvBakups.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBakups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBakups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBakups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvBakups.Location = new System.Drawing.Point(6, 26);
            this.dgvBakups.MultiSelect = false;
            this.dgvBakups.Name = "dgvBakups";
            this.dgvBakups.ReadOnly = true;
            this.dgvBakups.RowHeadersWidth = 24;
            this.dgvBakups.RowTemplate.Height = 24;
            this.dgvBakups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBakups.Size = new System.Drawing.Size(646, 189);
            this.dgvBakups.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date de creation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Taille";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // ofd
            // 
            this.ofd.RestoreDirectory = true;
            // 
            // frmBD_RD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 214);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.lblPourc);
            this.Controls.Add(this.pbProcess);
            this.Controls.Add(this.lnkChoose);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBD_RD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sauvegarder et restaurer la base de données";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBakups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.LinkLabel lnkChoose;
        private System.Windows.Forms.ProgressBar pbProcess;
        private System.Windows.Forms.Label lblPourc;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvBakups;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}