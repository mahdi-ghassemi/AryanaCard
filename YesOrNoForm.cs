using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AryanaCard
{
    public partial class YesOrNoForm : Form
    {
        public YesOrNoForm()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormReturn = 0;
            Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormReturn = 1;
            Close();
        }
    }
}