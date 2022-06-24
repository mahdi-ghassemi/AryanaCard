using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AryanaCard
{
    public partial class ReturnCardFrm : Form
    {
        private const string _prcFindStudentName = "prcFindStudentName";
        public static string _ConnectionString = Properties.Settings.Default.AryanaCardConnectionString;
        public static string Query = "DECLARE @AssignID int SELECT @AssignID = " + Properties.Settings.Default.AssignID.Trim() + " SELECT c.AssignID , c.CardID ,c.Cost ,c.RegDate ,c.StudentID FROM dbo.CardAssign c WHERE c.AssignID = @AssignID AND c.PayStatus = '1'";
        public const string _prcFindCardNumber = "prcFindCardNumber";
        private const string _prcCardAssignUpdate = "prcCardAssignUpdate";
        private const string _prcCardStatusUpdate = "prcCardStatusUpdate";

        SqlConnection objConnection;
        SqlDataAdapter objDataAdapter;
        DataSet objDataSet;
        DataView objDataView;
        CurrencyManager objCurrencyManager;



        public ReturnCardFrm()
        {
            objConnection = new SqlConnection(_ConnectionString);
            objDataAdapter = new SqlDataAdapter(Query, objConnection);
            InitializeComponent();
        }

        private void FillDataSetAndView()
        {
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet, "SalesDetials");
            objDataView = new DataView(objDataSet.Tables["SalesDetials"]);
            objCurrencyManager = (CurrencyManager)(this.BindingContext[objDataView]);
        }

        private void BindField()
        {
            
            SaleNumberTB.DataBindings.Clear();
            SalesDateTB.DataBindings.Clear();
            FeeTB.DataBindings.Clear();

            SaleNumberTB.DataBindings.Add("Text", objDataView, "AssignID");
            SalesDateTB.DataBindings.Add("Text", objDataView, "RegDate");
            FeeTB.DataBindings.Add("Text", objDataView, "Cost");

            
            

        }



        private void ReturnCardFrm_Load(object sender, EventArgs e)
        {
            SqlCommand myCommand = new SqlCommand(_prcFindStudentName, objConnection);
            myCommand.CommandType = CommandType.StoredProcedure;



            myCommand.Parameters.AddWithValue("@StudentID", Properties.Settings.Default.StudentID.Trim());
            myCommand.Parameters["@StudentID"].Direction = ParameterDirection.Input;

            myCommand.Parameters.Add("@StudentNumber", SqlDbType.NVarChar , 10);
            myCommand.Parameters["@StudentNumber"].Direction = ParameterDirection.Output;

            myCommand.Parameters.Add("@StudentFName", SqlDbType.NVarChar , 25);
            myCommand.Parameters["@StudentFName"].Direction = ParameterDirection.Output;

            myCommand.Parameters.Add("@StudentLName", SqlDbType.NVarChar, 30);
            myCommand.Parameters["@StudentLName"].Direction = ParameterDirection.Output;
            

            objConnection.Open();
            myCommand.ExecuteReader();
            objConnection.Close();

            SqlCommand myCommand1 = new SqlCommand(_prcFindCardNumber, objConnection);
            myCommand1.CommandType = CommandType.StoredProcedure;



            myCommand1.Parameters.AddWithValue("@CardID", Properties.Settings.Default.CardID.Trim());
            myCommand1.Parameters["@CardID"].Direction = ParameterDirection.Input;

            myCommand1.Parameters.Add("@CardNumber", SqlDbType.NVarChar, 20);
            myCommand1.Parameters["@CardNumber"].Direction = ParameterDirection.Output;

            objConnection.Open();
            myCommand1.ExecuteReader();
            objConnection.Close();


            FeeTB.ReadOnly = false;
            FillDataSetAndView();
            BindField();
            StudentNumberTB.Text = myCommand.Parameters["@StudentNumber"].Value.ToString();
            StudentNameTB.Text = myCommand.Parameters["@StudentFName"].Value.ToString();
            StudentFamilyTB.Text = myCommand.Parameters["@StudentLName"].Value.ToString();
            CardNumberTB.Text = myCommand1.Parameters["@CardNumber"].Value.ToString();

            FeeTB.Focus();
            
        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AssignID = "";
            Properties.Settings.Default.CardID = "";
            Properties.Settings.Default.StudentID = "";
            this.Close();

        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            SqlCommand myCommand = new SqlCommand(_prcCardAssignUpdate, objConnection);
            myCommand.CommandType = CommandType.StoredProcedure;



            myCommand.Parameters.AddWithValue("@AssignID", Properties.Settings.Default.AssignID.Trim());
            myCommand.Parameters["@AssignID"].Direction = ParameterDirection.Input;

            myCommand.Parameters.AddWithValue("@Cost", FeeTB.Text.Trim());
            myCommand.Parameters["@Cost"].Direction = ParameterDirection.Input;


            objConnection.Open();
            myCommand.ExecuteNonQuery();
            objConnection.Close();

            SqlCommand myCommand1 = new SqlCommand(_prcCardStatusUpdate, objConnection);
            myCommand1.CommandType = CommandType.StoredProcedure;



            myCommand1.Parameters.AddWithValue("@CardID", Properties.Settings.Default.CardID.Trim());
            myCommand1.Parameters["@CardID"].Direction = ParameterDirection.Input;




            objConnection.Open();
            myCommand1.ExecuteNonQuery();
            objConnection.Close();

            if (FeeTB.Text.Trim() != "")
            {

                SqlCommand myCommand2 = new SqlCommand("prcCardAssignUpdate_PayStatus3", objConnection);
                myCommand2.CommandType = CommandType.StoredProcedure;



                myCommand2.Parameters.AddWithValue("@AssignID", Properties.Settings.Default.AssignID.Trim());
                myCommand2.Parameters["@AssignID"].Direction = ParameterDirection.Input;



                objConnection.Open();
                myCommand2.ExecuteNonQuery();
                objConnection.Close();
            }



            MessageBox.Show("اطلاعات با موفقیت به روز رسانی شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Properties.Settings.Default.AssignID = "";
            Properties.Settings.Default.CardID = "";
            Properties.Settings.Default.StudentID = "";

            this.Close();

        }
    }
}
