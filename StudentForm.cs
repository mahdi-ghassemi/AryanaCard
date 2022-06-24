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
    public partial class StudentForm : Form
    {
        public static string _CardConnectionString = Properties.Settings.Default.AryanaCardConnectionString;
        private const string _CommandText = "SELECT * FROM Student";
        private const string _commandInsert = "";
        private const string _commandDelete = "";
        private const string _commandUpdate = "";

        SqlConnection objConnection;
        
        SqlDataAdapter objDataAdapter;
        DataSet objDataSet;
        DataView objDataView;
        CurrencyManager objCurrencyManager;

        public StudentForm()
        {
            objConnection = new SqlConnection(_CardConnectionString);
            objDataAdapter = new SqlDataAdapter(_CommandText, objConnection); 
            InitializeComponent();
        }

        private void FillDataSetAndView()
        {
            try
            {
                objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet, "Students");
                objDataView = new DataView(objDataSet.Tables["Students"]);
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

            txbID.DataBindings.Clear();
            txbName.DataBindings.Clear();
            txbFamilly.DataBindings.Clear();
            txbStudentNumber.DataBindings.Clear();
            txbTell.DataBindings.Clear();
            txbCell.DataBindings.Clear();

            txbID.DataBindings.Add("Text", objDataView, "StudentID");
            txbName.DataBindings.Add("Text", objDataView, "StudentFName");
            txbFamilly.DataBindings.Add("Text", objDataView, "StudentLName");
            txbStudentNumber.DataBindings.Add("Text", objDataView, "StudentNumber");
            txbTell.DataBindings.Add("Text", objDataView, "StudentTel");
            txbCell.DataBindings.Add("Text", objDataView, "StudentCel");

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

        private void StudentForm_Load(object sender, EventArgs e)
        {
            txbID.Hide();
            FillDataSetAndView();
            BindField();
            ShowPosition();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            btnNew.Visible = false;
            btnSave.Visible = true;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            MoveFirstBT.Enabled = false;
            MoveLastBT.Enabled = false;
            MoveNextBT.Enabled = false;
            MovePreviousBT.Enabled = false;
            RecordPositionTB.Text = null;

            txbName.ReadOnly = false;
            txbFamilly.ReadOnly = false;
            txbStudentNumber.ReadOnly = false;
            txbTell.ReadOnly = false;
            txbCell.ReadOnly = false;

            txbID.DataBindings.Clear();
            txbName.DataBindings.Clear();
            txbFamilly.DataBindings.Clear();
            txbStudentNumber.DataBindings.Clear();
            txbTell.DataBindings.Clear();
            txbCell.DataBindings.Clear();

            txbID.Text = null;
            txbName.Text = null;
            txbFamilly.Text = null;
            txbStudentNumber.Text = null;
            txbTell.Text = null;
            txbCell.Text = null;

            txbName.Focus();


            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbName.Text == "")
            {
                MessageBox.Show("نام دانشجو باید وارد شود", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbFamilly.Text == "")
            {
                MessageBox.Show("نام خانوادگی دانشجو باید وارد شود", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbStudentNumber.Text == "")
            {
                MessageBox.Show("شماره دانشجویی باید وارد شود", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string _query = "INSERT INTO Student (StudentNumber,StudentFName,StudentLName,UserID,StudentTel,StudentCel) VALUES ('"+txbStudentNumber.Text.Trim()+"','"+txbName.Text.Trim()+"','"+txbFamilly.Text.Trim()+"',1,'"+txbTell.Text.Trim()+"','"+txbCell.Text.Trim()+"')";
            SqlConnection _sqlCon = new SqlConnection(_CardConnectionString);
            SqlCommand _sqlCommand = new SqlCommand(_query, _sqlCon);
            _sqlCon.Open();
            _sqlCommand.ExecuteNonQuery();
            _sqlCon.Close();
            MessageBox.Show("رکورد جدید با موفقیت اضافه شد ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataSetAndView();
            BindField();
            ShowPosition();
            btnNew.Focus();


            btnNew.Visible = true;
            btnSave.Visible = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            txbName.ReadOnly = true;
            txbFamilly.ReadOnly = true;
            txbStudentNumber.ReadOnly = true;
            txbTell.ReadOnly = true;
            txbCell.ReadOnly = true;

            MoveFirstBT.Enabled = true;
            MoveLastBT.Enabled = true;
            MoveNextBT.Enabled = true;
            MovePreviousBT.Enabled = true;
                        

        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
           
            if (txbName.Text == "")
            {
                MessageBox.Show("نام دانشجو باید وارد شود", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbFamilly.Text == "")
            {
                MessageBox.Show("نام خانوادگی دانشجو باید وارد شود", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbStudentNumber.Text == "")
            {
                MessageBox.Show("شماره دانشجویی باید وارد شود", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string _query = "UPDATE Student SET StudentNumber = '" + txbStudentNumber.Text.Trim() + "',StudentFName = '" + txbName.Text.Trim() + "',StudentLName = '" + txbFamilly.Text.Trim() + "',StudentTel='" + txbTell.Text.Trim() + "',StudentCel='" + txbCell.Text.Trim() + "' WHERE StudentID = " + txbID.Text.Trim();
            SqlConnection _sqlCon = new SqlConnection(_CardConnectionString);
            SqlCommand _sqlCommand = new SqlCommand(_query, _sqlCon);
            _sqlCon.Open();
            _sqlCommand.ExecuteNonQuery();
            _sqlCon.Close();
            MessageBox.Show("رکورد با موفقیت به روز رسانی شد ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataSetAndView();
            BindField();
            ShowPosition();
            btnNew.Focus();


            btnNew.Visible = true;
            btnSave.Visible = false;
            btnEditSave.Visible = false;
            btnEdit.Visible = true;
            btnDelete.Enabled = true;

            txbName.ReadOnly = true;
            txbFamilly.ReadOnly = true;
            txbStudentNumber.ReadOnly = true;
            txbTell.ReadOnly = true;
            txbCell.ReadOnly = true;

            MoveFirstBT.Enabled = true;
            MoveLastBT.Enabled = true;
            MoveNextBT.Enabled = true;
            MovePreviousBT.Enabled = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnSave.Visible = false;

            btnEdit.Visible = false;
            btnEditSave.Visible = true;
            btnDelete.Enabled = false;

            MoveFirstBT.Enabled = false;
            MoveLastBT.Enabled = false;
            MoveNextBT.Enabled = false;
            MovePreviousBT.Enabled = false;
            RecordPositionTB.Text = null;

            txbName.ReadOnly = false;
            txbFamilly.ReadOnly = false;
            txbStudentNumber.ReadOnly = false;
            txbTell.ReadOnly = false;
            txbCell.ReadOnly = false;
            
            txbName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            YesOrNoForm yn = new YesOrNoForm();
            yn.ShowDialog();
            if (Properties.Settings.Default.FormReturn == 0)
                return;
            else
            {
                string _query = "DELETE Student WHERE StudentID = " + txbID.Text.Trim();
                SqlConnection _sqlCon = new SqlConnection(_CardConnectionString);
                SqlCommand _sqlCommand = new SqlCommand(_query, _sqlCon);
                _sqlCon.Open();
                _sqlCommand.ExecuteNonQuery();
                _sqlCon.Close();
                MessageBox.Show("رکورد با موفقیت حذف شد ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataSetAndView();
                BindField();
                ShowPosition();
                btnNew.Focus();

            }           
        }
    }
}