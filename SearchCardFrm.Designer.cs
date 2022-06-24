namespace AryanaCard
{
    partial class SearchCardFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCardFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.CardNumberTB = new ShComponents.ShMaskedTextBox();
            this.OKBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "لطفاً شماره کارت را وارد نمایید:";
            // 
            // CardNumberTB
            // 
            this.CardNumberTB.CustomErrorMessage = "لطفاً فقط عدد وارد نمایید";
            this.CardNumberTB.ErrorTextLanguage = ShComponents.ShMaskedTextBox._Language.Farsi;
            this.CardNumberTB.InputData = ShComponents.ShMaskedTextBox.EInputData.Digit;
            this.CardNumberTB.Location = new System.Drawing.Point(171, 26);
            this.CardNumberTB.MaxLength = 8;
            this.CardNumberTB.Name = "CardNumberTB";
            this.CardNumberTB.ShowErrorProvider = true;
            this.CardNumberTB.ShowToolTipError = true;
            this.CardNumberTB.Size = new System.Drawing.Size(100, 20);
            this.CardNumberTB.TabIndex = 1;
            // 
            // OKBT
            // 
            this.OKBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OKBT.Location = new System.Drawing.Point(111, 67);
            this.OKBT.Name = "OKBT";
            this.OKBT.Size = new System.Drawing.Size(75, 23);
            this.OKBT.TabIndex = 2;
            this.OKBT.Text = "تایید";
            this.OKBT.UseVisualStyleBackColor = true;
            this.OKBT.Click += new System.EventHandler(this.OKBT_Click);
            // 
            // SearchCardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 102);
            this.Controls.Add(this.OKBT);
            this.Controls.Add(this.CardNumberTB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchCardFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ShComponents.ShMaskedTextBox CardNumberTB;
        private System.Windows.Forms.Button OKBT;
    }
}