using System;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2_Bai3 : Form
    {
        private string ketQuaHienThi = "";

        public Lab2_Bai3()
        {
            InitializeComponent();
        }

        private void btnDocVaTinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.FileName = "input3.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    ketQuaHienThi = "";
                    richTextBox1.Clear();

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        try
                        {
                            double ketQua = EvaluateExpression(line);
                            // Định dạng hiển thị kết quả giống ví dụ mẫu
                            string dongKetQua = $"{line.Trim()} = {ketQua}";
                            ketQuaHienThi += dongKetQua + "\r\n";
                            richTextBox1.AppendText(dongKetQua + "\r\n");
                        }
                        catch (Exception)
                        {
                            richTextBox1.AppendText($"{line.Trim()} = Lỗi cú pháp biểu thức\r\n");
                        }
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
            if (string.IsNullOrEmpty(ketQuaHienThi))
            {
                MessageBox.Show("Chưa có kết quả tính toán để ghi file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfd.FileName = "output3.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(sfd.FileName, ketQuaHienThi);
                    MessageBox.Show("Đã ghi kết quả xuống file output3.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm tính toán biểu thức không dùng DataTable.Compute (Thuật toán Recursive Descent Parser)
        private double EvaluateExpression(string expr)
        {
            expr = expr.Replace(" ", "");
            int pos = 0;

            double ParseExpr()
            {
                double x = ParseTerm();
                while (pos < expr.Length)
                {
                    char op = expr[pos];
                    if (op == '+') { pos++; x += ParseTerm(); }
                    else if (op == '-') { pos++; x -= ParseTerm(); }
                    else break;
                }
                return x;
            }

            double ParseTerm()
            {
                double x = ParseFactor();
                while (pos < expr.Length)
                {
                    char op = expr[pos];
                    if (op == '*') { pos++; x *= ParseFactor(); }
                    else if (op == '/')
                    {
                        pos++;
                        double divisor = ParseFactor();
                        if (divisor == 0) throw new DivideByZeroException();
                        x /= divisor;
                    }
                    else break;
                }
                return x;
            }

            double ParseFactor()
            {
                if (pos < expr.Length && expr[pos] == '(')
                {
                    pos++; // Bỏ qua dấu '('
                    double x = ParseExpr();
                    if (pos < expr.Length && expr[pos] == ')') pos++; // Bỏ qua dấu ')'
                    return x;
                }
                if (pos < expr.Length && expr[pos] == '-')
                {
                    pos++;
                    return -ParseFactor();
                }

                int start = pos;
                while (pos < expr.Length && (char.IsDigit(expr[pos]) || expr[pos] == '.'))
                {
                    pos++;
                }
                if (start == pos) throw new Exception("Biểu thức không hợp lệ tại vị trí " + pos);
                return double.Parse(expr.Substring(start, pos - start), System.Globalization.CultureInfo.InvariantCulture);
            }

            return ParseExpr();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}