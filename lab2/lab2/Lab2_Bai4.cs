using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Lab2 
{
    // Định nghĩa cấu trúc lớp SinhVien
    public class SinhVien
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Phone { get; set; }
        public float Course1 { get; set; }
        public float Course2 { get; set; }
        public float Course3 { get; set; }
        public float Average { get; set; }
    }

    public partial class Lab2_Bai4 : Form
    {
        private List<SinhVien> danhSachSV = new List<SinhVien>();
        private int currentIndex = 0;

        public Lab2_Bai4()
        {
            InitializeComponent(); // <-- QUAN TRỌNG: Hàm vẽ giao diện từ file Designer
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtAddName.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Vui lòng nhập họ tên sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtAddID.Text.Trim(), out int id) || txtAddID.Text.Trim().Length != 8)
                {
                    MessageBox.Show("Mã số sinh viên phải là một số có đúng 8 chữ số!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddID.Focus();
                    return;
                }

                string phone = txtAddPhone.Text.Trim();
                if (phone.Length != 10 || !phone.StartsWith("0") || !long.TryParse(phone, out _))
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddPhone.Focus();
                    return;
                }

                if (!float.TryParse(txtAddC1.Text, out float c1) || c1 < 0 || c1 > 10 ||
                    !float.TryParse(txtAddC2.Text, out float c2) || c2 < 0 || c2 > 10 ||
                    !float.TryParse(txtAddC3.Text, out float c3) || c3 < 0 || c3 > 10)
                {
                    MessageBox.Show("Điểm các môn phải là số thực từ 0 đến 10!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float avg = (c1 + c2 + c3) / 3f;

                SinhVien sv = new SinhVien
                {
                    Name = name,
                    ID = id,
                    Phone = phone,
                    Course1 = c1,
                    Course2 = c2,
                    Course3 = c3,
                    Average = (float)Math.Round(avg, 2)
                };

                danhSachSV.Add(sv);
                CapNhatRichTextBoxHienThi();

                txtAddName.Clear();
                txtAddID.Clear();
                txtAddPhone.Clear();
                txtAddC1.Clear();
                txtAddC2.Clear();
                txtAddC3.Clear();
                txtAddAvg.Clear();
                txtAddName.Focus();

                MessageBox.Show("Đã thêm sinh viên vào danh sách tạm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            if (danhSachSV.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên đang trống, không thể ghi file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfd.FileName = "input4.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = JsonSerializer.Serialize(danhSachSV, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(sfd.FileName, jsonString);
                    MessageBox.Show("Đã ghi danh sách sinh viên xuống file input4.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.FileName = "input4.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(ofd.FileName);
                    danhSachSV = JsonSerializer.Deserialize<List<SinhVien>>(jsonString);

                    if (danhSachSV != null && danhSachSV.Count > 0)
                    {
                        currentIndex = 0;
                        HienThiSinhVienTheoIndex(currentIndex);

                        string outputJson = JsonSerializer.Serialize(danhSachSV, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText("output4.txt", outputJson);

                        MessageBox.Show("Đọc file và tính điểm trung bình thành công! Đã tự động xuất kết quả ra file output4.txt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file hoặc định dạng không khớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (danhSachSV.Count > 0 && currentIndex < danhSachSV.Count - 1)
            {
                currentIndex++;
                HienThiSinhVienTheoIndex(currentIndex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (danhSachSV.Count > 0 && currentIndex > 0)
            {
                currentIndex--;
                HienThiSinhVienTheoIndex(currentIndex);
            }
        }

        private void HienThiSinhVienTheoIndex(int index)
        {
            if (index >= 0 && index < danhSachSV.Count)
            {
                SinhVien sv = danhSachSV[index];
                txtReadName.Text = sv.Name;
                txtReadID.Text = sv.ID.ToString();
                txtReadPhone.Text = sv.Phone;
                txtReadC1.Text = sv.Course1.ToString();
                txtReadC2.Text = sv.Course2.ToString();
                txtReadC3.Text = sv.Course3.ToString();
                txtReadAvg.Text = sv.Average.ToString();
                lblPageNumber.Text = $"{index + 1} / {danhSachSV.Count}";
            }
        }

        private void CapNhatRichTextBoxHienThi()
        {
            richTextBoxDanhSach.Clear();
            foreach (var sv in danhSachSV)
            {
                richTextBoxDanhSach.AppendText($"{sv.Name}\r\n{sv.ID}\r\n{sv.Phone}\r\n{sv.Course1}\r\n{sv.Course2}\r\n{sv.Course3}\r\n\r\n");
            }
        }
    }
}