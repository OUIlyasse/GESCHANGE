using GESCHANGE.Forms.Sub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESCHANGE.Forms.Main
{
    public partial class frmMain : Form
    {
        #region Codes

        public void OpenForm(Form f)
        {
            pnlMenu.Controls.Clear();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            pnlMenu.Controls.Add(f);
            f.Visible = true;
            this.Text = "SRMA-" + f.Text;
        }

        #endregion Codes

        public frmMain()
        {
            InitializeComponent();
        }

        private void menuPieces_Click(object sender, EventArgs e)
        {
            frmListPieces fLP = new frmListPieces();
            OpenForm(fLP);
        }

        private void menuVehicules_Click(object sender, EventArgs e)
        {
            frmListVehicules fLV = new frmListVehicules();
            OpenForm(fLV);
        }

        private void menuEntree_Click(object sender, EventArgs e)
        {
            frmListEntrees fLE = new frmListEntrees();
            OpenForm(fLE);
        }

        private void menuSorties_Click(object sender, EventArgs e)
        {
            frmListSorties fLs = new frmListSorties();
            OpenForm(fLs);
        }
    }
}