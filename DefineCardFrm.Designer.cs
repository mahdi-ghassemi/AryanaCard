namespace AryanaCard
{
    partial class DefineCardFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineCardFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewBT = new System.Windows.Forms.Button();
            this.ModifyBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.CancelBT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CardRateTB = new ShComponents.ShMaskedTextBox();
            this.CardNumberTB = new ShComponents.ShMaskedTextBox();
            this.CardIDTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchCardTB = new ShComponents.ShMaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBT = new System.Windows.Forms.Button();
            this.MoveFirstBT = new System.Windows.Forms.Button();
            this.MovePreviousBT = new System.Windows.Forms.Button();
            this.MoveNextBT = new System.Windows.Forms.Button();
            this.MoveLastBT = new System.Windows.Forms.Button();
            this.RecordPositionTB = new System.Windows.Forms.TextBox();
            this.DefineCardSStrip = new System.Windows.Forms.StatusStrip();
            this.DefineCardTSSLb = new System.Windows.Forms.ToolStripStatusLabel();
            this.DefineCardTTip = new System.Windows.Forms.ToolTip(this.components);
            this.SaveBT = new System.Windows.Forms.Button();
            this.SaveModifyBT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DefineCardSStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره کارت :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "درصد تخفیف :";
            // 
            // NewBT
            // 
            this.NewBT.AutoSize = true;
            this.NewBT.Location = new System.Drawing.Point(259, 30);
            this.NewBT.Name = "NewBT";
            this.NewBT.Size = new System.Drawing.Size(75, 23);
            this.NewBT.TabIndex = 4;
            this.NewBT.Text = "جدید";
            this.NewBT.UseVisualStyleBackColor = true;
            this.NewBT.Click += new System.EventHandler(this.NewBT_Click);
            // 
            // ModifyBT
            // 
            this.ModifyBT.AutoSize = true;
            this.ModifyBT.Location = new System.Drawing.Point(259, 88);
            this.ModifyBT.Name = "ModifyBT";
            this.ModifyBT.Size = new System.Drawing.Size(75, 23);
            this.ModifyBT.TabIndex = 5;
            this.ModifyBT.Text = "ویرایش";
            this.ModifyBT.UseVisualStyleBackColor = true;
            this.ModifyBT.Click += new System.EventHandler(this.ModifyBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(259, 117);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(75, 23);
            this.DeleteBT.TabIndex = 6;
            this.DeleteBT.Text = "حذف";
            this.DeleteBT.UseVisualStyleBackColor = true;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // CancelBT
            // 
            this.CancelBT.Location = new System.Drawing.Point(259, 146);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.TabIndex = 7;
            this.CancelBT.Text = "انصراف";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CardRateTB);
            this.groupBox1.Controls.Add(this.CardNumberTB);
            this.groupBox1.Controls.Add(this.CardIDTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات کارت";
            // 
            // CardRateTB
            // 
            this.CardRateTB.CustomErrorMessage = "لطفاً فقط عدد وارد نمایید";
            this.CardRateTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.English;
            this.CardRateTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Digit;
            this.CardRateTB.Location = new System.Drawing.Point(83, 54);
            this.CardRateTB.MaxLength = 2;
            this.CardRateTB.Name = "CardRateTB";
            this.CardRateTB.ShowErrorProvider = true;
            this.CardRateTB.ShowToolTipError = true;
            this.CardRateTB.Size = new System.Drawing.Size(32, 21);
            this.CardRateTB.TabIndex = 6;
            // 
            // CardNumberTB
            // 
            this.CardNumberTB.CustomErrorMessage = "لطفاً فقط عدد وارد نمایید";
            this.CardNumberTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.English;
            this.CardNumberTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Digit;
            this.CardNumberTB.Location = new System.Drawing.Point(15, 20);
            this.CardNumberTB.MaxLength = 8;
            this.CardNumberTB.Name = "CardNumberTB";
            this.CardNumberTB.ShowErrorProvider = true;
            this.CardNumberTB.ShowToolTipError = true;
            this.CardNumberTB.Size = new System.Drawing.Size(100, 21);
            this.CardNumberTB.TabIndex = 5;
            // 
            // CardIDTB
            // 
            this.CardIDTB.Location = new System.Drawing.Point(15, 54);
            this.CardIDTB.Name = "CardIDTB";
            this.CardIDTB.Size = new System.Drawing.Size(29, 21);
            this.CardIDTB.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchCardTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SearchBT);
            this.groupBox2.Location = new System.Drawing.Point(36, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجوی کارت";
            // 
            // SearchCardTB
            // 
            this.SearchCardTB.CustomErrorMessage = "لطفاً فقط عدد وارد نمایید";
            this.SearchCardTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.English;
            this.SearchCardTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Digit;
            this.SearchCardTB.Location = new System.Drawing.Point(98, 45);
            this.SearchCardTB.MaxLength = 8;
            this.SearchCardTB.Name = "SearchCardTB";
            this.SearchCardTB.ShowErrorProvider = true;
            this.SearchCardTB.ShowToolTipError = true;
            this.SearchCardTB.Size = new System.Drawing.Size(100, 21);
            this.SearchCardTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "شماره کارت :";
            // 
            // SearchBT
            // 
            this.SearchBT.AutoSize = true;
            this.SearchBT.Location = new System.Drawing.Point(17, 43);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(75, 23);
            this.SearchBT.TabIndex = 5;
            this.SearchBT.Text = "جستجو";
            this.SearchBT.UseVisualStyleBackColor = true;
            this.SearchBT.Click += new System.EventHandler(this.SearchBT_Click);
            // 
            // MoveFirstBT
            // 
            this.MoveFirstBT.AutoSize = true;
            this.MoveFirstBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MoveFirstBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MoveFirstBT.Location = new System.Drawing.Point(38, 146);
            this.MoveFirstBT.Name = "MoveFirstBT";
            this.MoveFirstBT.Size = new System.Drawing.Size(33, 23);
            this.MoveFirstBT.TabIndex = 10;
            this.MoveFirstBT.Text = "|<";
            this.MoveFirstBT.UseVisualStyleBackColor = true;
            this.MoveFirstBT.Click += new System.EventHandler(this.MoveFirstBT_Click);
            // 
            // MovePreviousBT
            // 
            this.MovePreviousBT.AutoSize = true;
            this.MovePreviousBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MovePreviousBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MovePreviousBT.Location = new System.Drawing.Point(77, 146);
            this.MovePreviousBT.Name = "MovePreviousBT";
            this.MovePreviousBT.Size = new System.Drawing.Size(33, 23);
            this.MovePreviousBT.TabIndex = 11;
            this.MovePreviousBT.Text = "<";
            this.MovePreviousBT.UseVisualStyleBackColor = true;
            this.MovePreviousBT.Click += new System.EventHandler(this.MovePreviousBT_Click);
            // 
            // MoveNextBT
            // 
            this.MoveNextBT.AutoSize = true;
            this.MoveNextBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MoveNextBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MoveNextBT.Location = new System.Drawing.Point(179, 148);
            this.MoveNextBT.Name = "MoveNextBT";
            this.MoveNextBT.Size = new System.Drawing.Size(33, 23);
            this.MoveNextBT.TabIndex = 12;
            this.MoveNextBT.Text = ">";
            this.MoveNextBT.UseVisualStyleBackColor = true;
            this.MoveNextBT.Click += new System.EventHandler(this.MoveNextBT_Click);
            // 
            // MoveLastBT
            // 
            this.MoveLastBT.AutoSize = true;
            this.MoveLastBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MoveLastBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MoveLastBT.Location = new System.Drawing.Point(218, 148);
            this.MoveLastBT.Name = "MoveLastBT";
            this.MoveLastBT.Size = new System.Drawing.Size(33, 23);
            this.MoveLastBT.TabIndex = 13;
            this.MoveLastBT.Text = "|>";
            this.MoveLastBT.UseVisualStyleBackColor = true;
            this.MoveLastBT.Click += new System.EventHandler(this.MoveLastBT_Click);
            // 
            // RecordPositionTB
            // 
            this.RecordPositionTB.Location = new System.Drawing.Point(116, 148);
            this.RecordPositionTB.Name = "RecordPositionTB";
            this.RecordPositionTB.Size = new System.Drawing.Size(57, 21);
            this.RecordPositionTB.TabIndex = 14;
            // 
            // DefineCardSStrip
            // 
            this.DefineCardSStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefineCardTSSLb});
            this.DefineCardSStrip.Location = new System.Drawing.Point(0, 300);
            this.DefineCardSStrip.Name = "DefineCardSStrip";
            this.DefineCardSStrip.Size = new System.Drawing.Size(381, 22);
            this.DefineCardSStrip.TabIndex = 15;
            // 
            // DefineCardTSSLb
            // 
            this.DefineCardTSSLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DefineCardTSSLb.Name = "DefineCardTSSLb";
            this.DefineCardTSSLb.Size = new System.Drawing.Size(0, 17);
            // 
            // DefineCardTTip
            // 
            this.DefineCardTTip.AutoPopDelay = 5000;
            this.DefineCardTTip.InitialDelay = 1000;
            this.DefineCardTTip.ReshowDelay = 500;
            this.DefineCardTTip.ShowAlways = true;
            // 
            // SaveBT
            // 
            this.SaveBT.AutoSize = true;
            this.SaveBT.Location = new System.Drawing.Point(259, 59);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(75, 23);
            this.SaveBT.TabIndex = 16;
            this.SaveBT.Text = "ذخیره";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // SaveModifyBT
            // 
            this.SaveModifyBT.AutoSize = true;
            this.SaveModifyBT.Location = new System.Drawing.Point(259, 88);
            this.SaveModifyBT.Name = "SaveModifyBT";
            this.SaveModifyBT.Size = new System.Drawing.Size(75, 23);
            this.SaveModifyBT.TabIndex = 17;
            this.SaveModifyBT.Text = "ذخیره";
            this.SaveModifyBT.UseVisualStyleBackColor = true;
            this.SaveModifyBT.Visible = false;
            this.SaveModifyBT.Click += new System.EventHandler(this.SaveModifyBT_Click);
            // 
            // DefineCardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 322);
            this.Controls.Add(this.SaveModifyBT);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.DefineCardSStrip);
            this.Controls.Add(this.RecordPositionTB);
            this.Controls.Add(this.MoveLastBT);
            this.Controls.Add(this.MoveNextBT);
            this.Controls.Add(this.MovePreviousBT);
            this.Controls.Add(this.MoveFirstBT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.ModifyBT);
            this.Controls.Add(this.NewBT);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DefineCardFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     تعریف کارت   ";
            this.Load += new System.EventHandler(this.DefineCardFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DefineCardSStrip.ResumeLayout(false);
            this.DefineCardSStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewBT;
        private System.Windows.Forms.Button ModifyBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchBT;
        private System.Windows.Forms.Button MoveFirstBT;
        private System.Windows.Forms.Button MovePreviousBT;
        private System.Windows.Forms.Button MoveNextBT;
        private System.Windows.Forms.Button MoveLastBT;
        private System.Windows.Forms.TextBox RecordPositionTB;
        private System.Windows.Forms.StatusStrip DefineCardSStrip;
        private System.Windows.Forms.ToolStripStatusLabel DefineCardTSSLb;
        private System.Windows.Forms.ToolTip DefineCardTTip;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.TextBox CardIDTB;
        private System.Windows.Forms.Button SaveModifyBT;
        private ShComponents.ShMaskedTextBox CardNumberTB;
        private ShComponents.ShMaskedTextBox CardRateTB;
        private ShComponents.ShMaskedTextBox SearchCardTB;
        
    }
}