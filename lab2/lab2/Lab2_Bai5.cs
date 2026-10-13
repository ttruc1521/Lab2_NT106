using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public class ThongKePhim
    {
        public string TenPhim { get; set; }
        public int SoLuongBanRa { get; set; }
        public int SoLuongTon { get; set; }
        public double TiLeBanRa { get; set; }
        public decimal DoanhThu { get; set; }
        public int XepHang { get; set; }
    }

    public partial class Lab2_Bai5 : Form
    {
        private List<string> danhSachGheDaChon = new List<string>();
        private decimal giaVeChuan = 60000; // Giá vé chuẩn mặc định
        private int tongSoGhe = 15; // Giả lập tổng số ghế mỗi phòng là 15 ghế (A1->A5, B1->B5, C1->C5)

        public Lab2_Bai5()
        {
            InitializeComponent();
        }

        // Đọc file input5.txt để nạp thông tin phim và giá vé chuẩn
        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.FileName = "input5.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    if (lines.Length >= 2)
                    {
                        txtTenPhim.Text = lines[0].Trim();
                        if (decimal.TryParse(lines[1].Trim(), out decimal gia))
                        {
                            giaVeChuan = gia;
                            txtGiaVeChuan.Text = giaVeChuan.ToString("N0");
                        }
                        MessageBox.Show("Đọc thông tin phim từ input5.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cấu trúc file input5.txt không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Chọn ghế ngồi (giả lập chọn qua CheckedListBox hoặc các nút bấm)
        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            // Thêm danh sách ghế mẫu hoặc lấy từ giao diện
            danhSachGheDaChon.Clear();
            foreach (var item in checkedListBoxGhe.CheckedItems)
            {
                danhSachGheDaChon.Add(item.ToString());
            }

            if (danhSachGheDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongTien = 0;
            foreach (string ghe in danhSachGheDaChon)
            {
                if (ghe.StartsWith("A")) tongTien += giaVeChuan * 0.25M; // Ghế vớt
                else if (ghe.StartsWith("B")) tongTien += giaVeChuan * 1.0M;  // Ghế thường
                else if (ghe.StartsWith("C")) tongTien += giaVeChuan * 2.0M;  // Ghế VIP
            }

            txtTongTien.Text = tongTien.ToString("N0") + " VNĐ";
            MessageBox.Show($"Đã tính tiền cho {danhSachGheDaChon.Count} ghế. Tổng tiền: {txtTongTien.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xuất file thống kê output5.txt kèm theo ProgressBar chạy tiến trình
        private void btnXuatThongKe_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfd.FileName = "output5.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    progressBar1.Visible = true;
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 100;
                    progressBar1.Value = 0;

                    // Giả lập tiến trình chạy ProgressBar
                    for (int i = 1; i <= 50; i++)
                    {
                        progressBar1.Value = i;
                        System.Threading.Thread.Sleep(10);
                    }

                    // Tính toán thống kê dữ liệu phim
                    int banRa = danhSachGheDaChon.Count > 0 ? danhSachGheDaChon.Count : 3; // Mặc định test 3 vé nếu chưa chọn
                    int ton = tongSoGhe - banRa;
                    double tiLe = (double)banRa / tongSoGhe * 100;
                    decimal doanhThu = 0;
                    foreach (string ghe in danhSachGheDaChon)
                    {
                        if (ghe.StartsWith("A")) doanhThu += giaVeChuan * 0.25M;
                        else if (ghe.StartsWith("B")) doanhThu += giaVeChuan * 1.0M;
                        else if (ghe.StartsWith("C")) doanhThu += giaVeChuan * 2.0M;
                    }
                    if (doanhThu == 0) doanhThu = giaVeChuan * banRa; // Giá trị mặc định

                    List<ThongKePhim> danhSachThongKe = new List<ThongKePhim>
                    {
                        new ThongKePhim
                        {
                            TenPhim = string.IsNullOrEmpty(txtTenPhim.Text) ? "Đất Rừng Phương Nam" : txtTenPhim.Text,
                            SoLuongBanRa = banRa,
                            SoLuongTon = ton,
                            TiLeBanRa = Math.Round(tiLe, 2),
                            DoanhThu = doanhThu,
                            XepHang = 1
                        }
                    };

                    for (int i = 51; i <= 100; i++)
                    {
                        progressBar1.Value = i;
                        System.Threading.Thread.Sleep(10);
                    }

                    // Ghi nội dung xuống file output5.txt
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("=== BÁO CÁO THỐNG KÊ DOANH THU PHÒNG VÉ ===");
                        foreach (var tk in danhSachThongKe)
                        {
                            sw.WriteLine($"Tên phim: {tk.TenPhim}");
                            sw.WriteLine($"Số lượng vé bán ra: {tk.SoLuongBanRa}");
                            sw.WriteLine($"Số lượng vé tồn: {tk.SoLuongTon}");
                            sw.WriteLine($"Tỉ lệ vé bán ra: {tk.TiLeBanRa}%");
                            sw.WriteLine($"Doanh thu: {tk.DoanhThu:N0} VNĐ");
                            sw.WriteLine($"Xếp hạng doanh thu: {tk.XepHang}");
                            sw.WriteLine("--------------------------------------------");
                        }
                    }

                    MessageBox.Show("Xuất file thống kê output5.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressBar1.Visible = false;
                }
            }
        }
    }
}