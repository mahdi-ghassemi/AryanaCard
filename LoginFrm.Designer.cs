namespace AryanaCard
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.LoginPB = new System.Windows.Forms.PictureBox();
            this.UsernameLb = new System.Windows.Forms.Label();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.CancelBT = new System.Windows.Forms.Button();
            this.OKBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPB)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPB
            // 
            this.LoginPB.Image = global::AryanaCard.Properties.Resources.Login;
            this.LoginPB.Location = new System.Drawing.Point(300, 12);
            this.LoginPB.Name = "LoginPB";
            this.LoginPB.Size = new System.Drawing.Size(76, 101);
            this.LoginPB.TabIndex = 0;
            this.LoginPB.TabStop = false;
            // 
            // UsernameLb
            // 
            this.UsernameLb.AutoSize = true;
            this.UsernameLb.Location = new System.Drawing.Point(24, 28);
            this.UsernameLb.Name = "UsernameLb";
            this.UsernameLb.Size = new System.Drawing.Size(60, 13);
            this.UsernameLb.TabIndex = 5;
            this.UsernameLb.Text = "نام کاربری :";
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.Location = new System.Drawing.Point(24, 68);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(59, 13);
            this.PasswordLB.TabIndex = 6;
            this.PasswordLB.Text = "کلمه عبور :";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(105, 25);
            this.UsernameTB.MaxLength = 20;
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(154, 21);
            this.UsernameTB.TabIndex = 1;
            this.UsernameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameTB_KeyDown);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(105, 65);
            this.PasswordTB.MaxLength = 20;
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(154, 21);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTB_KeyDown);
            // 
            // CancelBT
            // 
            this.CancelBT.Location = new System.Drawing.Point(27, 120);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.TabIndex = 3;
            this.CancelBT.Text = "انصراف";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // OKBT
            // 
            this.OKBT.Location = new System.Drawing.Point(184, 120);
            this.OKBT.Name = "OKBT";
            this.OKBT.Size = new System.Drawing.Size(75, 23);
            this.OKBT.TabIndex = 4;
            this.OKBT.Text = "تایید";
            this.OKBT.UseVisualStyleBackColor = true;
            this.OKBT.Click += new System.EventHandler(this.OKBT_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 155);
            this.Controls.Add(this.OKBT);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.PasswordLB);
            this.Controls.Add(this.UsernameLb);
            this.Controls.Add(this.LoginPB);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ورود به سیستم ";
            ((System.ComponentModel.ISupportInitialize)(this.LoginPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginPB;
        private System.Windows.Forms.Label UsernameLb;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button OKBT;
    }
}