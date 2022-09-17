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
    public partial class frmListEntrees : Form
    {
        #region Variables

        private GESSRMAEntities db = new GESSRMAEntities();
        public string id;

        #endregion Variables

        #region Codes

        public void getData()
        {
            dgvEntrees.DataSource = db.Select_View_EP_Entrees();
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
    }
}