namespace GESCHANGE.Forms.Sub
{
    partial class frmSNew
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbxPieces = new System.Windows.Forms.ComboBox();
            this.dtOperation = new System.Windows.Forms.DateTimePicker();
            this.txtReff = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxVL = new System.Windows.Forms.ComboBox();
            this.lblInfoVL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numQuantite = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(446, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(282, 298);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 40);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "&Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbxPieces
            // 
            this.cmbxPieces.FormattingEnabled = true;
            this.cmbxPieces.Location = new System.Drawing.Point(198, 102);
            this.cmbxPieces.Name = "cmbxPieces";
            this.cmbxPieces.Size = new System.Drawing.Size(272, 31);
            this.cmbxPieces.TabIndex = 2;
            this.cmbxPieces.SelectedIndexChanged += new System.EventHandler(this.cmbxPieces_SelectedIndexChanged);
            // 
            // dtOperation
            // 
            this.dtOperation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOperation.Location = new System.Drawing.Point(198, 26);
            this.dtOperation.Name = "dtOperation";
            this.dtOperation.Size = new System.Drawing.Size(456, 27);
            this.dtOperation.TabIndex = 0;
            // 
            // txtReff
            // 
            this.txtReff.Location = new System.Drawing.Point(198, 64);
            this.txtReff.Name = "txtReff";
            this.txtReff.Size = new System.Drawing.Size(456, 27);
            this.txtReff.TabIndex = 1;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(198, 224);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(456, 41);
            this.txtNote.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Pièce";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Observation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Véhicule";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(489, 106);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(76, 23);
            this.lblQuantite.TabIndex = 42;
            this.lblQuantite.Text = "Quantité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Date d\'operation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Référence";
            // 
            // cmbxVL
            // 
            this.cmbxVL.FormattingEnabled = true;
            this.cmbxVL.Location = new System.Drawing.Point(198, 182);
            this.cmbxVL.Name = "cmbxVL";
            this.cmbxVL.Size = new System.Drawing.Size(226, 31);
            this.cmbxVL.TabIndex = 4;
            this.cmbxVL.SelectedIndexChanged += new System.EventHandler(this.cmbxVL_SelectedIndexChanged);
            this.cmbxVL.Leave += new System.EventHandler(this.cmbxVL_Leave);
            // 
            // lblInfoVL
            // 
            this.lblInfoVL.AutoSize = true;
            this.lblInfoVL.Location = new System.Drawing.Point(432, 186);
            this.lblInfoVL.Name = "lblInfoVL";
            this.lblInfoVL.Size = new System.Drawing.Size(28, 23);
            this.lblInfoVL.TabIndex = 56;
            this.lblInfoVL.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Quantité";
            // 
            // numQuantite
            // 
            this.numQuantite.Location = new System.Drawing.Point(198, 144);
            this.numQuantite.Name = "numQuantite";
            this.numQuantite.Size = new System.Drawing.Size(226, 27);
            this.numQuantite.TabIndex = 58;
            // 
            // frmSNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 365);
            this.Controls.Add(this.numQuantite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblInfoVL);
            this.Controls.Add(this.cmbxVL);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbxPieces);
            this.Controls.Add(this.dtOperation);
            this.Controls.Add(this.txtReff);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSNew";
            this.Activated += new System.EventHandler(this.frmSNew_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbxPieces;
        private System.Windows.Forms.DateTimePicker dtOperation;
        private System.Windows.Forms.TextBox txtReff;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxVL;
        private System.Windows.Forms.Label lblInfoVL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numQuantite;
    }
}