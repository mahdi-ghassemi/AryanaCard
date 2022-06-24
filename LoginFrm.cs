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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connect()
        {
            try
            {
                SqlConnection AryanaConnection = new SqlConnection(Properties.Settings.Default.AryanaCardConnectionString);
                SqlCommand myCommand = new SqlCommand("prcCheckPassword", AryanaConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 20);
                myCommand.Parameters["@UserName"].Value = UsernameTB.Text.Trim();
                myCommand.Parameters["@UserName"].Direction = ParameterDirection.Input;
                myCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 20);
                myCommand.Parameters["@Password"].Direction = ParameterDirection.Output;
                myCommand.Parameters.Add("@Exist", SqlDbType.Int, 1);
                myCommand.Parameters["@Exist"].Direction = ParameterDirection.Output;
                myCommand.Parameters.Add("@UserID", SqlDbType.Int);
                myCommand.Parameters["@UserID"].Direction = ParameterDirection.Output;



                AryanaConnection.Open();
                int username_exist;
                string pass;
                myCommand.ExecuteNonQuery();

                username_exist = (int)myCommand.Parameters["@Exist"].Value;
                if (username_exist == 0)
                    MessageBox.Show("نام کاربری یا کلمه عبور اشتباه می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    pass = (string)myCommand.Parameters["@Password"].Value;
                    if (PasswordTB.Text.Trim() == pass.Trim())
                    {
                        Properties.Settings.Default.UserName = UsernameTB.Text.Trim();
                        Properties.Settings.Default.UserID = (int)myCommand.Parameters["@UserID"].Value;
                        MainFrm mainfrm = new MainFrm();
                        this.Hide();
                        mainfrm.ShowDialog();
                    }


                    else
                        MessageBox.Show("نام کاربری یا کلمه عبور اشتباه می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                AryanaConnection.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show("برقراری ارتباط با بانک اطلاعاتی مقدور نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            } 
        }

        private void OKBT_Click(object sender, EventArgs e)
        {
            connect();
        }

        

        private void PasswordTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                connect();
        }

        private void UsernameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                connect();
        }

       
    }
}
