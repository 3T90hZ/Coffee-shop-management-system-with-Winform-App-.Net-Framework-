namespace QuanLyQuanCafe
{
    partial class fAdmin
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
            tpAccount = new TabPage();
            panel13 = new Panel();
            btnResetPassWord = new Button();
            panel22 = new Panel();
            cbAccountType = new ComboBox();
            label4 = new Label();
            panel23 = new Panel();
            txbDisplayName = new TextBox();
            label10 = new Label();
            panel25 = new Panel();
            txbUserName = new TextBox();
            label11 = new Label();
            panel26 = new Panel();
            dtgvAccount = new DataGridView();
            panel27 = new Panel();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            tpTable = new TabPage();
            panel12 = new Panel();
            panel17 = new Panel();
            txbTableStatus = new TextBox();
            label5 = new Label();
            panel18 = new Panel();
            txbTableName = new TextBox();
            label8 = new Label();
            panel20 = new Panel();
            txbTableID = new TextBox();
            label9 = new Label();
            panel21 = new Panel();
            dtgvTable = new DataGridView();
            panel24 = new Panel();
            btnEditTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            tpFoodCategory = new TabPage();
            panel11 = new Panel();
            panel14 = new Panel();
            txbCategoryName = new TextBox();
            label6 = new Label();
            panel15 = new Panel();
            txbCategoryID = new TextBox();
            label7 = new Label();
            panel16 = new Panel();
            dtgvCategory = new DataGridView();
            panel19 = new Panel();
            btnEditCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            tpFood = new TabPage();
            panel6 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label3 = new Label();
            panel9 = new Panel();
            cbCategory = new ComboBox();
            label2 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label1 = new Label();
            panel7 = new Panel();
            txbFoodID = new TextBox();
            lblFoodID = new Label();
            panel4 = new Panel();
            dtgvFood = new DataGridView();
            panel3 = new Panel();
            btnSearchFoodName = new Button();
            txbSearchFoodName = new TextBox();
            panel5 = new Panel();
            panel2 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            tpBill = new TabPage();
            btnReconciliation = new Button();
            label12 = new Label();
            txbMaxIndex = new TextBox();
            txbPgIndex = new TextBox();
            btnLastPg = new Button();
            btnNextPg = new Button();
            btnPreviousPg = new Button();
            btnFirstPg = new Button();
            dtgvBill = new DataGridView();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            tcAdmin = new TabControl();
            tpAccount.SuspendLayout();
            panel13.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel27.SuspendLayout();
            tpTable.SuspendLayout();
            panel12.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            panel24.SuspendLayout();
            tpFoodCategory.SuspendLayout();
            panel11.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel19.SuspendLayout();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tcAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel13);
            tpAccount.Controls.Add(panel26);
            tpAccount.Controls.Add(panel27);
            tpAccount.Location = new Point(4, 29);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(852, 444);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnResetPassWord);
            panel13.Controls.Add(panel22);
            panel13.Controls.Add(panel23);
            panel13.Controls.Add(panel25);
            panel13.Location = new Point(432, 73);
            panel13.Name = "panel13";
            panel13.Size = new Size(414, 365);
            panel13.TabIndex = 0;
            // 
            // btnResetPassWord
            // 
            btnResetPassWord.Location = new Point(314, 184);
            btnResetPassWord.Name = "btnResetPassWord";
            btnResetPassWord.Size = new Size(97, 55);
            btnResetPassWord.TabIndex = 3;
            btnResetPassWord.Text = "Đặt lại mật khẩu";
            btnResetPassWord.UseVisualStyleBackColor = true;
            btnResetPassWord.Click += btnResetPassWord_Click;
            // 
            // panel22
            // 
            panel22.Controls.Add(cbAccountType);
            panel22.Controls.Add(label4);
            panel22.Location = new Point(6, 124);
            panel22.Name = "panel22";
            panel22.Size = new Size(408, 54);
            panel22.TabIndex = 2;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(152, 14);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(253, 28);
            cbAccountType.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 14);
            label4.Name = "label4";
            label4.Size = new Size(150, 24);
            label4.TabIndex = 0;
            label4.Text = "Loại tài khoản:";
            // 
            // panel23
            // 
            panel23.Controls.Add(txbDisplayName);
            panel23.Controls.Add(label10);
            panel23.Location = new Point(3, 64);
            panel23.Name = "panel23";
            panel23.Size = new Size(408, 54);
            panel23.TabIndex = 1;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(155, 11);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(250, 27);
            txbDisplayName.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 14);
            label10.Name = "label10";
            label10.Size = new Size(129, 24);
            label10.TabIndex = 0;
            label10.Text = "Tên hiển thị:";
            // 
            // panel25
            // 
            panel25.Controls.Add(txbUserName);
            panel25.Controls.Add(label11);
            panel25.Location = new Point(3, 4);
            panel25.Name = "panel25";
            panel25.Size = new Size(408, 54);
            panel25.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(155, 11);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(250, 27);
            txbUserName.TabIndex = 1;
            txbUserName.TextChanged += txbUserName_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 14);
            label11.Name = "label11";
            label11.Size = new Size(146, 24);
            label11.TabIndex = 0;
            label11.Text = "Tên tài khoản:";
            label11.Click += label11_Click;
            // 
            // panel26
            // 
            panel26.Controls.Add(dtgvAccount);
            panel26.Location = new Point(9, 73);
            panel26.Name = "panel26";
            panel26.Size = new Size(417, 365);
            panel26.TabIndex = 2;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 4);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(411, 358);
            dtgvAccount.TabIndex = 8;
            dtgvAccount.CellContentClick += dtgvAccount_CellContentClick;
            // 
            // panel27
            // 
            panel27.Controls.Add(btnDeleteAccount);
            panel27.Controls.Add(btnAddAccount);
            panel27.Location = new Point(6, 6);
            panel27.Name = "panel27";
            panel27.Size = new Size(420, 61);
            panel27.TabIndex = 1;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(106, 3);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(97, 55);
            btnDeleteAccount.TabIndex = 2;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(3, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(97, 55);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel12);
            tpTable.Controls.Add(panel21);
            tpTable.Controls.Add(panel24);
            tpTable.Location = new Point(4, 29);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(852, 444);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel17);
            panel12.Controls.Add(panel18);
            panel12.Controls.Add(panel20);
            panel12.Location = new Point(432, 73);
            panel12.Name = "panel12";
            panel12.Size = new Size(414, 365);
            panel12.TabIndex = 0;
            // 
            // panel17
            // 
            panel17.Controls.Add(txbTableStatus);
            panel17.Controls.Add(label5);
            panel17.Location = new Point(6, 124);
            panel17.Name = "panel17";
            panel17.Size = new Size(408, 54);
            panel17.TabIndex = 2;
            // 
            // txbTableStatus
            // 
            txbTableStatus.Location = new Point(118, 14);
            txbTableStatus.Name = "txbTableStatus";
            txbTableStatus.ReadOnly = true;
            txbTableStatus.Size = new Size(284, 27);
            txbTableStatus.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 14);
            label5.Name = "label5";
            label5.Size = new Size(113, 24);
            label5.TabIndex = 0;
            label5.Text = "Trạng thái:";
            // 
            // panel18
            // 
            panel18.Controls.Add(txbTableName);
            panel18.Controls.Add(label8);
            panel18.Location = new Point(3, 64);
            panel18.Name = "panel18";
            panel18.Size = new Size(408, 54);
            panel18.TabIndex = 1;
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(121, 11);
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(284, 27);
            txbTableName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 14);
            label8.Name = "label8";
            label8.Size = new Size(94, 24);
            label8.TabIndex = 0;
            label8.Text = "Tên bàn:";
            // 
            // panel20
            // 
            panel20.Controls.Add(txbTableID);
            panel20.Controls.Add(label9);
            panel20.Location = new Point(3, 4);
            panel20.Name = "panel20";
            panel20.Size = new Size(408, 54);
            panel20.TabIndex = 0;
            // 
            // txbTableID
            // 
            txbTableID.Location = new Point(121, 11);
            txbTableID.Name = "txbTableID";
            txbTableID.ReadOnly = true;
            txbTableID.Size = new Size(284, 27);
            txbTableID.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 14);
            label9.Name = "label9";
            label9.Size = new Size(36, 24);
            label9.TabIndex = 0;
            label9.Text = "ID:";
            // 
            // panel21
            // 
            panel21.Controls.Add(dtgvTable);
            panel21.Location = new Point(9, 73);
            panel21.Name = "panel21";
            panel21.Size = new Size(417, 365);
            panel21.TabIndex = 2;
            // 
            // dtgvTable
            // 
            dtgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(3, 4);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.Size = new Size(411, 358);
            dtgvTable.TabIndex = 7;
            // 
            // panel24
            // 
            panel24.Controls.Add(btnEditTable);
            panel24.Controls.Add(btnDeleteTable);
            panel24.Controls.Add(btnAddTable);
            panel24.Location = new Point(6, 6);
            panel24.Name = "panel24";
            panel24.Size = new Size(420, 61);
            panel24.TabIndex = 1;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(209, 3);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(97, 55);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            btnEditTable.Click += btnEditTable_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(106, 3);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(97, 55);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(3, 3);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(97, 55);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel11);
            tpFoodCategory.Controls.Add(panel16);
            tpFoodCategory.Controls.Add(panel19);
            tpFoodCategory.Location = new Point(4, 29);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(852, 444);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Danh mục";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel14);
            panel11.Controls.Add(panel15);
            panel11.Location = new Point(432, 73);
            panel11.Name = "panel11";
            panel11.Size = new Size(414, 365);
            panel11.TabIndex = 0;
            // 
            // panel14
            // 
            panel14.Controls.Add(txbCategoryName);
            panel14.Controls.Add(label6);
            panel14.Location = new Point(3, 64);
            panel14.Name = "panel14";
            panel14.Size = new Size(408, 54);
            panel14.TabIndex = 1;
            // 
            // txbCategoryName
            // 
            txbCategoryName.Location = new Point(161, 11);
            txbCategoryName.Name = "txbCategoryName";
            txbCategoryName.Size = new Size(244, 27);
            txbCategoryName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 14);
            label6.Name = "label6";
            label6.Size = new Size(152, 24);
            label6.TabIndex = 0;
            label6.Text = "Tên danh mục:";
            // 
            // panel15
            // 
            panel15.Controls.Add(txbCategoryID);
            panel15.Controls.Add(label7);
            panel15.Location = new Point(3, 4);
            panel15.Name = "panel15";
            panel15.Size = new Size(408, 54);
            panel15.TabIndex = 0;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(161, 14);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(244, 27);
            txbCategoryID.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 14);
            label7.Name = "label7";
            label7.Size = new Size(36, 24);
            label7.TabIndex = 0;
            label7.Text = "ID:";
            // 
            // panel16
            // 
            panel16.Controls.Add(dtgvCategory);
            panel16.Location = new Point(9, 73);
            panel16.Name = "panel16";
            panel16.Size = new Size(417, 365);
            panel16.TabIndex = 2;
            // 
            // dtgvCategory
            // 
            dtgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 4);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.Size = new Size(411, 358);
            dtgvCategory.TabIndex = 6;
            // 
            // panel19
            // 
            panel19.Controls.Add(btnEditCategory);
            panel19.Controls.Add(btnDeleteCategory);
            panel19.Controls.Add(btnAddCategory);
            panel19.Location = new Point(6, 6);
            panel19.Name = "panel19";
            panel19.Size = new Size(420, 61);
            panel19.TabIndex = 1;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(209, 3);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(97, 55);
            btnEditCategory.TabIndex = 3;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(106, 3);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(97, 55);
            btnDeleteCategory.TabIndex = 2;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(3, 3);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(97, 55);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Controls.Add(panel2);
            tpFood.Location = new Point(4, 29);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(852, 444);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(432, 73);
            panel6.Name = "panel6";
            panel6.Size = new Size(414, 365);
            panel6.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label3);
            panel10.Location = new Point(6, 184);
            panel10.Name = "panel10";
            panel10.Size = new Size(408, 54);
            panel10.TabIndex = 3;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(118, 11);
            nmFoodPrice.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(287, 27);
            nmFoodPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 14);
            label3.Name = "label3";
            label3.Size = new Size(49, 24);
            label3.TabIndex = 0;
            label3.Text = "Giá:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbCategory);
            panel9.Controls.Add(label2);
            panel9.Location = new Point(6, 124);
            panel9.Name = "panel9";
            panel9.Size = new Size(408, 54);
            panel9.TabIndex = 2;
            // 
            // cbCategory
            // 
            cbCategory.Location = new Point(118, 14);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(287, 28);
            cbCategory.TabIndex = 2;
            cbCategory.TextChanged += cbCategory_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 0;
            label2.Text = "Danh mục:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(3, 64);
            panel8.Name = "panel8";
            panel8.Size = new Size(408, 54);
            panel8.TabIndex = 1;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(121, 11);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(284, 27);
            txbFoodName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên món:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbFoodID);
            panel7.Controls.Add(lblFoodID);
            panel7.Location = new Point(3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(408, 54);
            panel7.TabIndex = 0;
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(121, 11);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(284, 27);
            txbFoodID.TabIndex = 0;
            txbFoodID.TabStop = false;
            txbFoodID.TextChanged += txbFoodID_TextChanged;
            // 
            // lblFoodID
            // 
            lblFoodID.AutoSize = true;
            lblFoodID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodID.Location = new Point(3, 14);
            lblFoodID.Name = "lblFoodID";
            lblFoodID.Size = new Size(36, 24);
            lblFoodID.TabIndex = 0;
            lblFoodID.Text = "ID:";
            lblFoodID.Click += lblID_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtgvFood);
            panel4.Location = new Point(9, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(417, 365);
            panel4.TabIndex = 3;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 4);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.Size = new Size(411, 358);
            dtgvFood.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSearchFoodName);
            panel3.Controls.Add(txbSearchFoodName);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(432, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 61);
            panel3.TabIndex = 0;
            // 
            // btnSearchFoodName
            // 
            btnSearchFoodName.Location = new Point(311, 3);
            btnSearchFoodName.Name = "btnSearchFoodName";
            btnSearchFoodName.Size = new Size(97, 55);
            btnSearchFoodName.TabIndex = 1;
            btnSearchFoodName.Text = "Tìm";
            btnSearchFoodName.UseVisualStyleBackColor = true;
            btnSearchFoodName.Click += btnSearchFoodName_Click;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(3, 17);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(302, 27);
            txbSearchFoodName.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(417, 364);
            panel5.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnShowFood);
            panel2.Controls.Add(btnEditFood);
            panel2.Controls.Add(btnDeleteFood);
            panel2.Controls.Add(btnAddFood);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 61);
            panel2.TabIndex = 2;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(312, 3);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(97, 55);
            btnShowFood.TabIndex = 9;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            btnShowFood.Click += btnShowFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(209, 3);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(97, 55);
            btnEditFood.TabIndex = 8;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(106, 3);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(97, 55);
            btnDeleteFood.TabIndex = 7;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(3, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(97, 55);
            btnAddFood.TabIndex = 6;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(btnReconciliation);
            tpBill.Controls.Add(label12);
            tpBill.Controls.Add(txbMaxIndex);
            tpBill.Controls.Add(txbPgIndex);
            tpBill.Controls.Add(btnLastPg);
            tpBill.Controls.Add(btnNextPg);
            tpBill.Controls.Add(btnPreviousPg);
            tpBill.Controls.Add(btnFirstPg);
            tpBill.Controls.Add(dtgvBill);
            tpBill.Controls.Add(btnViewBill);
            tpBill.Controls.Add(dtpkToDate);
            tpBill.Controls.Add(dtpkFromDate);
            tpBill.Location = new Point(4, 29);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(852, 444);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // btnReconciliation
            // 
            btnReconciliation.Location = new Point(433, 6);
            btnReconciliation.Name = "btnReconciliation";
            btnReconciliation.Size = new Size(126, 27);
            btnReconciliation.TabIndex = 11;
            btnReconciliation.Text = "Thống Kê";
            btnReconciliation.UseVisualStyleBackColor = true;
            btnReconciliation.Click += btnReconciliation_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(417, 407);
            label12.Name = "label12";
            label12.Size = new Size(20, 28);
            label12.TabIndex = 10;
            label12.Text = "/";
            // 
            // txbMaxIndex
            // 
            txbMaxIndex.Location = new Point(438, 411);
            txbMaxIndex.Name = "txbMaxIndex";
            txbMaxIndex.ReadOnly = true;
            txbMaxIndex.Size = new Size(56, 27);
            txbMaxIndex.TabIndex = 9;
            txbMaxIndex.Text = "1";
            txbMaxIndex.TextAlign = HorizontalAlignment.Center;
            // 
            // txbPgIndex
            // 
            txbPgIndex.Location = new Point(355, 411);
            txbPgIndex.Name = "txbPgIndex";
            txbPgIndex.Size = new Size(56, 27);
            txbPgIndex.TabIndex = 8;
            txbPgIndex.Text = "1";
            txbPgIndex.TextAlign = HorizontalAlignment.Center;
            txbPgIndex.TextChanged += txbPgIndex_TextChanged;
            // 
            // btnLastPg
            // 
            btnLastPg.Location = new Point(752, 409);
            btnLastPg.Name = "btnLastPg";
            btnLastPg.Size = new Size(94, 29);
            btnLastPg.TabIndex = 7;
            btnLastPg.Text = "Cuối";
            btnLastPg.UseVisualStyleBackColor = true;
            btnLastPg.Click += btnLastPg_Click;
            // 
            // btnNextPg
            // 
            btnNextPg.Location = new Point(652, 409);
            btnNextPg.Name = "btnNextPg";
            btnNextPg.Size = new Size(94, 29);
            btnNextPg.TabIndex = 6;
            btnNextPg.Text = "Sau";
            btnNextPg.UseVisualStyleBackColor = true;
            btnNextPg.Click += btnNextPg_Click;
            // 
            // btnPreviousPg
            // 
            btnPreviousPg.Location = new Point(106, 409);
            btnPreviousPg.Name = "btnPreviousPg";
            btnPreviousPg.Size = new Size(94, 29);
            btnPreviousPg.TabIndex = 5;
            btnPreviousPg.Text = "Trước";
            btnPreviousPg.UseVisualStyleBackColor = true;
            btnPreviousPg.Click += btnPreviousPg_Click;
            // 
            // btnFirstPg
            // 
            btnFirstPg.Location = new Point(6, 409);
            btnFirstPg.Name = "btnFirstPg";
            btnFirstPg.Size = new Size(94, 29);
            btnFirstPg.TabIndex = 4;
            btnFirstPg.Text = "Đầu";
            btnFirstPg.UseVisualStyleBackColor = true;
            btnFirstPg.Click += btnFirstPg_Click;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(6, 39);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.Size = new Size(840, 366);
            dtgvBill.TabIndex = 3;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(301, 6);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(126, 27);
            btnViewBill.TabIndex = 0;
            btnViewBill.Text = "Xem hóa đơn";
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(579, 6);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(267, 27);
            dtpkToDate.TabIndex = 2;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(6, 6);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(267, 27);
            dtpkFromDate.TabIndex = 1;
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpFoodCategory);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tpAccount);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(860, 477);
            tcAdmin.TabIndex = 0;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 501);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản trị";
            Load += fAdmin_Load;
            tpAccount.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel27.ResumeLayout(false);
            tpTable.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            panel24.ResumeLayout(false);
            tpFoodCategory.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel19.ResumeLayout(false);
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            tpBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tcAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tpAccount;
        private Panel panel13;
        private Button btnResetPassWord;
        private Panel panel22;
        private ComboBox cbAccountType;
        private Label label4;
        private Panel panel23;
        private TextBox txbDisplayName;
        private Label label10;
        private Panel panel25;
        private TextBox txbUserName;
        private Label label11;
        private Panel panel26;
        private DataGridView dtgvAccount;
        private Panel panel27;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private TabPage tpTable;
        private Panel panel12;
        private Panel panel17;
        private TextBox txbTableStatus;
        private Label label5;
        private Panel panel18;
        private TextBox txbTableName;
        private Label label8;
        private Panel panel20;
        private TextBox txbTableID;
        private Label label9;
        private Panel panel21;
        private DataGridView dtgvTable;
        private Panel panel24;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private TabPage tpFoodCategory;
        private Panel panel11;
        private Panel panel14;
        private TextBox txbCategoryName;
        private Label label6;
        private Panel panel15;
        private TextBox txbCategoryID;
        private Label label7;
        private Panel panel16;
        private DataGridView dtgvCategory;
        private Panel panel19;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private TabPage tpFood;
        private Panel panel6;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label3;
        private Panel panel9;
        private ComboBox cbCategory;
        private Label label2;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label1;
        private Panel panel7;
        private TextBox txbFoodID;
        private Label lblFoodID;
        private Panel panel4;
        private DataGridView dtgvFood;
        private Panel panel3;
        private Button btnSearchFoodName;
        private TextBox txbSearchFoodName;
        private Panel panel5;
        private Panel panel2;
        private Button btnShowFood;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private TabPage tpBill;
        private Label label12;
        private TextBox txbMaxIndex;
        private TextBox txbPgIndex;
        private Button btnLastPg;
        private Button btnNextPg;
        private Button btnPreviousPg;
        private Button btnFirstPg;
        private DataGridView dtgvBill;
        private Button btnViewBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private TabControl tcAdmin;
        private Button btnReconciliation;
    }
}