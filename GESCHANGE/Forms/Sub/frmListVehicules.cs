using GESCHANGE.Db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GESCHANGE.Forms.Sub
{
    public partial class frmListVehicules : Form
    {
        #region Variables

        private GESSRMAEntities db = new GESSRMAEntities();
        public string idVL = string.Empty;
        private string mode = string.Empty;

        #endregion Variables

        #region Codes

        public void getData()
        {
            dgvVehicules.DataSource = db.Select_View_VL_Grade().ToList();
            lblLigne.Text = string.Format("Ligne {0}", dgvVehicules.RowCount);
        }

        public void Search(string mode, string txt)
        {
            dgvVehicules.DataSource = db.Search_Vehicules(mode, txt);
            lblLigne.Text = string.Format("Ligne {0}", dgvVehicules.RowCount);
        }

        #endregion Codes

        public frmListVehicules()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmVehicules f = new frmVehicules(this);
            f.Text = "Nouveau Véhicule";
            f.ShowDialog();
        }

        private void frmListVehicules_Load(object sender, EventArgs e)
        {
            getData();
            btnDelete.Enabled = false;
            rdoVL.Checked = true;
        }

        private void dgvVehicules_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVehicules.Rows[e.RowIndex];
                idVL = row.Cells["vlID"].Value.ToString();
                Vehicules rs = db.Select_Vehicules_By_ID(int.Parse(idVL)).FirstOrDefault();
                frmVehicules f = new frmVehicules(this, rs.vl_Matricule, rs.vl_Genre, rs.vl_Marque.ToString(), rs.cond_Nom, rs.cond_Prenom, int.Parse(rs.grd_ID.ToString()), rs.cond_Mle, rs.cond_Unite);
                f.Text = "Modifier la Véhicule";
                f.ShowDialog();
            }
        }

        private void dgvVehicules_Click(object sender, EventArgs e)
        {
            if (dgvVehicules.SelectedCells[0].OwningRow.Index < 0)
                btnDelete.Enabled = false;
            else
            {
                try
                {
                    btnDelete.Enabled = true;
                    DataGridViewRow row = dgvVehicules.CurrentRow;
                    idVL = row.Cells["vlID"].Value.ToString();
                }
                catch (Exception) { }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult re = MessageBox.Show("Voulez-vous supprimer cette Véhicule", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    db.Delete_Vehicules(int.Parse(idVL));
                    db.SaveChanges();
                    getData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(mode, txtSearch.Text);
        }

        private void rdoNomPrenom_CheckedChanged(object sender, EventArgs e)
        {
            mode = "Nom_Prenom";
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }

        private void rdoGrade_CheckedChanged(object sender, EventArgs e)
        {
            mode = "Grade";
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }

        private void rdoMleFA_CheckedChanged(object sender, EventArgs e)
        {
            mode = "MleFA";
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }

        private void rdoUnite_CheckedChanged(object sender, EventArgs e)
        {
            mode = "Unite";
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }

        private void rdoVL_CheckedChanged(object sender, EventArgs e)
        {
            mode = "VL";
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }
    }
}