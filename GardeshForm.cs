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
    public partial class GardeshForm : Form
    {
        public static string _ConnectionString = Properties.Settings.Default.AryanaCardConnectionString;
                
        SqlConnection objConnection;
        SqlDataAdapter objDataAdapter;
        DataSet objDataSet;
        DataView objDataView;

        public GardeshForm()
        {            
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "SELECT c.CardStatus ,CONVERT(bigint,ca.Cost) as Cost , ca.AssignID ,c.CardNumber ,s.StudentNumber , s.StudentLName ,s.StudentFName ,s.StudentTel  ,s.StudentCel FROM CardAssign as ca JOIN Cards as c ON c.CardID = ca.CardID JOIN Student as s ON s.StudentID = ca.StudentID WHERE c.CardNumber = '" + txbCardNumber.Text.Trim() + "'";
                objConnection = new SqlConnection(_ConnectionString);
                objDataAdapter = new SqlDataAdapter(Query, objConnection);
                objDataAdapter = new SqlDataAdapter(Query, objConnection);
                objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet, "Report");
                objDataView = new DataView(objDataSet.Tables["Report"]);

                if (objDataSet.Tables["Report"].Rows.Count == 0)
                {
                    btnPrint.Enabled = false;
                    MessageBox.Show("گردشی برای کارت فوق وجود ندارد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbCardNumber.Text = "";
                    txbCardNumber.Focus();
                    return;
                }

                gridEX1.DataSource = null;
                gridEX1.SetDataBinding(objDataView, "");
                btnPrint.Enabled = true;
                for (int i = 0; i < gridEX1.RowCount; i++)
                {
                    if (gridEX1.GetRow(i).Cells[5].Value.ToString() == "2")
                    {
                        gridEX1.Row = i;
                        gridEX1.SetValue(5, "فروخته شده");

                    }
                    else if (gridEX1.GetRow(i).Cells[5].Value.ToString() == "1")
                    {
                        gridEX1.Row = i;
                        gridEX1.SetValue(5, "آزاد");
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("برقراری ارتباط با بانک اطلاعاتی مقدور نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }                  

        }

        private void txbCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {            
                stiReport1.Load(Application.StartupPath + "\\onecard.mrt");
                stiReport1.Compile();
                stiReport1["CardNumber"] = txbCardNumber.Text.Trim();
                stiReport1.RegData(objDataSet);
                stiReport1.Show();
        }
    }
}