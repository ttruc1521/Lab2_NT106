namespace Lab2 
{
    partial class Form1
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.btnBai1 = new System.Windows.Forms.Button();
            this.btnBai2 = new System.Windows.Forms.Button();
            this.btnBai3 = new System.Windows.Forms.Button();
            this.btnBai4 = new System.Windows.Forms.Button();
            this.btnBai5 = new System.Windows.Forms.Button();
            this.btnBai6 = new System.Windows.Forms.Button();
            this.btnBai7 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(135, 25);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(350, 29);
            this.lblTieuDe.Text = "MENU ĐIỀU HƯỚNG BÀI TẬP";

            // 
            // lblThongTin (HIỂN THỊ HỌ TÊN VÀ MSSV)
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
            this.lblThongTin.Location = new System.Drawing.Point(120, 65);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(380, 22);
            this.lblThongTin.Text = "Họ và tên: Cao Thị Thanh Trúc - MSSV: 25521945";

            // Nút Bài 1
            this.btnBai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBai1.Location = new System.Drawing.Point(50, 120);
            this.btnBai1.Size = new System.Drawing.Size(240, 45);
            this.btnBai1.Text = "Bài 01: Ghi và Đọc File";
            this.btnBai1.UseVisualStyleBackColor = true;
            this.btnBai1.Click += new System.EventHandler(this.btnBai1_Click);

            // Nút Bài 2
            this.btnBai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBai2.Location = new System.Drawing.Point(310, 120);
            this.btnBai2.Size = new System.Drawing.Size(240, 45);
            this.btnBai2.Text = "Bài 02: Thông Tin File";
            this.btnBai2.UseVisualStyleBackColor = true;
            this.btnBai2.Click += new System.EventHandler(this.btnBai2_Click);

            // Nút Bài 3
            this.btnBai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBai3.Location = new System.Drawing.Point(50, 180);
            this.btnBai3.Size = new System.Drawing.Size(240, 45);
            this.btnBai3.Text = "Bài 03: Tính Toán Biểu Thức";
            this.btnBai3.UseVisualStyleBackColor = true;
            this.btnBai3.Click += new System.EventHandler(this.btnBai3_Click);

            // Nút Bài 4
            this.btnBai4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBai4.Location = new System.Drawing.Point(310, 180);
            this.btnBai4.Size = new System.Drawing.Size(240, 45);
            this.btnBai4.Text = "Bài 04: Quản Lý Sinh Viên";
            this.btnBai4.UseVisualStyleBackColor = true;
            this.btnBai4.Click += new System.EventHandler(this.btnBai4_Click);

            // Nút Bài 5
            this.btnBai5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBai5.Location = new System.Drawing.Point(50, 240);
            this.btnBai5.Size = new System.Drawing.Size(240, 45);
            this.btnBai5.Text = "Bài 05: Quản Lý Phòng Vé";
            this.btnBai5.UseVisualStyleBackColor = true;
            this.btnBai5.Click += new System.EventHandler(this.btnBai5_Click);

            // Nút Bài 6
            this.btnBai6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBai6.Location = new System.Drawing.Point(310, 240);
            this.btnBai6.Size = new System.Drawing.Size(240, 45);
            this.btnBai6.Text = "Bài 06: Hôm Nay Ăn Gì (SQLite)";
            this.btnBai6.UseVisualStyleBackColor = true;
            this.btnBai6.Click += new System.EventHandler(this.btnBai6_Click);

            // Nút Bài 7
            this.btnBai7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBai7.Location = new System.Drawing.Point(50, 300);
            this.btnBai7.Size = new System.Drawing.Size(240, 45);
            this.btnBai7.Text = "Bài 07: Duyệt Thư Mục";
            this.btnBai7.UseVisualStyleBackColor = true;
            this.btnBai7.Click += new System.EventHandler(this.btnBai7_Click);

            // Nút Thoát
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(310, 300);
            this.btnExit.Size = new System.Drawing.Size(240, 45);
            this.btnExit.Text = "Thoát Ứng Dụng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBai7);
            this.Controls.Add(this.btnBai6);
            this.Controls.Add(this.btnBai5);
            this.Controls.Add(this.btnBai4);
            this.Controls.Add(this.btnBai3);
            this.Controls.Add(this.btnBai2);
            this.Controls.Add(this.btnBai1);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Chính - Lập Trình Mạng Căn Bản";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Button btnBai1;
        private System.Windows.Forms.Button btnBai2;
        private System.Windows.Forms.Button btnBai3;
        private System.Windows.Forms.Button btnBai4;
        private System.Windows.Forms.Button btnBai5;
        private System.Windows.Forms.Button btnBai6;
        private System.Windows.Forms.Button btnBai7;
        private System.Windows.Forms.Button btnExit;
    }
}