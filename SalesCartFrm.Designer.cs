namespace AryanaCard
{
    partial class SalesCartFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesCartFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SaleNumberTB = new System.Windows.Forms.TextBox();
            this.StudentNameTB = new System.Windows.Forms.TextBox();
            this.StudentFamilyTB = new System.Windows.Forms.TextBox();
            this.NewBT = new System.Windows.Forms.Button();
            this.ModifyBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.ExitBT = new System.Windows.Forms.Button();
            this.SaveBT = new System.Windows.Forms.Button();
            this.SaveModifyBT = new System.Windows.Forms.Button();
            this.StudentNumberTB = new ShComponents.ShMaskedTextBox();
            this.CardNumberTB = new ShComponents.ShMaskedTextBox();
            this.FeeTB = new ShComponents.ShMaskedTextBox();
            this.SalesDateTB = new ShComponents.ShMaskedTextBox();
            this.MoveFirstBT = new System.Windows.Forms.Button();
            this.MovePreviousBT = new System.Windows.Forms.Button();
            this.RecordPositionTB = new System.Windows.Forms.TextBox();
            this.MoveNextBT = new System.Windows.Forms.Button();
            this.MoveLastBT = new System.Windows.Forms.Button();
            this.StudentIDTb = new System.Windows.Forms.TextBox();
            this.TellSabetTB = new System.Windows.Forms.TextBox();
            this.TellHamrahTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره فروش : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاریخ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "شماره دانشجویی :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "نام : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "نام خانوادگی :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "شماره کارت :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "مبلغ :";
            // 
            // SaleNumberTB
            // 
            this.SaleNumberTB.Location = new System.Drawing.Point(132, 33);
            this.SaleNumberTB.Name = "SaleNumberTB";
            this.SaleNumberTB.ReadOnly = true;
            this.SaleNumberTB.Size = new System.Drawing.Size(100, 21);
            this.SaleNumberTB.TabIndex = 7;
            // 
            // StudentNameTB
            // 
            this.StudentNameTB.Location = new System.Drawing.Point(132, 113);
            this.StudentNameTB.Name = "StudentNameTB";
            this.StudentNameTB.ReadOnly = true;
            this.StudentNameTB.Size = new System.Drawing.Size(100, 21);
            this.StudentNameTB.TabIndex = 10;
            // 
            // StudentFamilyTB
            // 
            this.StudentFamilyTB.Location = new System.Drawing.Point(342, 113);
            this.StudentFamilyTB.Name = "StudentFamilyTB";
            this.StudentFamilyTB.ReadOnly = true;
            this.StudentFamilyTB.Size = new System.Drawing.Size(100, 21);
            this.StudentFamilyTB.TabIndex = 11;
            // 
            // NewBT
            // 
            this.NewBT.Location = new System.Drawing.Point(12, 298);
            this.NewBT.Name = "NewBT";
            this.NewBT.Size = new System.Drawing.Size(75, 23);
            this.NewBT.TabIndex = 14;
            this.NewBT.Text = "جدید";
            this.NewBT.UseVisualStyleBackColor = true;
            this.NewBT.Click += new System.EventHandler(this.NewBT_Click);
            // 
            // ModifyBT
            // 
            this.ModifyBT.Location = new System.Drawing.Point(180, 298);
            this.ModifyBT.Name = "ModifyBT";
            this.ModifyBT.Size = new System.Drawing.Size(75, 23);
            this.ModifyBT.TabIndex = 15;
            this.ModifyBT.Text = "اصلاح";
            this.ModifyBT.UseVisualStyleBackColor = true;
            this.ModifyBT.Click += new System.EventHandler(this.ModifyBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(261, 298);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(75, 23);
            this.DeleteBT.TabIndex = 16;
            this.DeleteBT.Text = "حذف";
            this.DeleteBT.UseVisualStyleBackColor = true;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // ExitBT
            // 
            this.ExitBT.Location = new System.Drawing.Point(342, 298);
            this.ExitBT.Name = "ExitBT";
            this.ExitBT.Size = new System.Drawing.Size(75, 23);
            this.ExitBT.TabIndex = 19;
            this.ExitBT.Text = "انصراف";
            this.ExitBT.UseVisualStyleBackColor = true;
            this.ExitBT.Click += new System.EventHandler(this.ExitBT_Click);
            // 
            // SaveBT
            // 
            this.SaveBT.Enabled = false;
            this.SaveBT.Location = new System.Drawing.Point(93, 298);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(75, 23);
            this.SaveBT.TabIndex = 20;
            this.SaveBT.Text = "ذخیره";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // SaveModifyBT
            // 
            this.SaveModifyBT.Enabled = false;
            this.SaveModifyBT.Location = new System.Drawing.Point(180, 298);
            this.SaveModifyBT.Name = "SaveModifyBT";
            this.SaveModifyBT.Size = new System.Drawing.Size(75, 23);
            this.SaveModifyBT.TabIndex = 21;
            this.SaveModifyBT.Text = "ذخیره";
            this.SaveModifyBT.UseVisualStyleBackColor = true;
            this.SaveModifyBT.Visible = false;
            this.SaveModifyBT.Click += new System.EventHandler(this.SaveModifyBT_Click);
            // 
            // StudentNumberTB
            // 
            this.StudentNumberTB.CustomErrorMessage = "لطفاً فقط عدد وارد نمایید";
            this.StudentNumberTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.English;
            this.StudentNumberTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Digit;
            this.StudentNumberTB.Location = new System.Drawing.Point(132, 74);
            this.StudentNumberTB.MaxLength = 20;
            this.StudentNumberTB.Name = "StudentNumberTB";
            this.StudentNumberTB.ReadOnly = true;
            this.StudentNumberTB.ShowErrorProvider = true;
            this.StudentNumberTB.ShowToolTipError = true;
            this.StudentNumberTB.Size = new System.Drawing.Size(100, 21);
            this.StudentNumberTB.TabIndex = 22;
            this.StudentNumberTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StudentNumberTB_KeyDown);
            // 
            // CardNumberTB
            // 
            this.CardNumberTB.CustomErrorMessage = "لطفاً فقط عدد وارد نمایید";
            this.CardNumberTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.English;
            this.CardNumberTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Digit;
            this.CardNumberTB.Location = new System.Drawing.Point(132, 152);
            this.CardNumberTB.MaxLength = 8;
            this.CardNumberTB.Name = "CardNumberTB";
            this.CardNumberTB.ReadOnly = true;
            this.CardNumberTB.ShowErrorProvider = true;
            this.CardNumberTB.ShowToolTipError = true;
            this.CardNumberTB.Size = new System.Drawing.Size(100, 21);
            this.CardNumberTB.TabIndex = 23;
            // 
            // FeeTB
            // 
            this.FeeTB.CustomErrorMessage = "لطفاً فقط عدد وارد نمایید";
            this.FeeTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.English;
            this.FeeTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Digit;
            this.FeeTB.Location = new System.Drawing.Point(132, 197);
            this.FeeTB.MaxLength = 20;
            this.FeeTB.Name = "FeeTB";
            this.FeeTB.ReadOnly = true;
            this.FeeTB.ShowErrorProvider = true;
            this.FeeTB.ShowToolTipError = true;
            this.FeeTB.Size = new System.Drawing.Size(100, 21);
            this.FeeTB.TabIndex = 24;
            // 
            // SalesDateTB
            // 
            this.SalesDateTB.CustomErrorMessage = "لطفاً تاریخ را صحیح وارد نمایید";
            this.SalesDateTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.English;
            this.SalesDateTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Date;
            this.SalesDateTB.Location = new System.Drawing.Point(342, 33);
            this.SalesDateTB.MaxLength = 10;
            this.SalesDateTB.Name = "SalesDateTB";
            this.SalesDateTB.ReadOnly = true;
            this.SalesDateTB.ShowErrorProvider = true;
            this.SalesDateTB.ShowToolTipError = true;
            this.SalesDateTB.Size = new System.Drawing.Size(100, 21);
            this.SalesDateTB.TabIndex = 25;
            // 
            // MoveFirstBT
            // 
            this.MoveFirstBT.AutoSize = true;
            this.MoveFirstBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MoveFirstBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MoveFirstBT.Location = new System.Drawing.Point(93, 269);
            this.MoveFirstBT.Name = "MoveFirstBT";
            this.MoveFirstBT.Size = new System.Drawing.Size(33, 23);
            this.MoveFirstBT.TabIndex = 26;
            this.MoveFirstBT.Text = "|<";
            this.MoveFirstBT.UseVisualStyleBackColor = true;
            this.MoveFirstBT.Click += new System.EventHandler(this.MoveFirstBT_Click);
            // 
            // MovePreviousBT
            // 
            this.MovePreviousBT.AutoSize = true;
            this.MovePreviousBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MovePreviousBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MovePreviousBT.Location = new System.Drawing.Point(132, 269);
            this.MovePreviousBT.Name = "MovePreviousBT";
            this.MovePreviousBT.Size = new System.Drawing.Size(33, 23);
            this.MovePreviousBT.TabIndex = 27;
            this.MovePreviousBT.Text = "<";
            this.MovePreviousBT.UseVisualStyleBackColor = true;
            this.MovePreviousBT.Click += new System.EventHandler(this.MovePreviousBT_Click);
            // 
            // RecordPositionTB
            // 
            this.RecordPositionTB.Location = new System.Drawing.Point(171, 269);
            this.RecordPositionTB.Name = "RecordPositionTB";
            this.RecordPositionTB.Size = new System.Drawing.Size(57, 21);
            this.RecordPositionTB.TabIndex = 28;
            // 
            // MoveNextBT
            // 
            this.MoveNextBT.AutoSize = true;
            this.MoveNextBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MoveNextBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MoveNextBT.Location = new System.Drawing.Point(234, 267);
            this.MoveNextBT.Name = "MoveNextBT";
            this.MoveNextBT.Size = new System.Drawing.Size(33, 23);
            this.MoveNextBT.TabIndex = 29;
            this.MoveNextBT.Text = ">";
            this.MoveNextBT.UseVisualStyleBackColor = true;
            this.MoveNextBT.Click += new System.EventHandler(this.MoveNextBT_Click);
            // 
            // MoveLastBT
            // 
            this.MoveLastBT.AutoSize = true;
            this.MoveLastBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MoveLastBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MoveLastBT.Location = new System.Drawing.Point(273, 267);
            this.MoveLastBT.Name = "MoveLastBT";
            this.MoveLastBT.Size = new System.Drawing.Size(33, 23);
            this.MoveLastBT.TabIndex = 30;
            this.MoveLastBT.Text = "|>";
            this.MoveLastBT.UseVisualStyleBackColor = true;
            this.MoveLastBT.Click += new System.EventHandler(this.MoveLastBT_Click);
            // 
            // StudentIDTb
            // 
            this.StudentIDTb.Location = new System.Drawing.Point(238, 74);
            this.StudentIDTb.Name = "StudentIDTb";
            this.StudentIDTb.Size = new System.Drawing.Size(51, 21);
            this.StudentIDTb.TabIndex = 31;
            this.StudentIDTb.Visible = false;
            // 
            // TellSabetTB
            // 
            this.TellSabetTB.Location = new System.Drawing.Point(304, 74);
            this.TellSabetTB.Name = "TellSabetTB";
            this.TellSabetTB.Size = new System.Drawing.Size(65, 21);
            this.TellSabetTB.TabIndex = 33;
            this.TellSabetTB.Visible = false;
            // 
            // TellHamrahTB
            // 
            this.TellHamrahTB.Location = new System.Drawing.Point(375, 74);
            this.TellHamrahTB.Name = "TellHamrahTB";
            this.TellHamrahTB.Size = new System.Drawing.Size(65, 21);
            this.TellHamrahTB.TabIndex = 34;
            this.TellHamrahTB.Visible = false;
            // 
            // SalesCartFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 333);
            this.Controls.Add(this.TellHamrahTB);
            this.Controls.Add(this.TellSabetTB);
            this.Controls.Add(this.StudentIDTb);
            this.Controls.Add(this.MoveLastBT);
            this.Controls.Add(this.MoveNextBT);
            this.Controls.Add(this.RecordPositionTB);
            this.Controls.Add(this.MovePreviousBT);
            this.Controls.Add(this.MoveFirstBT);
            this.Controls.Add(this.SalesDateTB);
            this.Controls.Add(this.FeeTB);
            this.Controls.Add(this.CardNumberTB);
            this.Controls.Add(this.StudentNumberTB);
            this.Controls.Add(this.SaveModifyBT);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.ExitBT);
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.ModifyBT);
            this.Controls.Add(this.NewBT);
            this.Controls.Add(this.StudentFamilyTB);
            this.Controls.Add(this.StudentNameTB);
            this.Controls.Add(this.SaleNumberTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SalesCartFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فروش کارت";
            this.Load += new System.EventHandler(this.SalesCartFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SaleNumberTB;
        private System.Windows.Forms.TextBox StudentNameTB;
        private System.Windows.Forms.TextBox StudentFamilyTB;
        private System.Windows.Forms.Button NewBT;
        private System.Windows.Forms.Button ModifyBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.Button ExitBT;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.Button SaveModifyBT;
        private ShComponents.ShMaskedTextBox StudentNumberTB;
        private ShComponents.ShMaskedTextBox CardNumberTB;
        private ShComponents.ShMaskedTextBox FeeTB;
        private ShComponents.ShMaskedTextBox SalesDateTB;
        private System.Windows.Forms.Button MoveFirstBT;
        private System.Windows.Forms.Button MovePreviousBT;
        private System.Windows.Forms.TextBox RecordPositionTB;
        private System.Windows.Forms.Button MoveNextBT;
        private System.Windows.Forms.Button MoveLastBT;
        private System.Windows.Forms.TextBox StudentIDTb;
        private System.Windows.Forms.TextBox TellSabetTB;
        private System.Windows.Forms.TextBox TellHamrahTB;
    }
}