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
    public partial class frmPieces : Form
    {
        #region Variables

        private GESSRMAEntities db = new GESSRMAEntities();
        private frmListPieces flp;

        #endregion Variables

        #region Codes

        public void Clear()
        {
            txtNom.Text = string.Empty;
            txtReff.Text = string.Empty;
            txtQuantite.Text = string.Empty;
            txtNote.Text = string.Empty;
        }

        public void VerifyButtons()
        {
            if (Text == "Nouveau pièce")
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
                int? maxId = db.MaxID_Pieces().SingleOrDefault();
                string message;
                var isVerify = VerifyText(out message, txtNom);
                if (isVerify)
                {
                    MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    db.Insert_Pieces(maxId, txtNom.Text.Trim().ToUpper(), txtReff.Text.Trim().ToUpper(), 10, txtNote.Text);// verifie
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
            flp.dgvPieces.DataSource = db.Select_Pieces();
            flp.lblLigne.Text = string.Format("Ligne {0}", flp.dgvPieces.RowCount);
        }

        public bool Modify()
        {
            try
            {
                string message;
                var isVerify = VerifyText(out message, txtNom);
                if (isVerify)
                {
                    MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    db.Update_Pieces(int.Parse(flp.id), txtNom.Text.Trim().ToUpper(), txtReff.Text.Trim().ToUpper(), int.Parse(txtQuantite.Text), txtNote.Text);
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
                db.Delete_Pieces(int.Parse(flp.id));
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

        public frmPieces()
        {
            InitializeComponent();
        }

        public frmPieces(frmListPieces f)
        {
            InitializeComponent();
            flp = f;
        }

        public frmPieces(frmListPieces f, string n, string r, string q, string o)
        {
            InitializeComponent();
            flp = f;
            txtNom.Text = n;
            txtReff.Text = r;
            txtQuantite.Text = q;
            txtNote.Text = o;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Add())
            {
                MessageBox.Show("Votre pièce est bien enregistrée", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtNom.Focus();
                LoadData();
                Text = "Nouveau pièce";
                VerifyButtons();
            }
        }

        private void frmPieces_Activated(object sender, EventArgs e)
        {
            VerifyButtons();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Modify())
            {
                MessageBox.Show("Cette pièce est bien modifiée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtNom.Focus();
                LoadData();
                Text = "Nouveau pièce";
                VerifyButtons();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult re = MessageBox.Show("Voulez-vous supprimer cette pièce", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    if (Delete())
                    {
                        MessageBox.Show("Cette pièce est bien supprimée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNom.Focus();
                        LoadData();
                        Clear();
                        Text = "Nouveau pièce";
                        VerifyButtons();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}