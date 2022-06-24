namespace AryanaCard
{
    partial class AllSalesCardReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllSalesCardReport));
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTotalCard = new System.Windows.Forms.TextBox();
            this.txbTotalCost = new System.Windows.Forms.TextBox();
            this.txbNoTasvie = new System.Windows.Forms.TextBox();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEX1
            // 
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEXLayout1;
            this.gridEX1.Location = new System.Drawing.Point(12, 12);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.SaveSettings = false;
            this.gridEX1.Size = new System.Drawing.Size(766, 322);
            this.gridEX1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "تعداد کل کارتهای فروخته شده :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "مبلغ کل کارتهای فروخته شده :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "کارتهای فروخته شده تسویه نشده :";
            // 
            // txbTotalCard
            // 
            this.txbTotalCard.Location = new System.Drawing.Point(208, 348);
            this.txbTotalCard.Name = "txbTotalCard";
            this.txbTotalCard.ReadOnly = true;
            this.txbTotalCard.Size = new System.Drawing.Size(100, 22);
            this.txbTotalCard.TabIndex = 4;
            // 
            // txbTotalCost
            // 
            this.txbTotalCost.Location = new System.Drawing.Point(208, 379);
            this.txbTotalCost.Name = "txbTotalCost";
            this.txbTotalCost.ReadOnly = true;
            this.txbTotalCost.Size = new System.Drawing.Size(100, 22);
            this.txbTotalCost.TabIndex = 5;
            // 
            // txbNoTasvie
            // 
            this.txbNoTasvie.Location = new System.Drawing.Point(606, 348);
            this.txbNoTasvie.Name = "txbNoTasvie";
            this.txbNoTasvie.ReadOnly = true;
            this.txbNoTasvie.Size = new System.Drawing.Size(100, 22);
            this.txbNoTasvie.TabIndex = 6;
            // 
            // stiReport1
            // 
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "011617be7e974f17bd7f79c51d52b30c";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(703, 382);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // AllSalesCardReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(818, 414);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txbNoTasvie);
            this.Controls.Add(this.txbTotalCost);
            this.Controls.Add(this.txbTotalCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridEX1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AllSalesCardReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش کل کارتهای فروخته شده";
            this.Load += new System.EventHandler(this.AllSalesCardReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTotalCard;
        private System.Windows.Forms.TextBox txbTotalCost;
        private System.Windows.Forms.TextBox txbNoTasvie;
        private Stimulsoft.Report.StiReport stiReport1;
        private System.Windows.Forms.Button btnPrint;

    }
}