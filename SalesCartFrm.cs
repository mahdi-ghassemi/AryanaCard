using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AryanaCard
{
    public partial class SalesCartFrm : Form
    {
        public static string _CardConnectionString = Properties.Settings.Default.AryanaCardConnectionString;
        public static string _StudentConnectionString = "user id =" + Properties.Settings.Default.DBUserName.Trim() + ";password =" + Properties.Settings.Default.DBPassword.Trim() + ";" + "server =" + Properties.Settings.Default.ServerAddress.Trim() + ";" + "database = UNIREG;";
        private const string _prcCardStatus = "prcCardStatus";
        private const string _prcSaveSales = "prcSaveSales";
        private const string _prcStudentDetails = "prcStudentDetails";
        private const string _prcSaveStudent = "prcSaveStudent";
        private const string _prcCardNotAvailable = "prcCardNotAvailable";
        private const string _prcSalesUpdate = "prcSalesUpdate";
        private const string _prcDelCardAssign = "prcDelCardAssign";
        public static string _StudentID = "";
        public static string _StudentFName = "";
        public static string _StudentLName = "";
        public static string _date;

        private const string _CommandText = "SELECT c.AssignID,c.StudentID,c.CardID,c.Cost,c.RegDate,s.StudentFName,s.StudentLName,s.StudentNumber,d.CardNumber,d.CardStatus FROM CardAssign as c JOIN Student as s ON s.StudentID = c.StudentID JOIN Cards as d ON d.CardID = c.CardID ";
        
        SqlConnection objConnection;
        SqlConnection objStuConnection;
        
        SqlDataAdapter objDataAdapter;
        DataSet objDataSet;
        DataView objDataView;
        CurrencyManager objCurrencyManager;

        public SalesCartFrm()
        {

            objStuConnection = new SqlConnection(_StudentConnectionString);
            objConnection = new SqlConnection(_CardConnectionString);
            objDataAdapter = new SqlDataAdapter(_CommandText, objConnection); 
            InitializeComponent();
        }

        private void FillDataSetAndView()
        {
            try
            {
                objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet, "Sales");
                objDataView = new DataView(objDataSet.Tables["Sales"]);
                objCurrencyManager = (CurrencyManager)(this.BindingContext[objDataView]);
            }
            catch (SqlException)
            {
                MessageBox.Show("برقراری ارتباط با بانک اطلاعاتی مقدور نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }          
        }

        private void BindField()
        {
            CardNumberTB.DataBindings.Clear();
            SaleNumberTB.DataBindings.Clear();
            SalesDateTB.DataBindings.Clear();
            StudentNameTB.DataBindings.Clear();
            StudentFamilyTB.DataBindings.Clear();
            StudentNumberTB.DataBindings.Clear();
            FeeTB.DataBindings.Clear();
            StudentIDTb.DataBindings.Clear();


            SaleNumberTB.DataBindings.Add("Text", objDataView, "AssignID");
            SalesDateTB.DataBindings.Add("Text", objDataView, "RegDate");
            StudentNumberTB.DataBindings.Add("Text", objDataView, "StudentNumber");
            StudentNameTB.DataBindings.Add("Text", objDataView, "StudentFName");
            StudentFamilyTB.DataBindings.Add("Text", objDataView, "StudentLName");
            CardNumberTB.DataBindings.Add("Text", objDataView, "CardNumber");
            FeeTB.DataBindings.Add("Text", objDataView, "Cost");
            StudentIDTb.DataBindings.Add("Text", objDataView, "StudentID");


            
        }

        private void ShowPosition()
        {
            RecordPositionTB.Text = ((objCurrencyManager.Position) + 1) + " از " + objCurrencyManager.Count;

        }

        private void MoveFirstBT_Click(object sender, EventArgs e)
        {
            objCurrencyManager.Position = 0;
            ShowPosition();
        }

        private void MovePreviousBT_Click(object sender, EventArgs e)
        {
            objCurrencyManager.Position -= 1;
            ShowPosition();
        }

        private void MoveNextBT_Click(object sender, EventArgs e)
        {
            objCurrencyManager.Position += 1;
            ShowPosition();
        }

        private void MoveLastBT_Click(object sender, EventArgs e)
        {
            objCurrencyManager.Position = objCurrencyManager.Count - 1;
            ShowPosition();
        }

        
        private void SalesCartFrm_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.SalesCardFormActive = true;


            FillDataSetAndView();
            BindField();
            ShowPosition();
            if (Properties.Settings.Default.SalesCardFormStatus == 2)
                CardNumberTB.Focus();
        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SalesCardFormActive = false;
            this.Close();

        }

        private void NewBT_Click(object sender, EventArgs e)
        {
            ModifyBT.Enabled = false;
            DeleteBT.Enabled = false;
           
            NewBT.Enabled = false;

            
            SalesDateTB.ReadOnly = false;
            StudentNumberTB.ReadOnly = false;
            CardNumberTB.ReadOnly = false;
            FeeTB.ReadOnly = false;
            SaveBT.Enabled = true;
            StudentNumberTB.Enabled = true;

            CardNumberTB.Enabled = true;
            SalesDateTB.Enabled = true;
            FeeTB.Enabled = true;

            CardNumberTB.Text = "";
            SaleNumberTB.Text = "";
            SalesDateTB.Text = "";
            StudentNameTB.Text = "";
            StudentFamilyTB.Text = "";
            StudentNumberTB.Text = "";
            StudentIDTb.Text = "";
            TellSabetTB.Text = "";
            TellHamrahTB.Text = "";

            FeeTB.Text = "";
            Persia.SunDate sundate = Persia.Calendar.ConvertToPersian(DateTime.Now);
           
            SalesDateTB.Text = sundate.Simple;
            StudentNumberTB.Focus();


        }

        private void StudentNumberTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand myCommand = new SqlCommand(_prcStudentDetails, objConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddWithValue("@StudentNumber", StudentNumberTB.Text.Trim());
                myCommand.Parameters["@StudentNumber"].Direction = ParameterDirection.Input;

                myCommand.Parameters.Add("@StudentID", SqlDbType.Int);
                myCommand.Parameters["@StudentID"].Direction = ParameterDirection.Output;

                myCommand.Parameters.Add("@StudentFName", SqlDbType.NVarChar, 25);
                myCommand.Parameters["@StudentFName"].Direction = ParameterDirection.Output;

                myCommand.Parameters.Add("@StudentLName", SqlDbType.NVarChar, 30);
                myCommand.Parameters["@StudentLName"].Direction = ParameterDirection.Output;

                objConnection.Open();
                myCommand.ExecuteReader();
                objConnection.Close();

                _StudentID = myCommand.Parameters["@StudentID"].Value.ToString();
                _StudentFName = myCommand.Parameters["@StudentFName"].Value.ToString();
                _StudentLName = myCommand.Parameters["@StudentLName"].Value.ToString();

                StudentNameTB.Text = "";
                StudentFamilyTB.Text = "";

                StudentNameTB.Text = _StudentFName;
                StudentFamilyTB.Text = _StudentLName;
                CardNumberTB.Focus();



                if (_StudentID == "")
                {
                    string _StuCommandText = "DECLARE @StudentNumber varchar(10) SELECT @StudentNumber = " + StudentNumberTB.Text.Trim() + " SELECT Fld_StudentNumber,Fld_FName,Fld_LName,fld_HTel,fld_WTel,fld_CTel FROM Tbl_StudentInfo WHERE Fld_StudentNumber = @StudentNumber";
                    // -> function to connect to student register database and retrive student name and family
                    SqlDataAdapter objDataAdapter;
                    DataSet objDataSet;
                    DataView objDataView;



                    objDataAdapter = new SqlDataAdapter(_StuCommandText, objStuConnection);
                    objDataSet = new DataSet();
                    objDataAdapter.Fill(objDataSet, "StudentDetails");
                    objDataView = new DataView(objDataSet.Tables["StudentDetails"]);

                    StudentNameTB.DataBindings.Clear();
                    StudentFamilyTB.DataBindings.Clear();
                    TellSabetTB.DataBindings.Clear();
                    TellHamrahTB.DataBindings.Clear();
                    

                  
                    StudentNameTB.DataBindings.Add("Text", objDataSet.Tables["StudentDetails"], "Fld_FName");
                    StudentFamilyTB.DataBindings.Add("Text", objDataSet.Tables["StudentDetails"], "Fld_LName");
                    TellSabetTB.DataBindings.Add("Text", objDataSet.Tables["StudentDetails"], "fld_HTel");
                    TellHamrahTB.DataBindings.Add("Text", objDataSet.Tables["StudentDetails"], "fld_CTel");

                    // Save the student info too my database

                    SqlCommand myCommand2 = new SqlCommand(_prcSaveStudent, objConnection);
                    myCommand2.CommandType = CommandType.StoredProcedure;

                    myCommand2.Parameters.AddWithValue("@StudentNumber", StudentNumberTB.Text.Trim());
                    myCommand2.Parameters["@StudentNumber"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@StudentFName", StudentNameTB.Text);
                    myCommand2.Parameters["@StudentFName"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@StudentLName", StudentFamilyTB.Text);
                    myCommand2.Parameters["@StudentLName"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@StudentTel", TellSabetTB.Text.Trim());
                    myCommand2.Parameters["@StudentTel"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@StudentCel", TellHamrahTB.Text.Trim());
                    myCommand2.Parameters["@StudentCel"].Direction = ParameterDirection.Input;


                    myCommand2.Parameters.AddWithValue("@UserID", Properties.Settings.Default.UserID);
                    myCommand2.Parameters["@UserID"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.Add("@StudentID", SqlDbType.Int);
                    myCommand2.Parameters["@StudentID"].Direction = ParameterDirection.Output;

                    objConnection.Open();
                    myCommand2.ExecuteReader();
                    objConnection.Close();
                    _StudentID = myCommand2.Parameters["@StudentID"].Value.ToString();
                    StudentIDTb.Text = myCommand2.Parameters["@StudentID"].Value.ToString();
                    CardNumberTB.Focus();




                    
                }
            }
                 
        }



        private void SaveBT_Click(object sender, EventArgs e)
        {
            if (CardNumberTB.Text != "" && StudentNumberTB.Text != "" && SalesDateTB.Text != "")
            {

                SqlCommand myCommand = new SqlCommand(_prcCardStatus, objConnection);
                myCommand.CommandType = CommandType.StoredProcedure;



                myCommand.Parameters.AddWithValue("@CardNumber", CardNumberTB.Text.Trim());
                myCommand.Parameters["@CardNumber"].Direction = ParameterDirection.Input;

                myCommand.Parameters.Add("@CardStatus", SqlDbType.NVarChar, 1);
                myCommand.Parameters["@CardStatus"].Direction = ParameterDirection.Output;

                myCommand.Parameters.Add("@CardID", SqlDbType.Int);
                myCommand.Parameters["@CardID"].Direction = ParameterDirection.Output;



                objConnection.Open();
                myCommand.ExecuteReader();
                objConnection.Close();

                string CardStatus = myCommand.Parameters["@CardStatus"].Value.ToString();
                string CardID = myCommand.Parameters["@CardID"].Value.ToString();




                if (CardStatus == "1")
                {
                    SqlCommand myCommand2 = new SqlCommand(_prcSaveSales, objConnection);
                    myCommand2.CommandType = CommandType.StoredProcedure;

                    myCommand2.Parameters.AddWithValue("@StudentID", _StudentID);
                    myCommand2.Parameters["@StudentID"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@CardID", CardID);
                    myCommand2.Parameters["@CardID"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@Cost", FeeTB.Text.Trim());
                    myCommand2.Parameters["@Cost"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@RegDate", SalesDateTB.Text.Trim());
                    myCommand2.Parameters["@RegDate"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@UserID", Properties.Settings.Default.UserID);
                    myCommand2.Parameters["@UserID"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@RefNumber", "");
                    myCommand2.Parameters["@RefNumber"].Direction = ParameterDirection.Input;

                    objConnection.Open();
                    myCommand2.ExecuteNonQuery();
                    objConnection.Close();

                    MessageBox.Show("فروش کارت با موفقیت ثبت شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SaveBT.Enabled = false;
                    SalesDateTB.Enabled = false;
                    StudentNumberTB.Enabled = false;
                    CardNumberTB.Enabled = false;
                    FeeTB.Enabled = false;
                    NewBT.Enabled = true;
                    ModifyBT.Enabled = true;
                    DeleteBT.Enabled = true;
                   

                    FillDataSetAndView();
                    BindField();
                    objCurrencyManager.Position = objCurrencyManager.Count;
                    ShowPosition();

                    SqlCommand myCommand3 = new SqlCommand(_prcCardNotAvailable, objConnection);
                    myCommand3.CommandType = CommandType.StoredProcedure;

                    myCommand3.Parameters.AddWithValue("@CardId", CardID);
                    myCommand3.Parameters["@CardId"].Direction = ParameterDirection.Input;
                    objConnection.Open();
                    myCommand3.ExecuteNonQuery();
                    objConnection.Close();

                }

                else if (CardStatus == "")
                {
                    MessageBox.Show("کارتی با شماره فوق تعریف نشده است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CardNumberTB.Focus();
                }

                else if (CardStatus == "2")
                {
                    MessageBox.Show("کارت فوق قبلاً فروخته شده است و هنوز تسویه \n نگردیده است. لطفاً شماره کارت دیگری وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CardNumberTB.Focus();
                }

            }
            else
            {
                MessageBox.Show("لطفاً اطلاعات را کامل وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (SalesDateTB.Text == "")
                {
                    Persia.SunDate sundate = Persia.Calendar.ConvertToPersian(DateTime.Now);
                    SalesDateTB.Text = sundate.Simple;
                    SalesDateTB.Focus();
                }
                else if (StudentNumberTB.Text == "")
                    StudentNumberTB.Focus();
                else if (CardNumberTB.Text == "")
                    CardNumberTB.Focus();
            }



        }

        private void ModifyBT_Click(object sender, EventArgs e)
        {

           
            ModifyBT.Enabled = false;
            DeleteBT.Enabled = false;
            
            NewBT.Enabled = false;
            ModifyBT.Visible = false;


            SalesDateTB.ReadOnly = false;
            StudentNumberTB.ReadOnly = false;
            CardNumberTB.ReadOnly = true;
            FeeTB.ReadOnly = false;
            SaveBT.Enabled = false;
            SaveModifyBT.Visible = true;
            SaveModifyBT.Enabled = true;

            SalesDateTB.Focus();
            

        }

        private void SaveModifyBT_Click(object sender, EventArgs e)
        {
            if (StudentNumberTB.Text != "" && SalesDateTB.Text != "")
            {

                int intPosition;

                    SqlCommand myCommand2 = new SqlCommand(_prcSalesUpdate, objConnection);
                    myCommand2.CommandType = CommandType.StoredProcedure;
                    intPosition = objCurrencyManager.Position;
                    myCommand2.Parameters.AddWithValue("@StudentID", StudentIDTb.Text.Trim());
                    myCommand2.Parameters["@StudentID"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@Cost", FeeTB.Text.Trim());
                    myCommand2.Parameters["@Cost"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@RegDate", SalesDateTB.Text.Trim());
                    myCommand2.Parameters["@RegDate"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@AssignID", SaleNumberTB.Text.Trim());
                    myCommand2.Parameters["@AssignID"].Direction = ParameterDirection.Input;

                    myCommand2.Parameters.AddWithValue("@RefNumber", "");
                    myCommand2.Parameters["@RefNumber"].Direction = ParameterDirection.Input;

                    objConnection.Open();
                    myCommand2.ExecuteNonQuery();
                    objConnection.Close();

                    MessageBox.Show("تغییرات با موفقیت ثبت شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SaveBT.Enabled = false;
                    SalesDateTB.Enabled = false;
                    StudentNumberTB.Enabled = false;
                    CardNumberTB.Enabled = false;
                    FeeTB.Enabled = false;
                    NewBT.Enabled = true;
                    ModifyBT.Enabled = true;
                    DeleteBT.Enabled = true;
                    
                    ModifyBT.Visible = true;
                    SaveModifyBT.Visible = false;
                    SaveModifyBT.Enabled = false;



                    FillDataSetAndView();
                    BindField();
                    objCurrencyManager.Position = intPosition;
                    ShowPosition();

                    
                }

               

            
            else
            {
                MessageBox.Show("لطفاً اطلاعات را کامل وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (SalesDateTB.Text == "")
                {
                    Persia.SunDate sundate = Persia.Calendar.ConvertToPersian(DateTime.Now);
                    SalesDateTB.Text = sundate.Simple;
                    SalesDateTB.Focus();
                }
                else if (StudentNumberTB.Text == "")
                    StudentNumberTB.Focus();
               
            }

        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            int intPosition;
            SqlCommand myCommand = new SqlCommand(_prcDelCardAssign, objConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            intPosition = this.BindingContext[objDataView].Position - 1;

            if (intPosition < 0)
                intPosition = 0;

            myCommand.Parameters.AddWithValue("@AssignID", Convert.ToInt32(SaleNumberTB.Text.Trim()));
            myCommand.Parameters["@AssignID"].Direction = ParameterDirection.Input;

            objConnection.Open();
            
                myCommand.ExecuteNonQuery();
          
            objConnection.Close();
            FillDataSetAndView();
            BindField();
            objCurrencyManager.Position = intPosition;
            ShowPosition();
          

        }

        private void SearchBT_Click(object sender, EventArgs e)
        {

        }

        

       

       

        
    }
}
