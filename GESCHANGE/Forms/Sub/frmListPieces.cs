using GESCHANGE.Db;
using GESCHANGE.Proc;
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
    public partial class frmListPieces : Form
    {
        #region Variables

        private GESSRMAEntities db = new GESSRMAEntities();
        public string id;

        #endregion Variables

        #region Codes

        public void getData()
        {
            dgvPieces.DataSource = db.Select_Pieces();
            lblLigne.Text = string.Format("Ligne {0}", dgvPieces.RowCount);
        }

        #endregion Codes

        public frmListPieces()
        {
            InitializeComponent();
        }

        private void frmListPieces_Load(object sender, EventArgs e)
        {
            getData();
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmPieces f = new frmPieces(this);
            f.Text = "Nouveau pièce";
            f.ShowDialog();
        }

        private void dgvPieces_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPieces.Rows[e.RowIndex];
                id = row.Cells["Column1"].Value.ToString();
                Pieces rs = db.Select_Pieces_By_ID(int.Parse(id)).FirstOrDefault();
                frmPieces f = new frmPieces(this, rs.pies_Nom, rs.pies_Refference, rs.pies_Quantite.ToString(), rs.pies_Note);
                f.Text = "Modifier des pièces";
                f.ShowDialog();
            }
        }

        private void frmListPieces_Activated(object sender, EventArgs e)
        {
            getData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult re = MessageBox.Show("Voulez-vous supprimer cette pièce", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    db.Delete_Pieces(int.Parse(id));
                    db.SaveChanges();
                    getData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPieces_Click(object sender, EventArgs e)
        {
            if (dgvPieces.SelectedCells[0].OwningRow.Index < 0)
                btnDelete.Enabled = false;
            else
            {
                try
                {
                    btnDelete.Enabled = true;
                    DataGridViewRow row = dgvPieces.CurrentRow;
                    id = row.Cells["Column1"].Value.ToString();
                }
                catch (Exception) { }
            }
        }
    }
}