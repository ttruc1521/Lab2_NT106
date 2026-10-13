namespace Lab2 
{
    partial class Lab2_Bai3
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
            this.btnDocVaTinh = new System.Windows.Forms.Button();
            this.btnGhiFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnDocVaTinh
            // 
            this.btnDocVaTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDocVaTinh.Location = new System.Drawing.Point(30, 40);
            this.btnDocVaTinh.Name = "btnDocVaTinh";
            this.btnDocVaTinh.Size = new System.Drawing.Size(220, 60);
            this.btnDocVaTinh.TabIndex = 0;
            this.btnDocVaTinh.Text = "ĐỌC FILE & TÍNH TOÁN";
            this.btnDocVaTinh.UseVisualStyleBackColor = true;
            this.btnDocVaTinh.Click += new System.EventHandler(this.btnDocVaTinh_Click);

            // 
            // btnGhiFile
            // 
            this.btnGhiFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGhiFile.Location = new System.Drawing.Point(30, 130);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(220, 60);
            this.btnGhiFile.TabIndex = 1;
            this.btnGhiFile.Text = "GHI KẾT QUẢ RA FILE";
            this.btnGhiFile.UseVisualStyleBackColor = true;
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click);

            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.richTextBox1.Location = new System.Drawing.Point(270, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(460, 250);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";

            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(30, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 60);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // Lab2_Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 325);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnGhiFile);
            this.Controls.Add(this.btnDocVaTinh);
            this.Name = "Lab2_Bai3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2 - Bài 03: Đọc, Ghi file và tính toán";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnDocVaTinh;
        private System.Windows.Forms.Button btnGhiFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnExit;
    }
}