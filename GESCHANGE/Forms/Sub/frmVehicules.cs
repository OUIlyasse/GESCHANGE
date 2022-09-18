using GESCHANGE.Db;
using System;
using System.Linq;
using System.Windows.Forms;
using static Tools.iTools;

namespace GESCHANGE.Forms.Sub
{
    public partial class frmVehicules : Form
    {
        #region Variables

        private GESSRMAEntities db = new GESSRMAEntities();
        private frmListVehicules flv;

        #endregion Variables

        #region Codes

        public bool Add()
        {
            try
            {
                var maxId = db.MaxID_Vehicules().SingleOrDefault();
                string message;
                var isVerify = VerifyText(out message, txtMleVehicule, txtGenre, txtMarque, txtNom, txtPrenom, txtMleFA);
                if (isVerify)
                {
                    MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    db.Insert_Vehicules(maxId, txtMleVehicule.Text.Trim().ToUpper(), txtGenre.Text.Trim().ToUpper(), txtMarque.Text.Trim().ToUpper(), txtNom.Text.Trim().ToUpper(), txtPrenom.Text.Trim().ToUpper(), int.Parse(cmbxGrade.SelectedValue.ToString()), txtMleFA.Text.Trim().ToUpper(), txtUnite.Text.Trim().ToUpper());
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

        public bool Modify()
        {
            try
            {
                string message;
                var isVerify = VerifyText(out message, txtMleVehicule, txtGenre, txtMarque, txtNom, txtPrenom, txtMleFA);
                if (isVerify)
                {
                    MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    db.Update_Vehicules(int.Parse(flv.idVL), txtMleVehicule.Text.Trim().ToUpper(), txtGenre.Text.Trim().ToUpper(), txtMarque.Text.Trim().ToUpper(), txtNom.Text.Trim().ToUpper(), txtPrenom.Text.Trim().ToUpper(), int.Parse(cmbxGrade.SelectedValue.ToString()), txtMleFA.Text.Trim().ToUpper(), txtUnite.Text.Trim().ToUpper());
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

        public void VerifyButtons()
        {
            if (Text == "Nouveau Véhicule")
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

        private void LoadGrades()
        {
            cmbxGrade.DataSource = db.Select_Grades();
            cmbxGrade.ValueMember = "grd_ID";
            cmbxGrade.DisplayMember = "grd_Libelle";
            cmbxGrade.SelectedIndex = -1;
        }

        private void NewRecord()
        {
            ClearAllTextBox(this);
            txtMleVehicule.Focus();
            LoadGrades();
        }

        public void LoadData()
        {
            flv.dgvVehicules.DataSource = db.Select_View_VL_Grade();
            flv.lblLigne.Text = string.Format("Ligne {0}", flv.dgvVehicules.RowCount);
        }

        public bool Delete()
        {
            try
            {
                db.Delete_Vehicules(int.Parse(flv.idVL));
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

        public frmVehicules(frmListVehicules f, string vm, string vgn, string vmr, string cn, string cp, int cgr, string cm, string cu)
        {
            InitializeComponent();
            flv = f;
            txtMleVehicule.Text = vm;
            txtGenre.Text = vgn;
            txtMarque.Text = vmr;
            txtNom.Text = cn;
            txtPrenom.Text = cp;
            cmbxGrade.SelectedValue = cgr;
            txtMleFA.Text = cm;
            txtUnite.Text = cu;
            VerifyButtons();
        }

        public frmVehicules(frmListVehicules f)
        {
            InitializeComponent();
            flv = f;
            VerifyButtons();
        }

        private void frmVehicules_Activated(object sender, EventArgs e)
        {
            VerifyButtons();
        }

        private void frmVehicules_Load(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Add())
            {
                MessageBox.Show("Ce Véhicule est bien ajouté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllTextBox(this);
                cmbxGrade.SelectedIndex = -1;
                txtMleVehicule.Focus();
                NewRecord();
                flv.getData();
                VerifyButtons();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Modify())
            {
                MessageBox.Show("Ce Véhicule est bien modifiée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllTextBox(this);
                cmbxGrade.SelectedIndex = -1;
                txtMleVehicule.Focus();
                LoadData();
                Text = "Nouveau pièce";
                VerifyButtons();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult re = MessageBox.Show("Voulez-vous supprimer ce Véhicule", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    if (Delete())
                    {
                        MessageBox.Show("Ce Véhicule est bien supprimée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNom.Focus();
                        LoadData();
                        ClearAllTextBox(this);
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