using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AryanaCard
{
    public partial class SearchCardFrm : Form
    {
        public static string _ConnectionString = Properties.Settings.Default.AryanaCardConnectionString;
        private const string _prcCardStatus = "prcCardStatus";
        private const string _prcFindAssignID = "prcFindAssignID";



        SqlConnection objConnection;
        public SearchCardFrm()
        {
            objConnection = new SqlConnection(_ConnectionString);
            InitializeComponent();
        }

        private void OKBT_Click(object sender, EventArgs e)
        {
            try
            {

                if (CardNumberTB.Text != "")
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

                    if (CardStatus == "")
                    {
                        MessageBox.Show("کارتی با شماره فوق تعریف نشده است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CardNumberTB.Text = "";
                        CardNumberTB.Focus();
                    }
                    else if (CardStatus == "1")
                    {
                        MessageBox.Show("کارت فوق هنوز فروخته نشده است  \n . لطفاً شماره کارت دیگری وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CardNumberTB.Text = "";
                        CardNumberTB.Focus();
                    }
                    else if (CardStatus == "2")
                    {
                        Properties.Settings.Default.CardID = CardID.Trim();
                        SqlCommand myCommand1 = new SqlCommand(_prcFindAssignID, objConnection);
                        myCommand1.CommandType = CommandType.StoredProcedure;



                        myCommand1.Parameters.AddWithValue("@CardID", CardID.Trim());
                        myCommand1.Parameters["@CardID"].Direction = ParameterDirection.Input;

                        myCommand1.Parameters.Add("@StudentID", SqlDbType.Int);
                        myCommand1.Parameters["@StudentID"].Direction = ParameterDirection.Output;

                        myCommand1.Parameters.Add("@AssignID", SqlDbType.Int);
                        myCommand1.Parameters["@AssignID"].Direction = ParameterDirection.Output;
                        objConnection.Open();
                        myCommand1.ExecuteReader();
                        objConnection.Close();

                        Properties.Settings.Default.StudentID = myCommand1.Parameters["@StudentID"].Value.ToString();
                        Properties.Settings.Default.AssignID = myCommand1.Parameters["@AssignID"].Value.ToString();



                        this.Hide();
                        ReturnCardFrm retCardFrm = new ReturnCardFrm();
                        retCardFrm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("لطفاً شماره کارت را وارد نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CardNumberTB.Focus();
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("برقراری ارتباط با بانک اطلاعاتی مقدور نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }          

        }       
    }
}
