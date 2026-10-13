namespace Lab2 
{
    partial class Lab2_Bai6
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
            this.listViewMonAn = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHinhAnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNguoiDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.txtNguoiDongGop = new System.Windows.Forms.TextBox();
            this.lblNguoiDongGop = new System.Windows.Forms.Label();
            this.btnThemMon = new System.Windows.Forms.Button();

            this.btnTimMonAn = new System.Windows.Forms.Button();
            this.pictureBoxMonAn = new System.Windows.Forms.PictureBox();
            this.lblKetQuaMon = new System.Windows.Forms.Label();
            this.lblKetQuaNguoi = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonAn)).BeginInit();
            this.SuspendLayout();

            // 
            // listViewMonAn
            // 
            this.listViewMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderTenMon,
            this.columnHeaderHinhAnh,
            this.columnHeaderNguoiDung});
            this.listViewMonAn.FullRowSelect = true;
            this.listViewMonAn.GridLines = true;
            this.listViewMonAn.Location = new System.Drawing.Point(30, 30);
            this.listViewMonAn.Name = "listViewMonAn";
            this.listViewMonAn.Size = new System.Drawing.Size(480, 320);
            this.listViewMonAn.TabIndex = 0;
            this.listViewMonAn.UseCompatibleStateImageBehavior = false;
            this.listViewMonAn.View = System.Windows.Forms.View.Details;

            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 40;
            this.columnHeaderTenMon.Text = "Tên món ăn";
            this.columnHeaderTenMon.Width = 150;
            this.columnHeaderHinhAnh.Text = "Hình ảnh";
            this.columnHeaderHinhAnh.Width = 120;
            this.columnHeaderNguoiDung.Text = "Người đóng góp";
            this.columnHeaderNguoiDung.Width = 150;

            // Input Controls
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(530, 35);
            this.lblTenMon.Text = "Tên món ăn:";
            this.txtTenMon.Location = new System.Drawing.Point(650, 32);
            this.txtTenMon.Size = new System.Drawing.Size(180, 22);

            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Location = new System.Drawing.Point(530, 80);
            this.lblHinhAnh.Text = "Tên file ảnh:";
            this.txtHinhAnh.Location = new System.Drawing.Point(650, 77);
            this.txtHinhAnh.Size = new System.Drawing.Size(180, 22);

            this.lblNguoiDongGop.AutoSize = true;
            this.lblNguoiDongGop.Location = new System.Drawing.Point(530, 125);
            this.lblNguoiDongGop.Text = "Người đóng góp:";
            this.txtNguoiDongGop.Location = new System.Drawing.Point(650, 122);
            this.txtNguoiDongGop.Size = new System.Drawing.Size(180, 22);

            this.btnThemMon.Location = new System.Drawing.Point(530, 170);
            this.btnThemMon.Size = new System.Drawing.Size(300, 35);
            this.btnThemMon.Text = "Thêm Món Ăn Mới";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);

            // Random Result Area
            this.btnTimMonAn.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTimMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimMonAn.Location = new System.Drawing.Point(530, 230);
            this.btnTimMonAn.Size = new System.Drawing.Size(300, 45);
            this.btnTimMonAn.Text = "Hôm nay ăn gì? (Ngẫu nhiên)";
            this.btnTimMonAn.UseVisualStyleBackColor = false;
            this.btnTimMonAn.Click += new System.EventHandler(this.btnTimMonAn_Click);

            this.pictureBoxMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMonAn.Location = new System.Drawing.Point(30, 370);
            this.pictureBoxMonAn.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.lblKetQuaMon.AutoSize = true;
            this.lblKetQuaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblKetQuaMon.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblKetQuaMon.Location = new System.Drawing.Point(200, 390);
            this.lblKetQuaMon.Text = "Món ăn: (Chưa chọn)";

            this.lblKetQuaNguoi.AutoSize = true;
            this.lblKetQuaNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblKetQuaNguoi.Location = new System.Drawing.Point(200, 440);
            this.lblKetQuaNguoi.Text = "Người đóng góp: ---";

            // 
            // Lab2_Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.lblKetQuaNguoi);
            this.Controls.Add(this.lblKetQuaMon);
            this.Controls.Add(this.pictureBoxMonAn);
            this.Controls.Add(this.btnTimMonAn);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.txtNguoiDongGop);
            this.Controls.Add(this.lblNguoiDongGop);
            this.Controls.Add(this.txtHinhAnh);
            this.Controls.Add(this.lblHinhAnh);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.listViewMonAn);
            this.Name = "Lab2_Bai6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2 - Bài 06: Hôm nay ăn gì (SQLite)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listViewMonAn;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderTenMon;
        private System.Windows.Forms.ColumnHeader columnHeaderHinhAnh;
        private System.Windows.Forms.ColumnHeader columnHeaderNguoiDung;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.TextBox txtNguoiDongGop;
        private System.Windows.Forms.Label lblNguoiDongGop;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnTimMonAn;
        private System.Windows.Forms.PictureBox pictureBoxMonAn;
        private System.Windows.Forms.Label lblKetQuaMon;
        private System.Windows.Forms.Label lblKetQuaNguoi;
    }
}