namespace AryanaCard
{
    partial class SearchStudentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStudentFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.StudentNumberTB = new ShComponents.ShMaskedTextBox();
            this.OKBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره دانشجویی :";
            // 
            // StudentNumberTB
            // 
            this.StudentNumberTB.CustomErrorMessage = "لطفاً فقط عدد وارد نمایید";
            this.StudentNumberTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.Farsi;
            this.StudentNumberTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Digit;
            this.StudentNumberTB.Location = new System.Drawing.Point(114, 29);
            this.StudentNumberTB.MaxLength = 10;
            this.StudentNumberTB.Name = "StudentNumberTB";
            this.StudentNumberTB.ShowErrorProvider = true;
            this.StudentNumberTB.ShowToolTipError = true;
            this.StudentNumberTB.Size = new System.Drawing.Size(100, 21);
            this.StudentNumberTB.TabIndex = 1;
            this.StudentNumberTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StudentNumberTB_KeyDown);
            // 
            // OKBT
            // 
            this.OKBT.Location = new System.Drawing.Point(90, 67);
            this.OKBT.Name = "OKBT";
            this.OKBT.Size = new System.Drawing.Size(75, 23);
            this.OKBT.TabIndex = 2;
            this.OKBT.Text = "تایید";
            this.OKBT.UseVisualStyleBackColor = true;
            this.OKBT.Click += new System.EventHandler(this.OKBT_Click);
            // 
            // SearchStudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 102);
            this.Controls.Add(this.OKBT);
            this.Controls.Add(this.StudentNumberTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchStudentFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ShComponents.ShMaskedTextBox StudentNumberTB;
        private System.Windows.Forms.Button OKBT;
    }
}