using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;


namespace AryanaCard
{
    public partial class StudentBillFrm : Form
    {
        private const string _prcFindStudentName = "prcFindStudentName";
        private const string _prcCardAssignUpdate_PayStatus2 = "prcCardAssignUpdate_PayStatus2";
        public static string _ConnectionString = Properties.Settings.Default.AryanaCardConnectionString;
        public string Query = "DECLARE @StudnetID int SELECT @StudnetID = " + Program.studentID.Trim() + " SELECT  ca.AssignID , ca.RegDate , c.CardNumber ,  CONVERT(bigint,ca.Cost)as Cost  FROM dbo.CardAssign ca JOIN dbo.Cards c ON c.CardID = ca.CardID WHERE ca.StudentID = @StudnetID AND ca.PayStatus = '3'";
        SqlConnection objConnection;
        SqlDataAdapter objDataAdapter;
        DataSet objDataSet;
        DataView objDataView;
    

        public StudentBillFrm()
        {
            objConnection = new SqlConnection(_ConnectionString);
            objDataAdapter = new SqlDataAdapter(Query, objConnection);
            InitializeComponent();
        }

        private void StudentBillFrm_Load(object sender, EventArgs e)
        {
            TasviehBT.Enabled = false;
            
            SqlCommand myCommand = new SqlCommand(_prcFindStudentName, objConnection);
            myCommand.CommandType = CommandType.StoredProcedure;



            myCommand.Parameters.AddWithValue("@StudentID", Program.studentID.Trim());
            myCommand.Parameters["@StudentID"].Direction = ParameterDirection.Input;

            myCommand.Parameters.Add("@StudentNumber", SqlDbType.VarChar, 10);
            myCommand.Parameters["@StudentNumber"].Direction = ParameterDirection.Output;

            myCommand.Parameters.Add("@StudentFName", SqlDbType.NVarChar, 25);
            myCommand.Parameters["@StudentFName"].Direction = ParameterDirection.Output;

            myCommand.Parameters.Add("@StudentLName", SqlDbType.NVarChar, 30);
            myCommand.Parameters["@StudentLName"].Direction = ParameterDirection.Output;


            objConnection.Open();
            myCommand.ExecuteReader();
            objConnection.Close();

            ReportTitleLB.Text =" صورت حساب دانشجو " + myCommand.Parameters["@StudentFName"].Value.ToString()+ " " + myCommand.Parameters["@StudentLName"].Value.ToString();
            
            objDataAdapter = new SqlDataAdapter(Query, objConnection);
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet, "Billing");
            objDataView = new DataView(objDataSet.Tables["Billing"]);
           
            this.gridEX1.SetDataBinding(objDataView, "");
                        
                    
            TotalFeeTB.DataBindings.Clear();
            TotalFeeTB.Text = objDataView.Table.Compute("SUM(Cost)", String.Empty).ToString();
                        
            
            Program.studentID = "";
        }

        

        private void TasviehBT_Click(object sender, EventArgs e)
        {
           
            SqlCommand myCommand = new SqlCommand(_prcCardAssignUpdate_PayStatus2, objConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            GridEXRow[] checkedRows;
            checkedRows = gridEX1.GetCheckedRows();
            

            string id = "";
            foreach (GridEXRow row in checkedRows)
            {
                id = row.Cells["AssignID"].Value.ToString();
                myCommand.Parameters.AddWithValue("@AssignID", id);
                myCommand.Parameters["@AssignID"].Direction = ParameterDirection.Input;

                objConnection.Open();
                myCommand.ExecuteReader();
                objConnection.Close();
                id = "";
            }
                      

            MessageBox.Show("مطالبات دانشجوی فوق تسویه گردید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
           

        }
 


        private void btnPrint_Click(object sender, EventArgs e)
        {            
            stiReport1.Load(Application.StartupPath + "\\studentbill.mrt");
            stiReport1.Compile();
            stiReport1["Name"] = ReportTitleLB.Text.Trim();
            stiReport1["TotalCost"] = TotalFeeTB.Text.Trim();
            stiReport1.RegData(objDataSet);
            stiReport1.Show();
        }

        
        private void gridEX1_RowCheckStateChanged(object sender, RowCheckStateChangeEventArgs e)
        {           
                GridEXRow[] checkedRows;
                checkedRows = gridEX1.GetCheckedRows();
                if (checkedRows.Length != 0)
                    TasviehBT.Enabled = true;
                else
                    TasviehBT.Enabled = false;            
            
        }       
    }
}
