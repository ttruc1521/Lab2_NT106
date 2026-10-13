namespace Lab2
{
    partial class Lab2_Bai5
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
            this.btnDocFile = new System.Windows.Forms.Button();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.lblGiaVeChuan = new System.Windows.Forms.Label();
            this.txtGiaVeChuan = new System.Windows.Forms.TextBox();
            this.checkedListBoxGhe = new System.Windows.Forms.CheckedListBox();
            this.lblGhe = new System.Windows.Forms.Label();
            this.btnChonGhe = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnXuatThongKe = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();

            // 
            // btnDocFile
            // 
            this.btnDocFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnDocFile.Location = new System.Drawing.Point(30, 25);
            this.btnDocFile.Size = new System.Drawing.Size(250, 40);
            this.btnDocFile.Text = "Đọc File input5.txt";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);

            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Location = new System.Drawing.Point(30, 90);
            this.lblTenPhim.Size = new System.Drawing.Size(67, 17);
            this.lblTenPhim.Text = "Tên phim:";

            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(140, 87);
            this.txtTenPhim.Size = new System.Drawing.Size(180, 22);

            // 
            // lblGiaVeChuan
            // 
            this.lblGiaVeChuan.AutoSize = true;
            this.lblGiaVeChuan.Location = new System.Drawing.Point(30, 135);
            this.lblGiaVeChuan.Size = new System.Drawing.Size(95, 17);
            this.lblGiaVeChuan.Text = "Giá vé chuẩn:";

            // 
            // txtGiaVeChuan
            // 
            this.txtGiaVeChuan.Location = new System.Drawing.Point(140, 132);
            this.txtGiaVeChuan.Size = new System.Drawing.Size(180, 22);

            // 
            // checkedListBoxGhe
            // 
            this.checkedListBoxGhe.FormattingEnabled = true;
            this.checkedListBoxGhe.Items.AddRange(new object[] {
            "A1 (Ghế vớt)",
            "A2 (Ghế vớt)",
            "B1 (Ghế thường)",
            "B2 (Ghế thường)",
            "C1 (Ghế VIP)",
            "C2 (Ghế VIP)"});
            this.checkedListBoxGhe.Location = new System.Drawing.Point(360, 87);
            this.checkedListBoxGhe.Size = new System.Drawing.Size(200, 140);

            // 
            // lblGhe
            // 
            this.lblGhe.AutoSize = true;
            this.lblGhe.Location = new System.Drawing.Point(360, 60);
            this.lblGhe.Size = new System.Drawing.Size(110, 17);
            this.lblGhe.Text = "Chọn ghế ngồi:";

            // 
            // btnChonGhe
            // 
            this.btnChonGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnChonGhe.Location = new System.Drawing.Point(360, 240);
            this.btnChonGhe.Size = new System.Drawing.Size(200, 35);
            this.btnChonGhe.Text = "Tính Tiền Vé";
            this.btnChonGhe.UseVisualStyleBackColor = true;
            this.btnChonGhe.Click += new System.EventHandler(this.btnChonGhe_Click);

            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(30, 180);
            this.lblTongTien.Size = new System.Drawing.Size(72, 17);
            this.lblTongTien.Text = "Tổng tiền:";

            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(140, 177);
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(180, 22);

            // 
            // btnXuatThongKe
            // 
            this.btnXuatThongKe.BackColor = System.Drawing.Color.LightGreen;
            this.btnXuatThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXuatThongKe.Location = new System.Drawing.Point(30, 235);
            this.btnXuatThongKe.Size = new System.Drawing.Size(290, 45);
            this.btnXuatThongKe.Text = "Xuất Thống Kê ra output5.txt";
            this.btnXuatThongKe.UseVisualStyleBackColor = false;
            this.btnXuatThongKe.Click += new System.EventHandler(this.btnXuatThongKe_Click);

            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 305);
            this.progressBar1.Size = new System.Drawing.Size(530, 25);
            this.progressBar1.Visible = false;

            // 
            // Lab2_Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnXuatThongKe);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnChonGhe);
            this.Controls.Add(this.lblGhe);
            this.Controls.Add(this.checkedListBoxGhe);
            this.Controls.Add(this.txtGiaVeChuan);
            this.Controls.Add(this.lblGiaVeChuan);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.lblTenPhim);
            this.Controls.Add(this.btnDocFile);
            this.Name = "Lab2_Bai5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2 - Bài 05: Quản lý phòng vé phiên bản 2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label lblGiaVeChuan;
        private System.Windows.Forms.TextBox txtGiaVeChuan;
        private System.Windows.Forms.CheckedListBox checkedListBoxGhe;
        private System.Windows.Forms.Label lblGhe;
        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnXuatThongKe;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}