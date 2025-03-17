using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QuanLyQuanCafe
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount 
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            loadTable();
            loadCategory();
            LoadComboBoxTable(cbSwitchTable);
            this.loginAccount = loginAccount;
            LoginAccount = loginAccount;
        }
        #region method
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinCáNhânToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }
        void loadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.loadTableList();
            foreach (Table table in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = table.Name + Environment.NewLine + table.Status;
                btn.Click += btn_click;
                btn.Tag = table;
                if (table.Status == "Trống")
                {
                    btn.BackColor = Color.LightBlue;
                }
                else
                {
                    btn.BackColor = Color.Red;
                }

                flpTable.Controls.Add(btn);
            }
        }
        void showBill(int id)
        {
            lvBill.Items.Clear();
            List<Menu> menus = MenuDAO.Instance.GetListMenuByTable(id);
            double TotalPrice = 0;
            foreach (Menu item in menus)
            {
                ListViewItem lsvitem = new ListViewItem(item.FoodName.ToString());
                lsvitem.SubItems.Add(item.Count.ToString());
                lsvitem.SubItems.Add(item.Price.ToString());
                lsvitem.SubItems.Add(item.TotalPrice.ToString());
                TotalPrice += item.TotalPrice;
                lvBill.Items.Add(lsvitem);
            }
            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
            txbTotalPrice.Text = TotalPrice.ToString("c2", cultureInfo);
        }
        void loadCategory()
        {
            List<Category> categories = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
        }
        void loadFoodListByCategory(int id)
        {
            List<Food> foods = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = foods;
            cbFood.DisplayMember = "Name";
        }
        #endregion

        #region Events
        void btn_click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lvBill.Tag = (sender as Button).Tag;
            showBill(tableID);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile fAccountProfile = new fAccountProfile(loginAccount);
            fAccountProfile.ShowDialog();
        }
        void f_UpdateAccount(object sender, AccounEvent e)
        {
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân ("+ e.Acc.DisplayName + ") ";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin fAdmin = new fAdmin();
            fAdmin.InsertFood += FAdmin_InsertFood;
            fAdmin.DelFood += FAdmin_DelFood;
            fAdmin.UpdateFood += FAdmin_UpdateFood;
            fAdmin.InserCategory += FAdmin_InserCategory;
            fAdmin.UpdateCategory += FAdmin_UpdateCategory;
            fAdmin.InsertTable += FAdmin_InsertTable;
            fAdmin.UpdateTable += FAdmin_UpdateTable;
            fAdmin.ShowDialog();
        }

        private void FAdmin_UpdateTable(object? sender, EventArgs e)
        {
            loadTable();
        }

        private void FAdmin_InsertTable(object? sender, EventArgs e)
        {
            loadTable();
        }

        private void FAdmin_UpdateCategory(object? sender, EventArgs e)
        {
            loadCategory();
        }

        private void FAdmin_InserCategory(object? sender, EventArgs e)
        {
            loadCategory();
        }

        private void FAdmin_DelFood(object? sender, EventArgs e)
        {
            loadFoodListByCategory((cbCategory.SelectedItem as Category).ID);
            if (lvBill.Tag != null)
            {
                showBill((lvBill.Tag as Table).ID);
                loadTable();
            }
        }

        private void FAdmin_UpdateFood(object? sender, EventArgs e)
        {
            loadFoodListByCategory((cbCategory.SelectedItem as Category).ID);
            if (lvBill.Tag != null)
            {
                showBill((lvBill.Tag as Table).ID);
            }
        }

        private void FAdmin_InsertFood(object? sender, EventArgs e)
        {
            loadFoodListByCategory((cbCategory.SelectedItem as Category).ID);
            if(lvBill.Tag != null)
            {
            showBill((lvBill.Tag as Table).ID);
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            loadFoodListByCategory(id);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            if(table != null)
            {

                int idBill = BillDAO.Instance.GetUncheckedBillIDByTable(table.ID);
                int idFood = (cbFood.SelectedItem as Food).ID;
                int count = (int)nmQuantity.Value;
                if (idBill == -1)
                {
                    BillDAO.Instance.insertBill(table.ID);
                    BillInfoDAO.Instance.insertBillInfo(BillDAO.Instance.GetMaxIDBill(), idFood, count);
                }
                else
                {
                    BillInfoDAO.Instance.insertBillInfo(idBill, idFood, count);
                }
                showBill(table.ID);
                loadTable();
            }
            else
            {
                MessageBox.Show("Hãy chọn bàn muốn thêm món!", "Thông báo");
            }
        }
        void LoadComboBoxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.loadTableList();
            cb.DisplayMember = "name";
        }
        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void CbCategory_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            if(table != null) 
            { 
                int discount = (int)nmDiscount.Value;
                int idBill = BillDAO.Instance.GetUncheckedBillIDByTable(table.ID);
                double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0], new CultureInfo("de-DE"));
                double finalTotalPrice = totalPrice - totalPrice * discount / 100;
                if (idBill != -1)
                {
                    if (MessageBox.Show(string.Format("Thanh toán hóa đơn {0}? \n Tổng tiền - (Tổng tiền / 100) x Giảm giá = {1} - {1} x {2} / 100 = {3}", table.ID, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.CheckOut(idBill, discount,(float)finalTotalPrice);
                        showBill(table.ID);
                        loadTable();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn bàn cần thanh toán!", "Thông báo");
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            if(lvBill.Tag != null)
            {
                int id1 = (lvBill.Tag as Table).ID;
                int id2 = (cbSwitchTable.SelectedItem as Table).ID;
                if (MessageBox.Show(string.Format("Bạn muốn chuyển {0} sang {1}?", (lvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name),"Thông báo",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK){
                    TableDAO.Instance.SwitchTable(id1, id2);
                    loadTable();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn bàn cần chuyển!", "Thông báo");
            }
        }

        private void txbTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
