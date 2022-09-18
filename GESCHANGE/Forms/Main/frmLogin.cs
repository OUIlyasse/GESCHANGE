using GESCHANGE.Db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GESCHANGE.Forms.Main
{
    public partial class frmLogin : Form
    {
        #region Variables

        private GESSRMAEntities db = new GESSRMAEntities();

        #endregion Variables

        #region Codes

        private void Clear()
        {
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtUser.Focus();
        }

        #endregion Codes

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Users rs = db.Select_Users_Where(txtUser.Text).FirstOrDefault();
                if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("Votre champs est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Focus();
                }
                else
                {
                    if (rs.user_Name != null)
                    {
                        if (rs.user_Password.Equals(txtPass.Text))
                        {
                            frmMain f = new frmMain();
                            f.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Votre mot de passe est incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPass.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Votre identifiant est incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPass.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbxShow.Checked)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}