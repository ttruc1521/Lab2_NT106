namespace Lab2
{
    partial class Lab2_Bai7
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
            this.treeViewDir = new System.Windows.Forms.TreeView();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.pictureBoxContent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContent)).BeginInit();
            this.SuspendLayout();

            // 
            // treeViewDir
            // 
            this.treeViewDir.Location = new System.Drawing.Point(30, 30);
            this.treeViewDir.Name = "treeViewDir";
            this.treeViewDir.Size = new System.Drawing.Size(320, 500);
            this.treeViewDir.TabIndex = 0;
            this.treeViewDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewDir_BeforeExpand);
            this.treeViewDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDir_AfterSelect);

            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Location = new System.Drawing.Point(370, 30);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.ReadOnly = true;
            this.richTextBoxContent.Size = new System.Drawing.Size(550, 500);
            this.richTextBoxContent.TabIndex = 1;
            this.richTextBoxContent.Text = "";

            // 
            // pictureBoxContent
            // 
            this.pictureBoxContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxContent.Location = new System.Drawing.Point(370, 30);
            this.pictureBoxContent.Name = "pictureBoxContent";
            this.pictureBoxContent.Size = new System.Drawing.Size(550, 500);
            this.pictureBoxContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxContent.TabIndex = 2;
            this.pictureBoxContent.TabStop = false;
            this.pictureBoxContent.Visible = false;

            // 
            // Lab2_Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 560);
            this.Controls.Add(this.pictureBoxContent);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.treeViewDir);
            this.Name = "Lab2_Bai7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2 - Bài 07: Duyệt thư mục";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContent)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TreeView treeViewDir;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.PictureBox pictureBoxContent;
    }
}