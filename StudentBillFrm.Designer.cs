namespace AryanaCard
{
    partial class StudentBillFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentBillFrm));
            Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new Janus.Windows.GridEX.GridEXLayout();
            this.ReportTitleLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalFeeTB = new System.Windows.Forms.TextBox();
            this.TasviehBT = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportTitleLB
            // 
            this.ReportTitleLB.AutoSize = true;
            this.ReportTitleLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReportTitleLB.Location = new System.Drawing.Point(33, 25);
            this.ReportTitleLB.Name = "ReportTitleLB";
            this.ReportTitleLB.Size = new System.Drawing.Size(109, 13);
            this.ReportTitleLB.TabIndex = 0;
            this.ReportTitleLB.Text = "صورت حساب دانشجو ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(41, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "جمع کل مبالغ : ";
            // 
            // TotalFeeTB
            // 
            this.TotalFeeTB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalFeeTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalFeeTB.Location = new System.Drawing.Point(125, 254);
            this.TotalFeeTB.Name = "TotalFeeTB";
            this.TotalFeeTB.ReadOnly = true;
            this.TotalFeeTB.Size = new System.Drawing.Size(100, 21);
            this.TotalFeeTB.TabIndex = 4;
            // 
            // TasviehBT
            // 
            this.TasviehBT.Location = new System.Drawing.Point(491, 252);
            this.TasviehBT.Name = "TasviehBT";
            this.TasviehBT.Size = new System.Drawing.Size(75, 23);
            this.TasviehBT.TabIndex = 6;
            this.TasviehBT.Text = "تسویه";
            this.TasviehBT.UseVisualStyleBackColor = true;
            this.TasviehBT.Click += new System.EventHandler(this.TasviehBT_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(394, 252);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.stiReport1.ReportGuid = "82997016a0854423881c0fa2469c2138";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // gridEX1
            // 
            gridEXLayout2.LayoutString = resources.GetString("gridEXLayout2.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEXLayout2;
            this.gridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridEX1.Location = new System.Drawing.Point(12, 50);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.SaveSettings = false;
            this.gridEX1.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.gridEX1.SettingsKey = "gridEX1";
            this.gridEX1.Size = new System.Drawing.Size(550, 183);
            this.gridEX1.TabIndex = 8;
            this.gridEX1.RowCheckStateChanged += new Janus.Windows.GridEX.RowCheckStateChangeEventHandler(this.gridEX1_RowCheckStateChanged);
            // 
            // StudentBillFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 287);
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.TasviehBT);
            this.Controls.Add(this.TotalFeeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportTitleLB);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentBillFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش صورت حساب دانشجو";
            this.Load += new System.EventHandler(this.StudentBillFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReportTitleLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalFeeTB;
        private System.Windows.Forms.Button TasviehBT;
        private System.Windows.Forms.Button btnPrint;
        private Stimulsoft.Report.StiReport stiReport1;
        private Janus.Windows.GridEX.GridEX gridEX1;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource1;
    }
}