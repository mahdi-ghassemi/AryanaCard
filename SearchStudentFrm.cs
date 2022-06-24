using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace AryanaCard
{
    public partial class SearchStudentFrm : Form
    {
        public static string _ConnectionString = Properties.Settings.Default.AryanaCardConnectionString;
        private const string _prcFindStudentID = "prcFindStudentID";
        
        SqlConnection objConnection;

        public SearchStudentFrm()
        {
            objConnection = new SqlConnection(_ConnectionString);
            InitializeComponent();
        }

        private void OKBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentNumberTB.Text != "")
                {
                    SqlCommand myCommand = new SqlCommand(_prcFindStudentID, objConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;



                    myCommand.Parameters.AddWithValue("@StudentNumber", StudentNumberTB.Text.Trim());
                    myCommand.Parameters["@StudentNumber"].Direction = ParameterDirection.Input;


                    myCommand.Parameters.Add("@StudentID", SqlDbType.Int);
                    myCommand.Parameters["@StudentID"].Direction = ParameterDirection.Output;



                    objConnection.Open();
                    myCommand.ExecuteReader();
                    objConnection.Close();

                    string StudentID = myCommand.Parameters["@StudentID"].Value.ToString();
                    //Properties.Settings.Default.StudentID = StudentID.Trim();
                    Program.studentID = StudentID.Trim();


                    if (StudentID == "")
                    {
                        MessageBox.Show("دانشجویی با شماره فوق تعریف نشده است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        StudentNumberTB.Text = "";
                        StudentNumberTB.Focus();
                    }
                    else
                    {
                        //this.Hide();
                        StudentBillFrm studentBillForm = new StudentBillFrm();
                        studentBillForm.ShowDialog();
                        //studentBillForm.BringToFront();
                        this.Close();
                    }

                }

                else
                {
                    MessageBox.Show("لطفاً شماره دانشجویی را وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StudentNumberTB.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("برقراری ارتباط با بانک اطلاعاتی مقدور نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);             
                this.Close();
            }          
        }

        private void StudentNumberTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OKBT_Click(sender,e);
        }

        
    }
}
