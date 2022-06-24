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
    public partial class AllSalesCardReport : Form
    {
        public static string _ConnectionString = Properties.Settings.Default.AryanaCardConnectionString;
        public string Query = "SELECT c.CardStatus ,CONVERT(bigint,ca.Cost) as Cost , ca.AssignID ,c.CardNumber ,s.StudentNumber , s.StudentLName ,s.StudentFName ,s.StudentTel  ,s.StudentCel FROM CardAssign as ca JOIN Cards as c ON c.CardID = ca.CardID JOIN Student as s ON s.StudentID = ca.StudentID";

        SqlConnection objConnection;
        SqlDataAdapter objDataAdapter;
        DataSet objDataSet;
        DataView objDataView;

        public AllSalesCardReport()
        {
            objConnection = new SqlConnection(_ConnectionString);
            objDataAdapter = new SqlDataAdapter(Query, objConnection);
            InitializeComponent();
        }

        private void AllSalesCardReport_Load(object sender, EventArgs e)
        {
            try
            {
                objDataAdapter = new SqlDataAdapter(Query, objConnection);
                objDataSet = new DataSet();
                objDataAdapter.Fill(objDataSet, "Report");
                objDataView = new DataView(objDataSet.Tables["Report"]);
                gridEX1.SetDataBinding(objDataView, "");

                int _notTasvie = 0;
                for (int i = 0; i < gridEX1.RowCount; i++)
                {
                    if (gridEX1.GetRow(i).Cells[6].Value.ToString() == "2")
                    {
                        gridEX1.Row = i;
                        gridEX1.SetValue(6, "فروخته شده");
                        _notTasvie++;

                    }
                    else if (gridEX1.GetRow(i).Cells[6].Value.ToString() == "1")
                    {
                        gridEX1.Row = i;
                        gridEX1.SetValue(6, "آزاد");
                    }
                }

                txbTotalCard.Text = gridEX1.RowCount.ToString();
                txbTotalCost.DataBindings.Clear();
                txbTotalCost.Text = objDataView.Table.Compute("SUM(Cost)", String.Empty).ToString();
                txbNoTasvie.Text = _notTasvie.ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("برقراری ارتباط با بانک اطلاعاتی مقدور نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }         
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            stiReport1.Load(Application.StartupPath + "\\allcards.mrt");
            stiReport1.Compile();
            stiReport1["TotalCard"] = txbTotalCard.Text.Trim();
            stiReport1["TotalCost"] = txbTotalCost.Text.Trim();
            stiReport1["NoTasvieh"] = txbNoTasvie.Text.Trim();
            stiReport1.RegData(objDataSet);
            stiReport1.Show();
        }
    }
}