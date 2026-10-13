namespace Lab2
{
    partial class Lab2_Bai4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtAddID = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.lblC1 = new System.Windows.Forms.Label();
            this.txtAddC1 = new System.Windows.Forms.TextBox();
            this.lblC2 = new System.Windows.Forms.Label();
            this.txtAddC2 = new System.Windows.Forms.TextBox();
            this.lblC3 = new System.Windows.Forms.Label();
            this.txtAddC3 = new System.Windows.Forms.TextBox();
            this.lblAvg = new System.Windows.Forms.Label();
            this.txtAddAvg = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.richTextBoxDanhSach = new System.Windows.Forms.RichTextBox();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.txtReadName = new System.Windows.Forms.TextBox();
            this.lblReadName = new System.Windows.Forms.Label();
            this.lblReadID = new System.Windows.Forms.Label();
            this.txtReadID = new System.Windows.Forms.TextBox();
            this.lblReadPhone = new System.Windows.Forms.Label();
            this.txtReadPhone = new System.Windows.Forms.TextBox();
            this.lblReadC1 = new System.Windows.Forms.Label();
            this.txtReadC1 = new System.Windows.Forms.TextBox();
            this.lblReadC2 = new System.Windows.Forms.Label();
            this.txtReadC2 = new System.Windows.Forms.TextBox();
            this.lblReadC3 = new System.Windows.Forms.Label();
            this.txtReadC3 = new System.Windows.Forms.TextBox();
            this.lblReadAvg = new System.Windows.Forms.Label();
            this.txtReadAvg = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // btnWriteToFile
            this.btnWriteToFile.Location = new System.Drawing.Point(20, 20);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(220, 35);
            this.btnWriteToFile.Text = "Write to a File";
            this.btnWriteToFile.UseVisualStyleBackColor = true;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);

            // Cột bên trái (Nhập thông tin)
            this.txtAddName.Location = new System.Drawing.Point(20, 70);
            this.txtAddName.Size = new System.Drawing.Size(140, 22);
            this.lblName.Location = new System.Drawing.Point(170, 73);
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.Text = "Name";

            this.txtAddID.Location = new System.Drawing.Point(20, 110);
            this.txtAddID.Size = new System.Drawing.Size(140, 22);
            this.lblID.Location = new System.Drawing.Point(170, 113);
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.Text = "ID";

            this.txtAddPhone.Location = new System.Drawing.Point(20, 150);
            this.txtAddPhone.Size = new System.Drawing.Size(140, 22);
            this.lblPhone.Location = new System.Drawing.Point(170, 153);
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.Text = "Phone";

            this.txtAddC1.Location = new System.Drawing.Point(20, 190);
            this.txtAddC1.Size = new System.Drawing.Size(140, 22);
            this.lblC1.Location = new System.Drawing.Point(170, 193);
            this.lblC1.Size = new System.Drawing.Size(65, 17);
            this.lblC1.Text = "Course 1";

            this.txtAddC2.Location = new System.Drawing.Point(20, 230);
            this.txtAddC2.Size = new System.Drawing.Size(140, 22);
            this.lblC2.Location = new System.Drawing.Point(170, 233);
            this.lblC2.Size = new System.Drawing.Size(65, 17);
            this.lblC2.Text = "Course 2";

            this.txtAddC3.Location = new System.Drawing.Point(20, 270);
            this.txtAddC3.Size = new System.Drawing.Size(140, 22);
            this.lblC3.Location = new System.Drawing.Point(170, 273);
            this.lblC3.Size = new System.Drawing.Size(65, 17);
            this.lblC3.Text = "Course 3";

            this.txtAddAvg.Location = new System.Drawing.Point(20, 310);
            this.txtAddAvg.ReadOnly = true;
            this.txtAddAvg.Size = new System.Drawing.Size(140, 22);
            this.lblAvg.Location = new System.Drawing.Point(170, 313);
            this.lblAvg.Size = new System.Drawing.Size(61, 17);
            this.lblAvg.Text = "Average";

            this.btnAdd.Location = new System.Drawing.Point(50, 360);
            this.btnAdd.Size = new System.Drawing.Size(140, 35);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Cột giữa (RichTextBox hiển thị danh sách)
            this.richTextBoxDanhSach.Location = new System.Drawing.Point(260, 20);
            this.richTextBoxDanhSach.Name = "richTextBoxDanhSach";
            this.richTextBoxDanhSach.ReadOnly = true;
            this.richTextBoxDanhSach.Size = new System.Drawing.Size(260, 375);

            // Cột bên phải (Đọc file & chuyển trang)
            this.btnReadFromFile.Location = new System.Drawing.Point(540, 20);
            this.btnReadFromFile.Size = new System.Drawing.Size(240, 35);
            this.btnReadFromFile.Text = "Button to read a File";
            this.btnReadFromFile.UseVisualStyleBackColor = true;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);

            this.txtReadName.Location = new System.Drawing.Point(540, 70);
            this.txtReadName.ReadOnly = true;
            this.txtReadName.Size = new System.Drawing.Size(140, 22);
            this.lblReadName.Location = new System.Drawing.Point(690, 73);
            this.lblReadName.Size = new System.Drawing.Size(45, 17);
            this.lblReadName.Text = "Name";

            this.txtReadID.Location = new System.Drawing.Point(540, 110);
            this.txtReadID.ReadOnly = true;
            this.txtReadID.Size = new System.Drawing.Size(140, 22);
            this.lblReadID.Location = new System.Drawing.Point(690, 113);
            this.lblReadID.Size = new System.Drawing.Size(21, 17);
            this.lblReadID.Text = "ID";

            this.txtReadPhone.Location = new System.Drawing.Point(540, 150);
            this.txtReadPhone.ReadOnly = true;
            this.txtReadPhone.Size = new System.Drawing.Size(140, 22);
            this.lblReadPhone.Location = new System.Drawing.Point(690, 153);
            this.lblReadPhone.Size = new System.Drawing.Size(49, 17);
            this.lblReadPhone.Text = "Phone";

            this.txtReadC1.Location = new System.Drawing.Point(540, 190);
            this.txtReadC1.ReadOnly = true;
            this.txtReadC1.Size = new System.Drawing.Size(140, 22);
            this.lblReadC1.Location = new System.Drawing.Point(690, 193);
            this.lblReadC1.Size = new System.Drawing.Size(65, 17);
            this.lblReadC1.Text = "Course 1";

            this.txtReadC2.Location = new System.Drawing.Point(540, 230);
            this.txtReadC2.ReadOnly = true;
            this.txtReadC2.Size = new System.Drawing.Size(140, 22);
            this.lblReadC2.Location = new System.Drawing.Point(690, 233);
            this.lblReadC2.Size = new System.Drawing.Size(65, 17);
            this.lblReadC2.Text = "Course 2";

            this.txtReadC3.Location = new System.Drawing.Point(540, 270);
            this.txtReadC3.ReadOnly = true;
            this.txtReadC3.Size = new System.Drawing.Size(140, 22);
            this.lblReadC3.Location = new System.Drawing.Point(690, 273);
            this.lblReadC3.Size = new System.Drawing.Size(65, 17);
            this.lblReadC3.Text = "Course 3";

            this.txtReadAvg.Location = new System.Drawing.Point(540, 310);
            this.txtReadAvg.ReadOnly = true;
            this.txtReadAvg.Size = new System.Drawing.Size(140, 22);
            this.lblReadAvg.Location = new System.Drawing.Point(690, 313);
            this.lblReadAvg.Size = new System.Drawing.Size(61, 17);
            this.lblReadAvg.Text = "Average";

            // Nút Back / Next
            this.btnBack.Location = new System.Drawing.Point(540, 360);
            this.btnBack.Size = new System.Drawing.Size(70, 35);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(630, 370);
            this.lblPageNumber.Text = "0 / 0";

            this.btnNext.Location = new System.Drawing.Point(700, 360);
            this.btnNext.Size = new System.Drawing.Size(70, 35);
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            // Form Lab2_Bai4
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 420);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtReadAvg);
            this.Controls.Add(this.lblReadAvg);
            this.Controls.Add(this.txtReadC3);
            this.Controls.Add(this.lblReadC3);
            this.Controls.Add(this.txtReadC2);
            this.Controls.Add(this.lblReadC2);
            this.Controls.Add(this.txtReadC1);
            this.Controls.Add(this.lblReadC1);
            this.Controls.Add(this.txtReadPhone);
            this.Controls.Add(this.lblReadPhone);
            this.Controls.Add(this.txtReadID);
            this.Controls.Add(this.lblReadID);
            this.Controls.Add(this.txtReadName);
            this.Controls.Add(this.lblReadName);
            this.Controls.Add(this.btnReadFromFile);
            this.Controls.Add(this.richTextBoxDanhSach);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddAvg);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.txtAddC3);
            this.Controls.Add(this.lblC3);
            this.Controls.Add(this.txtAddC2);
            this.Controls.Add(this.lblC2);
            this.Controls.Add(this.txtAddC1);
            this.Controls.Add(this.lblC1);
            this.Controls.Add(this.txtAddPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtAddID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnWriteToFile);
            this.Name = "Lab2_Bai4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2 - Bài 04: Quản lý sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnWriteToFile;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtAddID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddPhone;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.TextBox txtAddC1;
        private System.Windows.Forms.Label lblC2;
        private System.Windows.Forms.TextBox txtAddC2;
        private System.Windows.Forms.Label lblC3;
        private System.Windows.Forms.TextBox txtAddC3;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.TextBox txtAddAvg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox richTextBoxDanhSach;
        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.TextBox txtReadName;
        private System.Windows.Forms.Label lblReadName;
        private System.Windows.Forms.Label lblReadID;
        private System.Windows.Forms.TextBox txtReadID;
        private System.Windows.Forms.Label lblReadPhone;
        private System.Windows.Forms.TextBox txtReadPhone;
        private System.Windows.Forms.Label lblReadC1;
        private System.Windows.Forms.TextBox txtReadC1;
        private System.Windows.Forms.Label lblReadC2;
        private System.Windows.Forms.TextBox txtReadC2;
        private System.Windows.Forms.Label lblReadC3;
        private System.Windows.Forms.TextBox txtReadC3;
        private System.Windows.Forms.Label lblReadAvg;
        private System.Windows.Forms.TextBox txtReadAvg;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageNumber;
    }
}