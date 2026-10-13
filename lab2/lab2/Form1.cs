using Lab2;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện mở Bài 1
        private void btnBai1_Click(object sender, EventArgs e)
        {
            Lab2_Bai1 f = new Lab2_Bai1();
            f.ShowDialog();
        }

        // Sự kiện mở Bài 2
        private void btnBai2_Click(object sender, EventArgs e)
        {
            Lab2_Bai2 f = new Lab2_Bai2();
            f.ShowDialog();
        }

        // Sự kiện mở Bài 3
        private void btnBai3_Click(object sender, EventArgs e)
        {
            Lab2_Bai3 f = new Lab2_Bai3();
            f.ShowDialog();
        }

        // Sự kiện mở Bài 4
        private void btnBai4_Click(object sender, EventArgs e)
        {
            Lab2_Bai4 f = new Lab2_Bai4();
            f.ShowDialog();
        }

        // Sự kiện mở Bài 5
        private void btnBai5_Click(object sender, EventArgs e)
        {
            Lab2_Bai5 f = new Lab2_Bai5();
            f.ShowDialog();
        }

        // Sự kiện mở Bài 6
        private void btnBai6_Click(object sender, EventArgs e)
        {
            Lab2_Bai6 f = new Lab2_Bai6();
            f.ShowDialog();
        }

        // Sự kiện mở Bài 7
        private void btnBai7_Click(object sender, EventArgs e)
        {
            Lab2_Bai7 f = new Lab2_Bai7();
            f.ShowDialog();
        }

        // Nút Thoát chương trình
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}