using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AryanaCard
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;

        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            LoginFrm loginfrm = new LoginFrm();
            this.Hide();
            loginfrm.ShowDialog();
        }

        private void Splash_Click(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            LoginFrm loginfrm = new LoginFrm();
            this.Hide();
            loginfrm.ShowDialog();

        }
    }
}
