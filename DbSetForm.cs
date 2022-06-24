using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AryanaCard
{
    public partial class DbSetForm : Form
    {
        public DbSetForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbServerName.Text == "")
                return;
            if (txbUsername.Text == "")
                return;
            if (txbPassword.Text == "")
                return;
            Properties.Settings.Default.DBPassword = txbPassword.Text.Trim();
            Properties.Settings.Default.DBUserName = txbUsername.Text.Trim();
            Properties.Settings.Default.ServerAddress = txbServerName.Text.Trim();
            Properties.Settings.Default.Save();
            MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
