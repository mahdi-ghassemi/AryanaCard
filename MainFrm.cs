using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AryanaCard
{
    public partial class MainFrm : Form
    {
        public static DefineCardFrm defCardfrm;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void تعریفکارتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DefineCardFormActive == false)
            {
                Properties.Settings.Default.DefineCardFormActive = true;
                DefineCardFrm defCardForm = new DefineCardFrm();
                //defCardForm.MdiParent = this;
                defCardForm.ShowDialog();
                defCardForm.BringToFront();
                Properties.Settings.Default.DefineCardFormActive = false;
            }


        }

        private void فروشکارتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SalesCardFormActive == false)
            {
                Properties.Settings.Default.SalesCardFormActive = true;
                SalesCartFrm saleCardForm = new SalesCartFrm();
                saleCardForm.ShowDialog();
                saleCardForm.BringToFront();
                Properties.Settings.Default.SalesCardFormActive = false;
            }

        }

        private void ارجاعکارتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCardFrm searchCardForm = new SearchCardFrm();
            searchCardForm.ShowDialog();

        }

        private void صورتحسابدانشجوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudentFrm searchStudentForm = new SearchStudentFrm();
            searchStudentForm.ShowDialog();

        }

        private void کلکارتهایفروختهشدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllSalesCardReport all = new AllSalesCardReport();
            all.ShowDialog();

        }

        private void لیستکلخریدارانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList sl = new StudentList();
            sl.ShowDialog();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void تعریفدانشجوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.ShowDialog();
        }

        private void گردشیککارتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GardeshForm fg = new GardeshForm();
            fg.ShowDialog();
        }

        private void اتصالبهبانکاطلاعاتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbSetForm dbfrm = new DbSetForm();
            dbfrm.ShowDialog();
        }

   

    }
}
