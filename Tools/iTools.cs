using System;
using System.Linq;
using System.Windows.Forms;

namespace Tools
{
    public static class iTools
    {
        public static void Backup()
        {
            //FolderBrowserDialog fb = new FolderBrowserDialog();
            //backup = string.Empty;
            //if (fb.ShowDialog() == DialogResult.OK)
            //{
            //    backup = string.Format("{0}\\{1}_{2}.bak", fb.SelectedPath, db, DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss"));
            //}
        }

        public static void ClearAllTextBox(Form frm)
        {
            foreach (var txt in frm.Controls.OfType<TextBox>())
            {
                foreach (var t in txt.Controls.OfType<TextBox>())
                    t.Text = string.Empty;
            }
            foreach (var grpBox in frm.Controls.OfType<ComboBox>())
            {
                foreach (var TTX in grpBox.Controls.OfType<ComboBox>())
                    TTX.SelectedIndex = -1;
            }
            foreach (var grpBox in frm.Controls.OfType<GroupBox>())
            {
                foreach (var TTX in grpBox.Controls.OfType<TextBox>())
                    TTX.Text = string.Empty;
                foreach (var TTX in grpBox.Controls.OfType<ComboBox>())
                    TTX.SelectedIndex = -1;
            }
            foreach (var grpBox in frm.Controls.OfType<Panel>())
            {
                foreach (var TTX in grpBox.Controls.OfType<TextBox>())
                    TTX.Text = string.Empty;
                foreach (var TTX in grpBox.Controls.OfType<ComboBox>())
                    TTX.SelectedIndex = -1;
            }
        }

        public static void Restore()
        {
        }

        public static bool VerifyText(out string msg, params TextBox[] txt)
        {
            bool o = false;
            msg = string.Empty;
            foreach (TextBox t in txt)
            {
                if (string.IsNullOrEmpty(t.Text))
                {
                    msg = "L'un de vos champs est vide, veuillez le compléter";
                    o = true;
                }
                else { o = false; }
            }
            return o;
        }
    }
}