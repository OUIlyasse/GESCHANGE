using GESCHANGE.Db;
using System;
using System.Linq;
using System.Windows.Forms;
using static Tools.iTools;

namespace GESCHANGE.Forms.Sub
{
    public partial class frmENew : Form
    {
        #region Variables

        private GESSRMAEntities db = new GESSRMAEntities();
        private frmListEntrees fle;

        #endregion Variables

        #region Codes

        public void Clear()
        {
            dtOperation.Value = DateTime.Now;
            txtFournisseur.Text = string.Empty;
            cmbxPieces.Text = string.Empty;
            txtReff.Text = string.Empty;
            txtQuantite.Text = string.Empty;
            txtNote.Text = string.Empty;
        }

        public void VerifyButtons()
        {
            if (Text == "Nouvelle opération d'entrer")
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
                int? maxId = db.MaxID_Entrees().SingleOrDefault();
                string message;
                var isVerify = VerifyText(out message, txtFournisseur, txtReff, txtQuantite);
                if (isVerify && string.IsNullOrEmpty(dtOperation.Text) && string.IsNullOrEmpty(cmbxPieces.Text))
                {
                    MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    db.Insert_Entrees(maxId, txtFournisseur.Text.Trim().ToUpper(), dtOperation.Value, txtReff.Text.Trim().ToUpper(), int.Parse(txtQuantite.Text), txtNote.Text.Trim(), int.Parse(cmbxPieces.SelectedValue.ToString()));
                    Pieces rs = db.Select_Pieces_By_Name(cmbxPieces.Text).FirstOrDefault();
                    var qte = int.Parse(rs.pies_Quantite.ToString()) + int.Parse(txtQuantite.Text);
                    db.Update_Pieces_Quantite_By_Name(cmbxPieces.Text, qte);
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
            fle.dgvEntrees.DataSource = db.Select_View_EP_Entrees();
            fle.lblLigne.Text = string.Format("Ligne {0}", fle.dgvEntrees.RowCount);
        }

        public void LoadPieces()
        {
            cmbxPieces.DataSource = db.Select_Pieces();
            cmbxPieces.ValueMember = "pies_ID";
            cmbxPieces.DisplayMember = "pies_Nom";
            cmbxPieces.SelectedIndex = -1;
        }

        public bool Modify()
        {
            try
            {
                string message;
                var isVerify = VerifyText(out message, txtFournisseur, txtReff, txtQuantite);
                if (isVerify && string.IsNullOrEmpty(dtOperation.Text) && string.IsNullOrEmpty(cmbxPieces.Text))
                {
                    MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    db.Update_Entrees(int.Parse(fle.id), txtFournisseur.Text.Trim().ToUpper(), dtOperation.Value, txtReff.Text.Trim().ToUpper(), int.Parse(txtQuantite.Text), txtNote.Text.Trim(), int.Parse(cmbxPieces.SelectedValue.ToString()));
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
                db.Delete_Entrees(int.Parse(fle.id));
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion Codes

        public frmENew(frmListEntrees f)
        {
            InitializeComponent();
            fle = f;
            VerifyButtons();
        }

        public frmENew(frmListEntrees f, DateTime date, string frns, string reff, int que, string note, string ps)
        {
            InitializeComponent();
            fle = f;
            dtOperation.Value = date;
            txtFournisseur.Text = frns;
            txtReff.Text = reff;
            txtQuantite.Text = que.ToString();
            txtNote.Text = note;
            cmbxPieces.Text = ps;
            VerifyButtons();
        }

        private void frmENew_Activated(object sender, EventArgs e)
        {
            LoadPieces();
            VerifyButtons();
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
                        Text = "Nouvelle opération d'entrer";
                        VerifyButtons();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Modify())
            {
                MessageBox.Show("Cette Opération est bien modifiée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                dtOperation.Focus();
                LoadData();
                Text = "Nouvelle opération d'entrer";
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
                Text = "Nouvelle opération d'entrer";
                VerifyButtons();
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
    }
}