using System;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2_Bai1 : Form
    {
        public Lab2_Bai1()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            // Sử dụng OpenDialog hoặc đọc trực tiếp file input1.txt trong thư mục dự án / Debug
            // Ở đây ta dùng cách mở file trực tiếp hoặc qua OpenFileDialog cho tiện thao tác
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FileName = "input1.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Sử dụng StreamReader kết hợpReadToEnd để đọc toàn bộ nội dung file
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string noiDung = reader.ReadToEnd();
                        richTextBox1.Text = noiDung;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Không có nội dung để ghi file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.FileName = "output1.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Chuyển toàn bộ nội dung trong RichTextBox sang kiểu in hoa
                    string noiDungInHoa = richTextBox1.Text.ToUpper();

                    // Sử dụng StreamWriter để ghi nội dung xuống file
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.Write(noiDungInHoa);
                    }

                    MessageBox.Show("Đã ghi file thành công (chuyển sang chữ in hoa)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
