using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AryanaCard
{
    public partial class StudentList : Form
    {
        public static string _ConnectionString = Properties.Settings.Default.AryanaCardConnectionString;
        public string Query = "SELECT StudentNumber as 'شماره دانشجویی',StudentFName as 'نام' ,StudentLName as 'نام خانوادگی' ,StudentTel as 'تلفن' ,StudentCel as 'همراه' FROM Student";
        //public string Query = "SELECT StudentNumber ,StudentFName  ,StudentLName  ,StudentTel  ,StudentCel FROM Student";
        SqlConnection objConnection;
        SqlDataAdapter objDataAdapter;
        DataSet objDataSet;
        DataView objDataView;

        public StudentList()
        {
            objConnection = new SqlConnection(_ConnectionString);
            objDataAdapter = new SqlDataAdapter(Query, objConnection);
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            try
            {
                objDataAdapter = new SqlDataAdapter(Query, objConnection);
                objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet, "Report");
                objDataView = new DataView(objDataSet.Tables["Report"]);

                dataGridView1.DataSource = objDataSet.Tables["Report"];
                dataGridView1.Show();
            }
            catch (SqlException)
            {
                MessageBox.Show("برقراری ارتباط با بانک اطلاعاتی مقدور نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }        

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            stiReport1.Load(Application.StartupPath + "\\allstudents.mrt");
            stiReport1.Compile();
            stiReport1.RegData(objDataSet);
            stiReport1.Show();
        }
    }
}