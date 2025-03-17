namespace QuanLyQuanCafe
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txbUserName = new TextBox();
            lblUserName = new Label();
            panel2 = new Panel();
            txbPassWord = new TextBox();
            lblPassWord = new Label();
            btnExit = new Button();
            btnLogin = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbUserName);
            panel1.Controls.Add(lblUserName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 53);
            panel1.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(161, 15);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(412, 27);
            txbUserName.TabIndex = 1;
            txbUserName.TextChanged += textBox1_TextChanged;
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
            // panel2
            // 
            panel2.Controls.Add(txbPassWord);
            panel2.Controls.Add(lblPassWord);
            panel2.Location = new Point(12, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(576, 53);
            panel2.TabIndex = 2;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(161, 15);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(412, 27);
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
            // btnExit
            // 
            btnExit.Location = new Point(494, 130);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(394, 130);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(600, 275);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += fLogin_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txbUserName;
        private Label lblUserName;
        private Panel panel2;
        private TextBox txbPassWord;
        private Label lblPassWord;
        private Button btnExit;
        private Button btnLogin;
    }
}
