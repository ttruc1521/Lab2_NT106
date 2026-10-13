using System;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2_Bai7 : Form
    {
        public Lab2_Bai7()
        {
            InitializeComponent();
            LoadDirectories();
        }

        // Tải danh sách các ổ đĩa trên máy tính vào TreeView khi khởi động
        private void LoadDirectories()
        {
            treeViewDir.Nodes.Clear();
            string[] drives = Directory.GetLogicalDrives();

            foreach (string drive in drives)
            {
                TreeNode node = new TreeNode(drive);
                node.Tag = drive;
                // Thêm một node giả lập để hiển thị dấu cộng mở rộng thư mục
                node.Nodes.Add("...");
                treeViewDir.Nodes.Add(node);
            }
        }

        // Sự kiện mở rộng thư mục khi người dùng bấm dấu cộng hoặc nhấp đúp
        private void treeViewDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode currentNode = e.Node;
            currentNode.Nodes.Clear();

            string dirPath = currentNode.Tag?.ToString();
            if (string.IsNullOrEmpty(dirPath)) return;

            try
            {
                // Nạp các thư mục con
                string[] subDirs = Directory.GetDirectories(dirPath);
                foreach (string subDir in subDirs)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(subDir);
                    // Bỏ qua các thư mục hệ thống ẩn nếu cần
                    if ((dirInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) continue;

                    TreeNode subNode = new TreeNode(dirInfo.Name);
                    subNode.Tag = subDir;
                    subNode.Nodes.Add("..."); // Node giả lập thư mục con
                    currentNode.Nodes.Add(subNode);
                }

                // Nạp các file trong thư mục
                string[] files = Directory.GetFiles(dirPath);
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    TreeNode fileNode = new TreeNode(fileInfo.Name);
                    fileNode.Tag = file;
                    currentNode.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Xử lý trường hợp không có quyền truy cập ổ đĩa/thư mục hệ thống
                currentNode.Nodes.Add("Access Denied");
            }
            catch (Exception)
            {
                // Bỏ qua các lỗi ngoại lệ khác khi duyệt file
            }
        }

        // Sự kiện khi người dùng nhấp chọn vào một Node (Thư mục hoặc File)
        private void treeViewDir_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag?.ToString();
            if (string.IsNullOrEmpty(path)) return;

            // Nếu là File, tiến hành đọc và hiển thị nội dung tùy theo định dạng
            if (File.Exists(path))
            {
                string extension = Path.GetExtension(path).ToLower();

                // Kiểm tra nếu là file hình ảnh (.jpg, .png, .jpeg, .bmp)
                if (extension == ".jpg" || extension == ".png" || extension == ".jpeg" || extension == ".bmp")
                {
                    try
                    {
                        richTextBoxContent.Visible = false;
                        pictureBoxContent.Visible = true;
                        if (pictureBoxContent.Image != null)
                        {
                            pictureBoxContent.Image.Dispose();
                        }
                        pictureBoxContent.Image = System.Drawing.Image.FromFile(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Các file văn bản thông thường (.txt, .log, v.v.)
                {
                    try
                    {
                        pictureBoxContent.Visible = false;
                        richTextBoxContent.Visible = true;
                        string content = File.ReadAllText(path);
                        richTextBoxContent.Text = content;
                    }
                    catch (Exception)
                    {
                        pictureBoxContent.Visible = false;
                        richTextBoxContent.Visible = true;
                        richTextBoxContent.Text = "(Không thể đọc nội dung file nhị phân hoặc file đang được sử dụng)";
                    }
                }
            }
            else if (Directory.Exists(path))
            {
                // Nếu là thư mục, hiển thị đường dẫn vào khung nội dung
                pictureBoxContent.Visible = false;
                richTextBoxContent.Visible = true;
                richTextBoxContent.Text = "[Thư mục]: " + path;
            }
        }
    }
}