namespace AryanaCard
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbFamilly = new System.Windows.Forms.TextBox();
            this.txbStudentNumber = new System.Windows.Forms.TextBox();
            this.txbTell = new System.Windows.Forms.TextBox();
            this.txbCell = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.MoveFirstBT = new System.Windows.Forms.Button();
            this.MovePreviousBT = new System.Windows.Forms.Button();
            this.RecordPositionTB = new System.Windows.Forms.TextBox();
            this.MoveNextBT = new System.Windows.Forms.Button();
            this.MoveLastBT = new System.Windows.Forms.Button();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "شماره دانشجویی :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "شماره تماس ثابت :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "شماره تماس همراه :";
            // 
            // txbName
            // 
            this.txbName.ForeColor = System.Drawing.Color.Black;
            this.txbName.Location = new System.Drawing.Point(144, 23);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(100, 21);
            this.txbName.TabIndex = 5;
            // 
            // txbFamilly
            // 
            this.txbFamilly.ForeColor = System.Drawing.Color.Black;
            this.txbFamilly.Location = new System.Drawing.Point(144, 57);
            this.txbFamilly.Name = "txbFamilly";
            this.txbFamilly.ReadOnly = true;
            this.txbFamilly.Size = new System.Drawing.Size(100, 21);
            this.txbFamilly.TabIndex = 6;
            // 
            // txbStudentNumber
            // 
            this.txbStudentNumber.ForeColor = System.Drawing.Color.Black;
            this.txbStudentNumber.Location = new System.Drawing.Point(144, 90);
            this.txbStudentNumber.Name = "txbStudentNumber";
            this.txbStudentNumber.ReadOnly = true;
            this.txbStudentNumber.Size = new System.Drawing.Size(100, 21);
            this.txbStudentNumber.TabIndex = 7;
            // 
            // txbTell
            // 
            this.txbTell.ForeColor = System.Drawing.Color.Black;
            this.txbTell.Location = new System.Drawing.Point(144, 122);
            this.txbTell.Name = "txbTell";
            this.txbTell.ReadOnly = true;
            this.txbTell.Size = new System.Drawing.Size(100, 21);
            this.txbTell.TabIndex = 8;
            // 
            // txbCell
            // 
            this.txbCell.ForeColor = System.Drawing.Color.Black;
            this.txbCell.Location = new System.Drawing.Point(144, 155);
            this.txbCell.Name = "txbCell";
            this.txbCell.ReadOnly = true;
            this.txbCell.Size = new System.Drawing.Size(100, 21);
            this.txbCell.TabIndex = 9;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 218);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(96, 218);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "اصلاح";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(258, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MoveFirstBT
            // 
            this.MoveFirstBT.AutoSize = true;
            this.MoveFirstBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MoveFirstBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MoveFirstBT.Location = new System.Drawing.Point(78, 189);
            this.MoveFirstBT.Name = "MoveFirstBT";
            this.MoveFirstBT.Size = new System.Drawing.Size(33, 23);
            this.MoveFirstBT.TabIndex = 27;
            this.MoveFirstBT.Text = "|<";
            this.MoveFirstBT.UseVisualStyleBackColor = true;
            this.MoveFirstBT.Click += new System.EventHandler(this.MoveFirstBT_Click);
            // 
            // MovePreviousBT
            // 
            this.MovePreviousBT.AutoSize = true;
            this.MovePreviousBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MovePreviousBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MovePreviousBT.Location = new System.Drawing.Point(117, 189);
            this.MovePreviousBT.Name = "MovePreviousBT";
            this.MovePreviousBT.Size = new System.Drawing.Size(33, 23);
            this.MovePreviousBT.TabIndex = 28;
            this.MovePreviousBT.Text = "<";
            this.MovePreviousBT.UseVisualStyleBackColor = true;
            this.MovePreviousBT.Click += new System.EventHandler(this.MovePreviousBT_Click);
            // 
            // RecordPositionTB
            // 
            this.RecordPositionTB.Location = new System.Drawing.Point(156, 189);
            this.RecordPositionTB.Name = "RecordPositionTB";
            this.RecordPositionTB.ReadOnly = true;
            this.RecordPositionTB.Size = new System.Drawing.Size(57, 21);
            this.RecordPositionTB.TabIndex = 29;
            // 
            // MoveNextBT
            // 
            this.MoveNextBT.AutoSize = true;
            this.MoveNextBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MoveNextBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MoveNextBT.Location = new System.Drawing.Point(219, 187);
            this.MoveNextBT.Name = "MoveNextBT";
            this.MoveNextBT.Size = new System.Drawing.Size(33, 23);
            this.MoveNextBT.TabIndex = 30;
            this.MoveNextBT.Text = ">";
            this.MoveNextBT.UseVisualStyleBackColor = true;
            this.MoveNextBT.Click += new System.EventHandler(this.MoveNextBT_Click);
            // 
            // MoveLastBT
            // 
            this.MoveLastBT.AutoSize = true;
            this.MoveLastBT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MoveLastBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MoveLastBT.Location = new System.Drawing.Point(258, 187);
            this.MoveLastBT.Name = "MoveLastBT";
            this.MoveLastBT.Size = new System.Drawing.Size(33, 23);
            this.MoveLastBT.TabIndex = 31;
            this.MoveLastBT.Text = "|>";
            this.MoveLastBT.UseVisualStyleBackColor = true;
            this.MoveLastBT.Click += new System.EventHandler(this.MoveLastBT_Click);
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(250, 23);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(83, 21);
            this.txbID.TabIndex = 32;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.Location = new System.Drawing.Point(96, 218);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(75, 23);
            this.btnEditSave.TabIndex = 34;
            this.btnEditSave.Text = "ذخیره";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Visible = false;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 253);
            this.Controls.Add(this.btnEditSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.MoveLastBT);
            this.Controls.Add(this.MoveNextBT);
            this.Controls.Add(this.RecordPositionTB);
            this.Controls.Add(this.MovePreviousBT);
            this.Controls.Add(this.MoveFirstBT);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txbCell);
            this.Controls.Add(this.txbTell);
            this.Controls.Add(this.txbStudentNumber);
            this.Controls.Add(this.txbFamilly);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف دانشجو";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbFamilly;
        private System.Windows.Forms.TextBox txbStudentNumber;
        private System.Windows.Forms.TextBox txbTell;
        private System.Windows.Forms.TextBox txbCell;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button MoveFirstBT;
        private System.Windows.Forms.Button MovePreviousBT;
        private System.Windows.Forms.TextBox RecordPositionTB;
        private System.Windows.Forms.Button MoveNextBT;
        private System.Windows.Forms.Button MoveLastBT;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditSave;
    }
}