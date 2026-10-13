namespace Lab2
{
    partial class Lab2_Bai2
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
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblLineCount = new System.Windows.Forms.Label();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.lblWordsCount = new System.Windows.Forms.Label();
            this.txtWordsCount = new System.Windows.Forms.TextBox();
            this.lblCharacterCount = new System.Windows.Forms.Label();
            this.txtCharacterCount = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();

            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnReadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReadFromFile.Location = new System.Drawing.Point(30, 25);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(280, 40);
            this.btnReadFromFile.TabIndex = 0;
            this.btnReadFromFile.Text = "Read from File";
            this.btnReadFromFile.UseVisualStyleBackColor = false;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);

            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.Color.White;
            this.lblFileName.Location = new System.Drawing.Point(30, 95);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(71, 17);
            this.lblFileName.Text = "File name";

            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(140, 92);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(220, 22);

            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(30, 145);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(35, 17);
            this.lblSize.Text = "Size";

            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(140, 142);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(220, 22);

            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.ForeColor = System.Drawing.Color.White;
            this.lblUrl.Location = new System.Drawing.Point(30, 195);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(36, 17);
            this.lblUrl.Text = "URL";

            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(140, 192);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(220, 22);

            // 
            // lblLineCount
            // 
            this.lblLineCount.AutoSize = true;
            this.lblLineCount.ForeColor = System.Drawing.Color.White;
            this.lblLineCount.Location = new System.Drawing.Point(30, 245);
            this.lblLineCount.Name = "lblLineCount";
            this.lblLineCount.Size = new System.Drawing.Size(75, 17);
            this.lblLineCount.Text = "Line count";

            // 
            // txtLineCount
            // 
            this.txtLineCount.Location = new System.Drawing.Point(140, 242);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.ReadOnly = true;
            this.txtLineCount.Size = new System.Drawing.Size(220, 22);

            // 
            // lblWordsCount
            // 
            this.lblWordsCount.AutoSize = true;
            this.lblWordsCount.ForeColor = System.Drawing.Color.White;
            this.lblWordsCount.Location = new System.Drawing.Point(30, 295);
            this.lblWordsCount.Name = "lblWordsCount";
            this.lblWordsCount.Size = new System.Drawing.Size(91, 17);
            this.lblWordsCount.Text = "Words count";

            // 
            // txtWordsCount
            // 
            this.txtWordsCount.Location = new System.Drawing.Point(140, 292);
            this.txtWordsCount.Name = "txtWordsCount";
            this.txtWordsCount.ReadOnly = true;
            this.txtWordsCount.Size = new System.Drawing.Size(220, 22);

            // 
            // lblCharacterCount
            // 
            this.lblCharacterCount.AutoSize = true;
            this.lblCharacterCount.ForeColor = System.Drawing.Color.White;
            this.lblCharacterCount.Location = new System.Drawing.Point(30, 345);
            this.lblCharacterCount.Name = "lblCharacterCount";
            this.lblCharacterCount.Size = new System.Drawing.Size(111, 17);
            this.lblCharacterCount.Text = "Character count";

            // 
            // txtCharacterCount
            // 
            this.txtCharacterCount.Location = new System.Drawing.Point(140, 342);
            this.txtCharacterCount.Name = "txtCharacterCount";
            this.txtCharacterCount.ReadOnly = true;
            this.txtCharacterCount.Size = new System.Drawing.Size(220, 22);

            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(128, 255, 0);
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(30, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(330, 35);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.richTextBoxContent.ForeColor = System.Drawing.Color.Cyan;
            this.richTextBoxContent.Location = new System.Drawing.Point(390, 25);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.ReadOnly = true;
            this.richTextBoxContent.Size = new System.Drawing.Size(430, 410);
            this.richTextBoxContent.TabIndex = 14;
            this.richTextBoxContent.Text = "";

            // 
            // Lab2_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.ClientSize = new System.Drawing.Size(850, 460);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCharacterCount);
            this.Controls.Add(this.lblCharacterCount);
            this.Controls.Add(this.txtWordsCount);
            this.Controls.Add(this.lblWordsCount);
            this.Controls.Add(this.txtLineCount);
            this.Controls.Add(this.lblLineCount);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnReadFromFile);
            this.Name = "Lab2_Bai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2 - Bài 02";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblLineCount;
        private System.Windows.Forms.TextBox txtLineCount;
        private System.Windows.Forms.Label lblWordsCount;
        private System.Windows.Forms.TextBox txtWordsCount;
        private System.Windows.Forms.Label lblCharacterCount;
        private System.Windows.Forms.TextBox txtCharacterCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
    }
}