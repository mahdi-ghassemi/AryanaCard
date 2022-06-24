namespace AryanaCard
{
    partial class ReturnCardFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnCardFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.SaleNumberTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SalesDateTB = new ShComponents.ShMaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentNumberTB = new ShComponents.ShMaskedTextBox();
            this.StudentIDTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentFamilyTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CardNumberTB = new ShComponents.ShMaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FeeTB = new ShComponents.ShMaskedTextBox();
            this.ExitBT = new System.Windows.Forms.Button();
            this.SaveBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره فروش : ";
            // 
            // SaleNumberTB
            // 
            this.SaleNumberTB.Location = new System.Drawing.Point(112, 27);
            this.SaleNumberTB.Name = "SaleNumberTB";
            this.SaleNumberTB.ReadOnly = true;
            this.SaleNumberTB.Size = new System.Drawing.Size(100, 21);
            this.SaleNumberTB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "تاریخ :";
            // 
            // SalesDateTB
            // 
            this.SalesDateTB.CustomErrorMessage = "لطفاً تاریخ را صحیح وارد نمایید";
            this.SalesDateTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.English;
            this.SalesDateTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Date;
            this.SalesDateTB.Location = new System.Drawing.Point(304, 27);
            this.SalesDateTB.MaxLength = 10;
            this.SalesDateTB.Name = "SalesDateTB";
            this.SalesDateTB.ReadOnly = true;
            this.SalesDateTB.ShowErrorProvider = true;
            this.SalesDateTB.ShowToolTipError = true;
            this.SalesDateTB.Size = new System.Drawing.Size(100, 21);
            this.SalesDateTB.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "شماره دانشجویی :";
            // 
            // StudentNumberTB
            // 
            this.StudentNumberTB.CustomErrorMessage = "لطفاً فقط عدد وارد نمایید";
            this.StudentNumberTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.English;
            this.StudentNumberTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Digit;
            this.StudentNumberTB.Location = new System.Drawing.Point(112, 58);
            this.StudentNumberTB.MaxLength = 20;
            this.StudentNumberTB.Name = "StudentNumberTB";
            this.StudentNumberTB.ReadOnly = true;
            this.StudentNumberTB.ShowErrorProvider = true;
            this.StudentNumberTB.ShowToolTipError = true;
            this.StudentNumberTB.Size = new System.Drawing.Size(100, 21);
            this.StudentNumberTB.TabIndex = 28;
            // 
            // StudentIDTb
            // 
            this.StudentIDTb.Location = new System.Drawing.Point(218, 58);
            this.StudentIDTb.Name = "StudentIDTb";
            this.StudentIDTb.Size = new System.Drawing.Size(51, 21);
            this.StudentIDTb.TabIndex = 32;
            this.StudentIDTb.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "نام : ";
            // 
            // StudentNameTB
            // 
            this.StudentNameTB.Location = new System.Drawing.Point(112, 90);
            this.StudentNameTB.Name = "StudentNameTB";
            this.StudentNameTB.ReadOnly = true;
            this.StudentNameTB.Size = new System.Drawing.Size(100, 21);
            this.StudentNameTB.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "نام خانوادگی :";
            // 
            // StudentFamilyTB
            // 
            this.StudentFamilyTB.Location = new System.Drawing.Point(304, 90);
            this.StudentFamilyTB.Name = "StudentFamilyTB";
            this.StudentFamilyTB.ReadOnly = true;
            this.StudentFamilyTB.Size = new System.Drawing.Size(100, 21);
            this.StudentFamilyTB.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "شماره کارت :";
            // 
            // CardNumberTB
            // 
            this.CardNumberTB.CustomErrorMessage = "لطفاً فقط عدد وارد نمایید";
            this.CardNumberTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.English;
            this.CardNumberTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Digit;
            this.CardNumberTB.Location = new System.Drawing.Point(112, 120);
            this.CardNumberTB.MaxLength = 20;
            this.CardNumberTB.Name = "CardNumberTB";
            this.CardNumberTB.ReadOnly = true;
            this.CardNumberTB.ShowErrorProvider = true;
            this.CardNumberTB.ShowToolTipError = true;
            this.CardNumberTB.Size = new System.Drawing.Size(100, 21);
            this.CardNumberTB.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "مبلغ :";
            // 
            // FeeTB
            // 
            this.FeeTB.CustomErrorMessage = "لطفاً فقط عدد وارد نمایید";
            this.FeeTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.English;
            this.FeeTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Digit;
            this.FeeTB.Location = new System.Drawing.Point(112, 155);
            this.FeeTB.MaxLength = 20;
            this.FeeTB.Name = "FeeTB";
            this.FeeTB.ReadOnly = true;
            this.FeeTB.ShowErrorProvider = true;
            this.FeeTB.ShowToolTipError = true;
            this.FeeTB.Size = new System.Drawing.Size(100, 21);
            this.FeeTB.TabIndex = 40;
            // 
            // ExitBT
            // 
            this.ExitBT.Location = new System.Drawing.Point(248, 200);
            this.ExitBT.Name = "ExitBT";
            this.ExitBT.Size = new System.Drawing.Size(75, 23);
            this.ExitBT.TabIndex = 41;
            this.ExitBT.Text = "انصراف";
            this.ExitBT.UseVisualStyleBackColor = true;
            this.ExitBT.Click += new System.EventHandler(this.ExitBT_Click);
            // 
            // SaveBT
            // 
            this.SaveBT.Location = new System.Drawing.Point(329, 200);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(75, 23);
            this.SaveBT.TabIndex = 42;
            this.SaveBT.Text = "ذخیره";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // ReturnCardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 235);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.ExitBT);
            this.Controls.Add(this.FeeTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CardNumberTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StudentFamilyTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StudentNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StudentIDTb);
            this.Controls.Add(this.StudentNumberTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SalesDateTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaleNumberTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReturnCardFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برگشت کارت";
            this.Load += new System.EventHandler(this.ReturnCardFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SaleNumberTB;
        private System.Windows.Forms.Label label2;
        private ShComponents.ShMaskedTextBox SalesDateTB;
        private System.Windows.Forms.Label label3;
        private ShComponents.ShMaskedTextBox StudentNumberTB;
        private System.Windows.Forms.TextBox StudentIDTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StudentNameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StudentFamilyTB;
        private System.Windows.Forms.Label label6;
        private ShComponents.ShMaskedTextBox CardNumberTB;
        private System.Windows.Forms.Label label7;
        private ShComponents.ShMaskedTextBox FeeTB;
        private System.Windows.Forms.Button ExitBT;
        private System.Windows.Forms.Button SaveBT;
    }
}