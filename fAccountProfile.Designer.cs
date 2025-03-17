namespace QuanLyQuanCafe
{
    partial class fAccountProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            txbPassWord = new TextBox();
            lblPassWord = new Label();
            panel1 = new Panel();
            txbName = new TextBox();
            lblUserName = new Label();
            panel3 = new Panel();
            txbNewPassWord = new TextBox();
            lblNewPassWord = new Label();
            panel4 = new Panel();
            txbDisplayName = new TextBox();
            lblDisplayName = new Label();
            panel5 = new Panel();
            txbReenterPass = new TextBox();
            lblReenterPass = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbPassWord);
            panel2.Controls.Add(lblPassWord);
            panel2.Location = new Point(12, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 53);
            panel2.TabIndex = 2;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(188, 12);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(420, 27);
            txbPassWord.TabIndex = 2;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassWord.Location = new Point(3, 15);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(97, 24);
            lblPassWord.TabIndex = 0;
            lblPassWord.Text = "Mật khẩu";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbName);
            panel1.Controls.Add(lblUserName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 53);
            panel1.TabIndex = 0;
            // 
            // txbName
            // 
            txbName.AcceptsTab = true;
            txbName.Location = new Point(188, 15);
            txbName.Name = "txbName";
            txbName.ReadOnly = true;
            txbName.Size = new Size(417, 27);
            txbName.TabIndex = 1;
            txbName.TabStop = false;
            txbName.TextChanged += txb_TextChanged;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(3, 15);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(152, 24);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Tên đăng nhập";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbNewPassWord);
            panel3.Controls.Add(lblNewPassWord);
            panel3.Location = new Point(12, 189);
            panel3.Name = "panel3";
            panel3.Size = new Size(608, 53);
            panel3.TabIndex = 3;
            // 
            // txbNewPassWord
            // 
            txbNewPassWord.Location = new Point(188, 12);
            txbNewPassWord.Name = "txbNewPassWord";
            txbNewPassWord.Size = new Size(417, 27);
            txbNewPassWord.TabIndex = 3;
            txbNewPassWord.UseSystemPasswordChar = true;
            txbNewPassWord.TextChanged += textBox2_TextChanged;
            // 
            // lblNewPassWord
            // 
            lblNewPassWord.AutoSize = true;
            lblNewPassWord.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassWord.Location = new Point(3, 15);
            lblNewPassWord.Name = "lblNewPassWord";
            lblNewPassWord.Size = new Size(139, 24);
            lblNewPassWord.TabIndex = 0;
            lblNewPassWord.Text = "Mật khẩu mới";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbDisplayName);
            panel4.Controls.Add(lblDisplayName);
            panel4.Location = new Point(12, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(608, 53);
            panel4.TabIndex = 1;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(188, 12);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(417, 27);
            txbDisplayName.TabIndex = 1;
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayName.Location = new Point(3, 15);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(122, 24);
            lblDisplayName.TabIndex = 0;
            lblDisplayName.Text = "Tên hiển thị";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReenterPass);
            panel5.Controls.Add(lblReenterPass);
            panel5.Location = new Point(12, 248);
            panel5.Name = "panel5";
            panel5.Size = new Size(608, 53);
            panel5.TabIndex = 4;
            // 
            // txbReenterPass
            // 
            txbReenterPass.Location = new Point(188, 12);
            txbReenterPass.Name = "txbReenterPass";
            txbReenterPass.Size = new Size(417, 27);
            txbReenterPass.TabIndex = 4;
            txbReenterPass.UseSystemPasswordChar = true;
            // 
            // lblReenterPass
            // 
            lblReenterPass.AutoSize = true;
            lblReenterPass.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReenterPass.Location = new Point(3, 15);
            lblReenterPass.Name = "lblReenterPass";
            lblReenterPass.Size = new Size(179, 24);
            lblReenterPass.TabIndex = 0;
            lblReenterPass.Text = "Nhập lại mật khẩu";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(423, 307);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(523, 307);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(632, 352);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "fAccountProfile";
            Text = "Thông tin tài khoản";
            Load += fAccountProfile_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbPassWord;
        private Label lblPassWord;
        private Panel panel1;
        private TextBox txbName;
        private Label lblUserName;
        private Panel panel3;
        private TextBox txbNewPassWord;
        private Label lblNewPassWord;
        private Panel panel4;
        private TextBox txbDisplayName;
        private Label lblDisplayName;
        private Panel panel5;
        private TextBox txbReenterPass;
        private Label lblReenterPass;
        private Button btnUpdate;
        private Button btnExit;
    }
}