using GESCHANGE.Db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GESCHANGE.Forms.Sub
{
    public partial class frmListEntrees : Form
    {
        #region Variables

        private GESSRMAEntities db = new GESSRMAEntities();
        public string id;
        private string mode = string.Empty;

        #endregion Variables

        #region Codes

        public void getData()
        {
            dgvEntrees.DataSource = db.Select_View_EP_Entrees();
            lblLigne.Text = string.Format("Ligne {0}", dgvEntrees.RowCount);
        }

        public void Search(string mode, string txt, DateTime dt1, DateTime dt2)
        {
            dgvEntrees.DataSource = db.Search_Entrees(mode, txt, dt1, dt2);
            lblLigne.Text = string.Format("Ligne {0}", dgvEntrees.RowCount);
        }

        #endregion Codes

        public frmListEntrees()
        {
            InitializeComponent();
        }

        private void frmListEntrees_Load(object sender, EventArgs e)
        {
            getData();
            btnDelete.Enabled = false;
            rdoFournisseur.Checked = true;
        }

        private void dgvEntrees_Click(object sender, EventArgs e)
        {
            if (dgvEntrees.SelectedCells[0].OwningRow.Index < 0)
                btnDelete.Enabled = false;
            else
            {
                try
                {
                    btnDelete.Enabled = true;
                    DataGridViewRow row = dgvEntrees.CurrentRow;
                    id = row.Cells["Column1"].Value.ToString();
                }
                catch (Exception) { }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult re = MessageBox.Show("Voulez-vous supprimer cette Opération", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    db.Delete_Entrees(int.Parse(id));
                    db.SaveChanges();
                    getData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmENew f = new frmENew(this);
            f.Text = "Nouvelle opération d'entrer";
            f.ShowDialog();
        }

        private void dgvEntrees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEntrees.Rows[e.RowIndex];
                id = row.Cells["Column1"].Value.ToString();
                Entrees rs = db.Select_Entrees_By_ID(int.Parse(id)).FirstOrDefault();
                frmENew f = new frmENew(this, (DateTime)rs.entr_Date, rs.entr_Fournisseur, rs.entr_Refference, (int)rs.entr_Quantite, rs.entr_Note, rs.Pieces.pies_Nom);
                f.Text = "Modifier une Opération d'entrer";
                f.ShowDialog();
            }
        }

        private void rdoPieces_CheckedChanged(object sender, EventArgs e)
        {
            mode = "Pieces";
            dtp1.Visible = false;
            dtp2.Visible = false;
            txtSearch.Visible = true;
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }

        private void rdoRefference_CheckedChanged(object sender, EventArgs e)
        {
            mode = "Refference";
            dtp1.Visible = false;
            dtp2.Visible = false;
            txtSearch.Visible = true;
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }

        private void rdoFournisseur_CheckedChanged(object sender, EventArgs e)
        {
            mode = "Fournisseur";
            dtp1.Visible = false;
            dtp2.Visible = false;
            txtSearch.Visible = true;
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }

        private void rdoDate_CheckedChanged(object sender, EventArgs e)
        {
            mode = "Date";
            dtp1.Visible = true;
            dtp2.Visible = true;
            txtSearch.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(mode, txtSearch.Text, dtp1.Value.Date, dtp2.Value.Date);
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            Search(mode, txtSearch.Text, dtp1.Value.Date, dtp2.Value.Date);
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            Search(mode, txtSearch.Text, dtp1.Value.Date, dtp2.Value.Date);
        }
    }
}