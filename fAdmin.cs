using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        BindingSource accountList = new BindingSource();
        BindingSource foodList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            btnDeleteCategory.Enabled = false;
            btnDeleteTable.Enabled = false;
            Loader();
        }
        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #region methods
        void Loader()
        {
            LoadDateTimePickerBill();
            txbMaxIndex.Text = GetNumPage().ToString();
            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;
            LoadListBillByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbPgIndex.Text));
            LoadFoodList();
            LoadCategoryFComboBox(cbCategory);
            LoadAccountTypeAComboBox(cbAccountType);
            LoadFoodCategoryList();
            LoadTableFoodList();
            LoadAccountList();
            FoodBinding();
            CategoryBinding();
            TableBinding();
            AccountBingding();
        }
        void LoadListBillByDateAndPage(DateTime checkin, DateTime checkOut, int page)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListBillByDateAndPage(checkin, checkOut, page);
        }
        private void LoadAccountList()
        {
            string q = "select * from dbo.Account";
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(q);
        }
        int GetNumPage()
        {
            int num = BillDAO.Instance.GetNumBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            int sum = num / 10;
            if (num % 10 != 0)
            {
                sum++;
            }
            return sum;
        }
        private void LoadFoodList()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        private void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkToDate.Value = today;
            dtpkFromDate.Value = dtpkFromDate.Value.AddMonths(-1);
        }
        private void LoadFoodCategoryList()
        {
            string q = "select * from dbo.FoodCategory";
            dtgvCategory.DataSource = DataProvider.Instance.ExecuteQuery(q);
        }
        private void LoadTableFoodList()
        {
            string q = "select * from dbo.TableFood";
            dtgvTable.DataSource = DataProvider.Instance.ExecuteQuery(q);
        }
        void FoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "name", true, DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "id", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("value", dtgvFood.DataSource, "price", true, DataSourceUpdateMode.Never));
        }
        void CategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        void TableBinding()
        {
            txbTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "name", true, DataSourceUpdateMode.Never));
            txbTableStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "status", true, DataSourceUpdateMode.Never));
        }
        void AccountBingding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryFComboBox(ComboBox cb)
        {
            cbCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void LoadAccountTypeAComboBox(ComboBox cb)
        {
            cbAccountType.DataSource = AccountTypeDAO.Instance.GetListAccountType();
            cbAccountType.DisplayMember = "id";
        }
        #endregion
        #region events
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            txbMaxIndex.Text = GetNumPage().ToString();
            LoadListBillByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbPgIndex.Text));
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {

            dtgvFood.DataSource = FoodDAO.Instance.GetListFood();
        }
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                string name = txbFoodName.Text;
                int id = (cbCategory.SelectedItem as Category).ID;
                float price = (float)nmFoodPrice.Value;
                int idFood = Convert.ToInt32(txbFoodID.Text);
                if (FoodDAO.Instance.UpdateFood(idFood, name, id, price))
                {
                    MessageBox.Show("Đã sửa thông tin món!");
                    LoadFoodList();
                    if (updateFood != null)
                    {
                        updateFood(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn món cần sửa thông tin!");
            }

        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int id = (cbCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            if (FoodDAO.Instance.CheckExistingFood(name))
            {
                if (FoodDAO.Instance.InsertFood(name, id, price))
                {
                    MessageBox.Show("Đã thêm món " + name + "!");
                    LoadFoodList();
                    if (insertFood != null)
                    {
                        insertFood(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!");
                }
            }

        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa món " + txbFoodName.Text + "?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int idFood = Convert.ToInt32(txbFoodID.Text);
                    if (FoodDAO.Instance.DeleteFood(idFood))
                    {
                        MessageBox.Show("Đã xóa!");
                        LoadFoodList();
                        if (delFood != null)
                        {
                            delFood(this, new EventArgs());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn món cần xóa");
            }
        }
        private void btnSearchFoodName_Click(object sender, EventArgs e)
        {
            if (FoodDAO.Instance.SearchFoodByName(txbSearchFoodName.Text) != null)
            {
                foodList.DataSource = FoodDAO.Instance.SearchFoodByName(txbSearchFoodName.Text);
            }
            else
            {
                MessageBox.Show("Không tìm thấy món!", "Thông báo");
            }
        }
        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["idCategory"].Value;
                Category cate = CategoryDAO.Instance.GetCategory(id);
                cbCategory.SelectedItem = cate;
                int index = -1;
                int i = 0;
                foreach (Category item in cbCategory.Items)
                {
                    if (item.ID == cate.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbCategory.SelectedIndex = index;
            }
        }
        #endregion
        private void cbCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            if (CategoryDAO.Instance.CheckExistingCategory(name))
            {
                MessageBox.Show("Tên danh mục đã tồn tại!");
            }
            else
            {
                if (CategoryDAO.Instance.InsertCategory(name))
                {
                    MessageBox.Show("Đã thêm danh mục " + name + "!");
                    LoadFoodCategoryList();
                    if (insertCategory != null)
                    {
                        insertCategory(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!");
                }
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (dtgvCategory.SelectedCells.Count > 0)
            {
                string name = txbCategoryName.Text;
                int id = Convert.ToInt32(txbCategoryID.Text);
                if (CategoryDAO.Instance.UpdateCategory(id, name))
                {
                    MessageBox.Show("Đã sửa danh mục!");
                    LoadFoodCategoryList();
                    if (insertCategory != null)
                    {
                        insertCategory(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!");
                }
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            if (TableDAO.Instance.CheckExistingTable(name))
            {
                MessageBox.Show("Tên bàn đã tồn tại!");
            }
            else
            {
                if (TableDAO.Instance.InsertTable(name))
                {
                    MessageBox.Show("Đã thêm " + name + "!");
                    LoadTableFoodList();
                    if (insertTable != null)
                    {
                        insertTable(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!");
                }
            }
        }
        private void btnEditTable_Click(object sender, EventArgs e)
        {
            if (dtgvTable.SelectedCells.Count > 0)
            {
                string name = txbTableName.Text;
                if (TableDAO.Instance.InsertTable(name))
                {
                    MessageBox.Show("Đã sửa " + name + "!");
                    LoadTableFoodList();
                    if (insertTable != null)
                    {
                        insertTable(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!");
                }
            }

        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            if (dtgvAccount.SelectedCells.Count > 0)
            {
                string username = (string)dtgvAccount.SelectedCells[0].OwningRow.Cells["UserName"].Value;
                Account acc = AccountDAO.Instance.GetAccountByUserName(username);
                int index = -1;
                int i = 0;
                foreach (AccountType a in cbAccountType.Items)
                {
                    if (a.ID == acc.Type)
                    {
                        break;
                    }
                    i++;
                }
                cbAccountType.SelectedIndex = i;
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = Convert.ToInt32(cbAccountType.Text);
            if (AccountDAO.Instance.CheckExistingAccount(userName))
            {
                MessageBox.Show("Tài khoản này đã tồn tại!");
            }
            else
            {
                if (AccountDAO.Instance.InsertAccount(userName, type, displayName))
                {
                    MessageBox.Show("Đã thêm tài khoản " + userName + "!");
                    LoadTableFoodList();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!");
                }
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa món " + txbFoodName.Text + "?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa món " + txbFoodName.Text + "?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    string userName = txbUserName.Text;
                    if (userName.Equals("admin") != true)
                    {
                        if (AccountDAO.Instance.DeleteAccount(userName))
                        {
                            MessageBox.Show("Đã thêm tài khoản " + userName + "!");
                            LoadTableFoodList();
                        }
                        else
                        {
                            MessageBox.Show("Đã có lỗi xảy ra!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa tài khoản này");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn tài khoản cần xóa");
                }
            }
        }

        private void btnResetPassWord_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đã đặt lại mật khẩu tài khoản " + userName + "!");
                LoadTableFoodList();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
            }
        }

        private void btnFirstPg_Click(object sender, EventArgs e)
        {
            txbPgIndex.Text = "1";
        }

        private void btnLastPg_Click(object sender, EventArgs e)
        {
            txbPgIndex.Text = GetNumPage().ToString();
        }

        private void txbPgIndex_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToUInt32(txbPgIndex.Text) > GetNumPage())
            {
                txbPgIndex.Text = GetNumPage().ToString();             
            }
            else if (Convert.ToUInt32(txbPgIndex.Text) <= 0)
            {
                txbPgIndex.Text = "1";
            }
            else
            {
                dtgvBill.DataSource = BillDAO.Instance.GetListBillByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbPgIndex.Text));
            }

        }

        private void btnPreviousPg_Click(object sender, EventArgs e)
        {
            txbPgIndex.Text = (GetNumPage() - 1).ToString();
        }

        private void btnNextPg_Click(object sender, EventArgs e)
        {
            txbPgIndex.Text = (Convert.ToInt32(txbPgIndex.Text) + 1).ToString();
        }

        void btnReconciliation_Click(object sender, EventArgs e)
        {
            DateTime from = dtpkFromDate.Value;
            DateTime to = dtpkToDate.Value;
            double rev = BillDAO.Instance.GetRevenueByDate(from, to);
            string bsName = BillInfoDAO.Instance.GetBestSellingFood(from, to);
            int bsNum = BillInfoDAO.Instance.GetNumBestSellingFood(from, to);
            string wsName = BillInfoDAO.Instance.GetWorstSellingFood(from, to);
            int wsNum = BillInfoDAO.Instance.GetNumWorstSellingFood(from, to);
            MessageBox.Show(string.Format("Trong thời gian này:\n Tổng doanh thu: {0}\n Bán chạy nhất : {1} ({2})\n Bán kém nhất: {3} ({4}) ", rev, bsName, bsNum, wsName, wsNum), "Báo cáo");
        }

        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

        private event EventHandler insertCategory;
        public event EventHandler InserCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler delCategory;
        public event EventHandler DelCategory
        {
            add { delCategory += value; }
            remove { delCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler delFood;
        public event EventHandler DelFood
        {
            add { delFood += value; }
            remove { delFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
    }
}
