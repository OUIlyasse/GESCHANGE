using GESCHANGE.Db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GESCHANGE.Forms.Sub
{
    public partial class frmListSorties : Form
    {
        #region Variables

        private GESSRMAEntities db = new GESSRMAEntities();
        public string id;
        private string mode = string.Empty;

        #endregion Variables

        #region Codes

        public void getData()
        {
            dgvSorties.DataSource = db.Select_View_SP_Sorties();
            lblLigne.Text = string.Format("Ligne {0}", dgvSorties.RowCount);
        }

        public void Search(string mode, string txt, DateTime dt1, DateTime dt2)
        {
            dgvSorties.DataSource = db.Search_Sorties(mode, txt, dt1, dt2);
            lblLigne.Text = string.Format("Ligne {0}", dgvSorties.RowCount);
        }

        #endregion Codes

        public frmListSorties()
        {
            InitializeComponent();
        }

        private void frmListSorties_Load(object sender, EventArgs e)
        {
            getData();
            btnDelete.Enabled = false;
            rdoVL.Checked = true;
        }

        private void dgvSorties_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSorties.Rows[e.RowIndex];
                id = row.Cells["Column1"].Value.ToString();
                Sorties rs = db.Select_Sorties_By_ID(int.Parse(id)).FirstOrDefault();
                frmSNew f = new frmSNew(this, (DateTime)rs.srt_Date, rs.srt_Refference, int.Parse(rs.srt_Quantite.ToString()), rs.srt_Note, int.Parse(rs.vl_ID.ToString()), int.Parse(rs.pies_ID.ToString()));
                f.Text = "Modifier une Opération de sortie";
                f.ShowDialog();
            }
        }

        private void dgvSorties_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSorties.SelectedCells[0].OwningRow.Index < 0)
                    btnDelete.Enabled = false;
                else
                {
                    btnDelete.Enabled = true;
                    DataGridViewRow row = dgvSorties.CurrentRow;
                    id = row.Cells["Column1"].Value.ToString();
                }
            }
            catch (Exception) { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult re = MessageBox.Show("Voulez-vous supprimer cette Opération", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    db.Delete_Sorties(int.Parse(id));
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
            frmSNew f = new frmSNew(this);
            f.Text = "Nouvelle opération de sortie";
            f.ShowDialog();
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

        private void rdoPieces_CheckedChanged(object sender, EventArgs e)
        {
            mode = "Pieces";
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

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            Search(mode, txtSearch.Text, dtp1.Value.Date, dtp2.Value.Date);
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            Search(mode, txtSearch.Text, dtp1.Value.Date, dtp2.Value.Date);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(mode, txtSearch.Text, dtp1.Value.Date, dtp2.Value.Date);
        }

        private void rdoVL_CheckedChanged(object sender, EventArgs e)
        {
            mode = "VL";
            dtp1.Visible = false;
            dtp2.Visible = false;
            txtSearch.Visible = true;
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }
    }
}