using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace AryanaCard
{
    public partial class DefineCardFrm : Form
    {
        private const string _CommandText = "SELECT Cards.CardNumber,Cards.CardRate,Cards.CardID FROM Cards ORDER BY Cards.CardID ";
        private const string _prcSaveCard = "prcSaveCard";
        private const string _prcCardUpdate = "prcCardUpdate";
        private const string _prcDelCard = "prcDelCard";
        public static string _ConnectionString = Properties.Settings.Default.AryanaCardConnectionString;
       

        SqlConnection objConnection;
        SqlDataAdapter objDataAdapter;
        DataSet objDataSet;
        DataView objDataView;
        CurrencyManager objCurrencyManager;

        public DefineCardFrm()
        {
            objConnection = new SqlConnection(_ConnectionString);
            objDataAdapter = new SqlDataAdapter(_CommandText, objConnection);

            InitializeComponent();
        }

        private void FillDataSetAndView()
        {
            try
            {
                objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet, "Cards");
                objDataView = new DataView(objDataSet.Tables["Cards"]);
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
            CardRateTB.DataBindings.Clear();
            CardIDTB.DataBindings.Clear();

            CardNumberTB.DataBindings.Add("Text", objDataView, "CardNumber");
            CardRateTB.DataBindings.Add("Text", objDataView, "CardRate");
            CardIDTB.DataBindings.Add("Text", objDataView, "CardID");

            DefineCardTSSLb.Text = "اطلاعات جهت مشاهده آماده می باشد";
         
            
        }

        private void ShowPosition()
        {
            RecordPositionTB.Text = ((objCurrencyManager.Position) + 1 )+ " از " + objCurrencyManager.Count; 

        }


        private void CancelBT_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefineCardFormActive = false;
            this.Close();
        }

        
        

        private void DefineCardFrm_Load(object sender, EventArgs e)
        {
            SaveBT.Enabled = false;
            CardNumberTB.ReadOnly = true;
            CardRateTB.ReadOnly = true;
            CardIDTB.Hide();           
            FillDataSetAndView();
            BindField();
            ShowPosition();
            DefineCardTTip.SetToolTip(this.MoveFirstBT, "نمایش اولین رکورد");
            DefineCardTTip.SetToolTip(this.MovePreviousBT, "نمایش رکورد قبلی");
            DefineCardTTip.SetToolTip(this.MoveNextBT, " نمایش رکورد بعدی ");
            DefineCardTTip.SetToolTip(this.MoveLastBT, "نمایش آخرین رکورد");


        }

       

        private void NewBT_Click(object sender, EventArgs e)
        {
            SaveBT.Enabled = true;
            NewBT.Enabled = false;
            ModifyBT.Enabled = false;
            DeleteBT.Enabled = false;

            CardNumberTB.Text = "";
            CardRateTB.Text = "5";
            DefineCardTSSLb.Text = "لطفاً اطلاعات کارت جدید را وارد نمایید";


            CardNumberTB.ReadOnly = false;
            CardRateTB.ReadOnly = false;

            CardNumberTB.Focus();


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

        private void SearchBT_Click(object sender, EventArgs e)
        {
            int intPosition;
            objDataView.Sort = "CardNumber";
            
            intPosition = objDataView.Find(SearchCardTB.Text.Trim());

            if (intPosition == -1)
            {
                DefineCardTSSLb.Text = " شماره کارت یافت نشد";
            }
            else
            {
                DefineCardTSSLb.Text = " شماره کارت یافت شد";
                objCurrencyManager.Position = intPosition;
                ShowPosition();
            }


        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
                       
            SqlCommand myCommand = new SqlCommand(_prcSaveCard, objConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

           
           
            myCommand.Parameters.AddWithValue("@CardNumber", CardNumberTB.Text.Trim());
            myCommand.Parameters["@CardNumber"].Direction = ParameterDirection.Input;

            myCommand.Parameters.AddWithValue("@CardRate",Convert.ToInt32(CardRateTB.Text.Trim()));
            myCommand.Parameters["@CardRate"].Direction = ParameterDirection.Input;
            
            myCommand.Parameters.AddWithValue("@UserId",Properties.Settings.Default.UserID);
            myCommand.Parameters["@UserId"].Direction = ParameterDirection.Input;

          
            
           

            try
            {

                objConnection.Open();
                myCommand.ExecuteNonQuery();


            }
            catch (SqlException sqle)
            {
                if (sqle.ErrorCode == -2146232060)
                    MessageBox.Show("شماره کارت تکراری می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            objConnection.Close();
            FillDataSetAndView();
            BindField();
            objCurrencyManager.Position = objCurrencyManager.Count;
            ShowPosition();
            DefineCardTSSLb.Text = "شماره کارت با موفقیت اضافه شد";
           
            SaveModifyBT.Visible = false;
            ModifyBT.Visible = true;
            ModifyBT.Enabled = true;
            CardNumberTB.ReadOnly = true;
            CardRateTB.ReadOnly = true;
            NewBT.Enabled = true;
            DeleteBT.Enabled = true;
            SaveBT.Enabled = false;

        }

        private void ModifyBT_Click(object sender, EventArgs e)
        {
            CardNumberTB.ReadOnly = false;
            CardRateTB.ReadOnly = false;

            NewBT.Enabled = false;
            SaveBT.Enabled = false;
            DeleteBT.Enabled = false;


            ModifyBT.Visible = false;
            SaveModifyBT.Visible = true;

                       

                       
        }

        private void SaveModifyBT_Click(object sender, EventArgs e)
        {
            int intPosition;
            SqlCommand myCommand = new SqlCommand(_prcCardUpdate, objConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            intPosition = objCurrencyManager.Position;

            myCommand.Parameters.AddWithValue("@CardNumber", CardNumberTB.Text.Trim());
            myCommand.Parameters["@CardNumber"].Direction = ParameterDirection.Input;

            myCommand.Parameters.AddWithValue("@CardRate", Convert.ToInt32(CardRateTB.Text.Trim()));
            myCommand.Parameters["@CardRate"].Direction = ParameterDirection.Input;

            myCommand.Parameters.AddWithValue("@CardID", Convert.ToInt32(CardIDTB.Text.Trim()));
            myCommand.Parameters["@CardID"].Direction = ParameterDirection.Input;

            objConnection.Open();
            myCommand.ExecuteNonQuery();
            objConnection.Close();
            FillDataSetAndView();
            BindField();
            objCurrencyManager.Position = intPosition;
            ShowPosition();

            SaveModifyBT.Visible = false;
            ModifyBT.Visible = true;
            CardNumberTB.ReadOnly = true;
            CardRateTB.ReadOnly = true;
            NewBT.Enabled = true;
            DeleteBT.Enabled = true;



        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            int intPosition;
            SqlCommand myCommand = new SqlCommand(_prcDelCard, objConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            intPosition = this.BindingContext[objDataView].Position - 1;

            if (intPosition < 0)
                intPosition = 0;

            myCommand.Parameters.AddWithValue("@CardID", Convert.ToInt32(CardIDTB.Text.Trim()));
            myCommand.Parameters["@CardID"].Direction = ParameterDirection.Input;

            objConnection.Open();
            try
            {

                myCommand.ExecuteNonQuery();
            }
            catch (SqlException sqle)
            {
                if (sqle.ErrorCode == -2146232060)
                    MessageBox.Show("این کارت دارای فروش می باشد.ابتدا فروش مورد نظر را حذف نمایید","خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            objConnection.Close();
            FillDataSetAndView();
            BindField();
            objCurrencyManager.Position = intPosition;
            ShowPosition();
            DefineCardTSSLb.Text = " کارت با موفقیت حذف شد ";

        }

      
               


    }
}
