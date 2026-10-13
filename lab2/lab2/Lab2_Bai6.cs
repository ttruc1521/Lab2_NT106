using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Lab2 
{
    public partial class Lab2_Bai6 : Form
    {
        private string connectionString = "Data Source=HomNayAnGi.db;Version=3;";

        public Lab2_Bai6()
        {
            InitializeComponent();
            KhoiTaoDatabase();
            TaiDuLieuLenListView();
        }

        // Khởi tạo cơ sở dữ liệu SQLite và các bảng mẫu nếu chưa có
        private void KhoiTaoDatabase()
        {
            if (!File.Exists("HomNayAnGi.db"))
            {
                SQLiteConnection.CreateFile("HomNayAnGi.db");
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sqlNguoiDung = @"CREATE TABLE NguoiDung (
                                            IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                                            HoVaTen TEXT NOT NULL,
                                            QuyenHan TEXT)";
                    string sqlMonAn = @"CREATE TABLE MonAn (
                                        IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                                        TenMonAn TEXT NOT NULL,
                                        HinhAnh TEXT,
                                        IDNCC INTEGER,
                                        FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC))";

                    using (SQLiteCommand cmd = new SQLiteCommand(sqlNguoiDung, conn)) { cmd.ExecuteNonQuery(); }
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlMonAn, conn)) { cmd.ExecuteNonQuery(); }

                    // Thêm dữ liệu mẫu
                    string insertUser = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES ('Nguyễn Văn A', 'Admin');";
                    string insertFood1 = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ('Phở bò', 'pho.jpg', 1);";
                    string insertFood2 = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ('Cơm tấm sườn', 'comtam.jpg', 1);";

                    using (SQLiteCommand cmd = new SQLiteCommand(insertUser, conn)) { cmd.ExecuteNonQuery(); }
                    using (SQLiteCommand cmd = new SQLiteCommand(insertFood1, conn)) { cmd.ExecuteNonQuery(); }
                    using (SQLiteCommand cmd = new SQLiteCommand(insertFood2, conn)) { cmd.ExecuteNonQuery(); }
                }
            }
        }

        // Tải danh sách món ăn và người đóng góp từ SQLite lên ListView
        private void TaiDuLieuLenListView()
        {
            listViewMonAn.Items.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT m.IDMA, m.TenMonAn, m.HinhAnh, n.HoVaTen 
                                 FROM MonAn m JOIN NguoiDung n ON m.IDNCC = n.IDNCC";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["IDMA"].ToString());
                            item.SubItems.Add(reader["TenMonAn"].ToString());
                            item.SubItems.Add(reader["HinhAnh"].ToString());
                            item.SubItems.Add(reader["HoVaTen"].ToString());
                            listViewMonAn.Items.Add(item);
                        }
                    }
                }
            }
        }

        // Nút Thêm Món Ăn
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text.Trim();
            string hinhAnh = txtHinhAnh.Text.Trim();
            string nguoiDongGop = txtNguoiDongGop.Text.Trim();

            if (string.IsNullOrEmpty(tenMon) || string.IsNullOrEmpty(nguoiDongGop))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn và tên người đóng góp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                // Kiểm tra hoặc thêm người đóng góp
                long idncc = 1;
                string checkUser = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @name";
                using (SQLiteCommand cmdCheck = new SQLiteCommand(checkUser, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@name", nguoiDongGop);
                    object result = cmdCheck.ExecuteScalar();
                    if (result != null)
                    {
                        idncc = Convert.ToInt64(result);
                    }
                    else
                    {
                        string insertUser = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@name, 'User');";
                        using (SQLiteCommand cmdInsertUser = new SQLiteCommand(insertUser, conn))
                        {
                            cmdInsertUser.Parameters.AddWithValue("@name", nguoiDongGop);
                            cmdInsertUser.ExecuteNonQuery();
                            idncc = conn.LastInsertRowId;
                        }
                    }
                }

                // Thêm món ăn vào bảng MonAn
                string insertFood = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@tenMon, @hinhAnh, @idncc);";
                using (SQLiteCommand cmdFood = new SQLiteCommand(insertFood, conn))
                {
                    cmdFood.Parameters.AddWithValue("@tenMon", tenMon);
                    cmdFood.Parameters.AddWithValue("@hinhAnh", hinhAnh);
                    cmdFood.Parameters.AddWithValue("@idncc", idncc);
                    cmdFood.ExecuteNonQuery();
                }
            }

            txtTenMon.Clear();
            txtHinhAnh.Clear();
            txtNguoiDongGop.Clear();
            TaiDuLieuLenListView();
            MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Tìm Món Ăn (Chọn ngẫu nhiên)
        private void btnTimMonAn_Click(object sender, EventArgs e)
        {
            if (listViewMonAn.Items.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random rand = new Random();
            int index = rand.Next(listViewMonAn.Items.Count);
            ListViewItem selectedItem = listViewMonAn.Items[index];

            lblKetQuaMon.Text = "Món ăn: " + selectedItem.SubItems[1].Text;
            lblKetQuaNguoi.Text = "Người đóng góp: " + selectedItem.SubItems[3].Text;

            // Giả lập hiển thị hình ảnh nếu có file ảnh tương ứng
            string imgName = selectedItem.SubItems[2].Text;
            if (File.Exists(imgName))
            {
                pictureBoxMonAn.Image = System.Drawing.Image.FromFile(imgName);
            }
            else
            {
                pictureBoxMonAn.Image = null; // Hoặc hiển thị ảnh mặc định
            }
        }
    }
}