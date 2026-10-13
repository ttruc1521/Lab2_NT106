using System;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
        {
            InitializeComponent();
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // 1. Lấy tên file sử dụng SafeFileName
                string fileName = ofd.SafeFileName;
                txtFileName.Text = fileName;

                // 2. Lấy đường dẫn URL (đường dẫn đầy đủ) từ FileStream hoặc tệp
                string filePath = ofd.FileName;
                txtUrl.Text = filePath;

                // 3. Lấy kích thước file (Bytes)
                FileInfo fileInfo = new FileInfo(filePath);
                long fileSize = fileInfo.Length;
                txtSize.Text = fileSize + " bytes";

                // 4. Đọc nội dung file bằng StreamReader kết hợp FileStream
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string content = sr.ReadToEnd();
                    richTextBoxContent.Text = content;

                    // 5. Tính số dòng, số từ, số ký tự
                    // Số ký tự
                    int charCount = content.Length;
                    txtCharacterCount.Text = charCount.ToString();

                    // Số dòng: đếm số ký tự xuống dòng hoặc đếm qua ReadLine/mảng dòng
                    int lineCount = 0;
                    if (!string.IsNullOrEmpty(content))
                    {
                        // Đọc lại từ đầu hoặc tách chuỗi
                        string[] lines = File.ReadAllLines(filePath);
                        lineCount = lines.Length;
                    }
                    txtLineCount.Text = lineCount.ToString();

                    // Số từ: tách các từ theo khoảng trắng và ký tự xuống dòng
                    int wordCount = 0;
                    if (!string.IsNullOrEmpty(content))
                    {
                        string[] words = content.Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        wordCount = words.Length;
                    }
                    txtWordsCount.Text = wordCount.ToString();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
