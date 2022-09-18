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
using static Tools.iTools;

namespace GESCHANGE.Forms.Sub
{
    public partial class frmSNew : Form
    {
        #region Variables

        private GESSRMAEntities db = new GESSRMAEntities();
        private frmListSorties fls;

        #endregion Variables

        #region Codes

        public void Clear()
        {
            dtOperation.Value = DateTime.Now;
            txtReff.Text = string.Empty;
            cmbxPieces.Text = string.Empty;
            txtQuantite.Text = string.Empty;
            cmbxVL.Text = string.Empty;
            lblInfoVL.Text = string.Empty;
            txtNote.Text = string.Empty;
        }

        public void VerifyButtons()
        {
            if (Text == "Nouvelle opération de sortie")
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private bool Add()
        {
            try
            {
                int? maxId = db.MaxID_Sorties().SingleOrDefault();
                string message;
                var isVerify = VerifyText(out message, txtReff, txtReff, txtQuantite);
                if (isVerify && string.IsNullOrEmpty(dtOperation.Text) && string.IsNullOrEmpty(cmbxPieces.Text) && string.IsNullOrEmpty(cmbxVL.Text))
                {
                    MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    db.Insert_Sorties(maxId, dtOperation.Value, txtReff.Text.Trim().ToUpper(), int.Parse(txtQuantite.Text), txtNote.Text.Trim(), int.Parse(cmbxVL.SelectedValue.ToString()), int.Parse(cmbxPieces.SelectedValue.ToString()));
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void LoadData()
        {
            fls.dgvSorties.DataSource = db.Select_View_SP_Sorties();
            fls.lblLigne.Text = string.Format("Ligne {0}", fls.dgvSorties.RowCount);
        }

        public void LoadPieces()
        {
            cmbxPieces.DataSource = db.Select_Pieces();
            cmbxPieces.ValueMember = "pies_ID";
            cmbxPieces.DisplayMember = "pies_Nom";
            cmbxPieces.SelectedIndex = -1;
        }

        public void LoadVL()
        {
            cmbxVL.DataSource = db.Select_Vehicules();
            cmbxVL.ValueMember = "vl_ID";
            cmbxVL.DisplayMember = "vl_Matricule";
            cmbxVL.SelectedIndex = -1;
        }

        public bool Modify()
        {
            try
            {
                string message;
                var isVerify = VerifyText(out message, txtReff, txtReff, txtQuantite);
                if (isVerify && string.IsNullOrEmpty(dtOperation.Text) && string.IsNullOrEmpty(cmbxPieces.Text) && string.IsNullOrEmpty(cmbxVL.Text))
                {
                    MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    db.Update_Sorties(int.Parse(fls.id.ToString()), dtOperation.Value, txtReff.Text.Trim().ToUpper(), int.Parse(txtQuantite.Text), txtNote.Text.Trim(), int.Parse(cmbxVL.SelectedValue.ToString()), int.Parse(cmbxPieces.SelectedValue.ToString()));
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                db.Delete_Sorties(int.Parse(fls.id));
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void getInfoVL()
        {
            try
            {
                Vehicules rs = db.Select_Vehicules_By_MleVL(cmbxVL.Text).FirstOrDefault();
                if (rs != null && cmbxVL.Text != string.Empty)
                    lblInfoVL.Text = string.Format("Genre: {0}   Marque: {1}", rs.vl_Genre, rs.vl_Marque);
                else
                    lblInfoVL.Text = string.Empty;
            }
            catch (Exception) { }
        }

        #endregion Codes

        public frmSNew(frmListSorties f)
        {
            InitializeComponent();
            fls = f;
            VerifyButtons();
        }

        public frmSNew(frmListSorties f, DateTime date, string reff, int que, string note, int vl, int ps)
        {
            InitializeComponent();
            fls = f;
            dtOperation.Value = date;
            txtReff.Text = reff;
            cmbxPieces.SelectedValue = ps;
            txtQuantite.Text = que.ToString();
            cmbxVL.SelectedValue = vl;
            txtNote.Text = string.Empty;
            VerifyButtons();
        }

        private void frmSNew_Activated(object sender, EventArgs e)
        {
            LoadPieces();
            LoadVL();
            VerifyButtons();
        }

        private void cmbxVL_SelectedIndexChanged(object sender, EventArgs e)
        {
            getInfoVL();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Modify())
            {
                MessageBox.Show("Cette Opération est bien modifiée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                dtOperation.Focus();
                LoadData();
                Text = "Nouvelle opération de sortie";
                VerifyButtons();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Add())
            {
                MessageBox.Show("Votre Opération est bien enregistrée", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                dtOperation.Focus();
                LoadData();
                Text = "Nouvelle opération de sortie";
                VerifyButtons();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult re = MessageBox.Show("Voulez-vous supprimer cette Opération", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    if (Delete())
                    {
                        MessageBox.Show("Cette Opération est bien supprimée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtOperation.Focus();
                        LoadData();
                        Clear();
                        Text = "Nouvelle opération de sortie";
                        VerifyButtons();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void cmbxVL_Leave(object sender, EventArgs e)
        {
        }
    }
}