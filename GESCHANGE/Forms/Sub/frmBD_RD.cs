using GESCHANGE.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESCHANGE.Forms.Sub
{
    public partial class frmBD_RD : Form
    {
        #region Variables

        private masterEntities db = new masterEntities();
        private GESSRMAEntities d = new GESSRMAEntities();

        #endregion Variables

        #region Codes

        private bool Backup(string path)
        {
            try
            {
                d.Backup_Database(path);
                d.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ereur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Restore(string path)
        {
            try
            {
                db.Restore_Database(path);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ereur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion Codes

        public frmBD_RD()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFolder.Text))
            {
                string pt = string.Format(@"{0}\{1}_{2}.bak", txtFolder.Text, "sauv", DateTime.Now.ToString("ddMMyyyy_HHmmss"));
                if (Backup(pt))
                    MessageBox.Show("Sauvegarde de base de données effectuée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sauvegarde de base de données effectuée avec erreur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Veuillez saisir l’emplacement du fichier de sauvegarde", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lnkChoose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = fbd.SelectedPath;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string rs = string.Empty;
            btnRestore.Enabled = false;
            var f = ofd;
            f.Filter = "Fichier de sauvegarde SQL server|*.bak";
            f.FileName = string.Empty;
            f.ShowDialog();

            if (f.ShowDialog() == DialogResult.OK)
                rs = f.FileName;

            if (Restore(rs))
                MessageBox.Show("Restauration de base de données effectuée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Restauration de base de données effectuée avec erreur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            btnRestore.Enabled = true;
        }
    }
}