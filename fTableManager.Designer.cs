namespace QuanLyQuanCafe
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            nmQuantity = new NumericUpDown();
            label1 = new Label();
            btnAdd = new Button();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            panel4 = new Panel();
            cbSwitchTable = new ComboBox();
            txbTotalPrice = new TextBox();
            btnCheckOut = new Button();
            btnDiscount = new Button();
            nmDiscount = new NumericUpDown();
            btnSwitchTable = new Button();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmQuantity).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinCáNhânToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1116, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem });
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(141, 24);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lvBill);
            panel2.Location = new Point(623, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(481, 422);
            panel2.TabIndex = 2;
            // 
            // lvBill
            // 
            lvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvBill.GridLines = true;
            lvBill.Location = new Point(3, 3);
            lvBill.Name = "lvBill";
            lvBill.Size = new Size(475, 416);
            lvBill.TabIndex = 0;
            lvBill.UseCompatibleStateImageBehavior = false;
            lvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 100;
            // 
            // panel3
            // 
            panel3.Controls.Add(nmQuantity);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(cbFood);
            panel3.Controls.Add(cbCategory);
            panel3.Location = new Point(623, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(481, 77);
            panel3.TabIndex = 0;
            // 
            // nmQuantity
            // 
            nmQuantity.Location = new Point(393, 4);
            nmQuantity.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmQuantity.Name = "nmQuantity";
            nmQuantity.Size = new Size(85, 27);
            nmQuantity.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 6);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Số lượng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(318, 36);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 28);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm món";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(3, 37);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(309, 28);
            cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(309, 28);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            cbCategory.SelectedValueChanged += CbCategory_SelectedValueChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbSwitchTable);
            panel4.Controls.Add(txbTotalPrice);
            panel4.Controls.Add(btnCheckOut);
            panel4.Controls.Add(btnDiscount);
            panel4.Controls.Add(nmDiscount);
            panel4.Controls.Add(btnSwitchTable);
            panel4.Location = new Point(623, 546);
            panel4.Name = "panel4";
            panel4.Size = new Size(478, 72);
            panel4.TabIndex = 3;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(3, 8);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(122, 28);
            cbSwitchTable.TabIndex = 8;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbTotalPrice.Location = new Point(229, 21);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(136, 28);
            txbTotalPrice.TabIndex = 7;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            txbTotalPrice.TextChanged += txbTotalPrice_TextChanged;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(371, 8);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(97, 57);
            btnCheckOut.TabIndex = 6;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(131, 40);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(92, 25);
            btnDiscount.TabIndex = 5;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(131, 8);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(92, 27);
            nmDiscount.TabIndex = 4;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(0, 36);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(125, 29);
            btnSwitchTable.TabIndex = 3;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = true;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 35);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(605, 583);
            flpTable.TabIndex = 4;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 630);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý quán";
            Load += fTableManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmQuantity).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private NumericUpDown nmQuantity;
        private Label label1;
        private Button btnAdd;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private Panel panel4;
        private Button btnCheckOut;
        private Button btnDiscount;
        private NumericUpDown nmDiscount;
        private ListView lvBill;
        private FlowLayoutPanel flpTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
        private Button btnSwitchTable;
        private ComboBox cbSwitchTable;
    }
}