using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void ChangeAccount(Account acc)
        {
            txbName.Text = LoginAccount.UserName;
            txbDisplayName.Text = LoginAccount.DisplayName;

        }
        void UpdatingAccount()
        {
            string displayName = txbDisplayName.Text;
            string password = txbPassWord.Text;
            string newPassword = txbNewPassWord.Text;
            string reenterPass = txbReenterPass.Text;
            string userName = txbName.Text;
            if (!newPassword.Equals(reenterPass))
            {
                MessageBox.Show("Nhập lại mật khẩu phải trùng khớp với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(displayName, userName, password, newPassword))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                    {
                        updateAccount(this,new AccounEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                    }
                }
                else 
                {
                    MessageBox.Show("Vui lòng nhập đúng thông tin!");
                }
            }
        }
        private event EventHandler updateAccount;
        public event EventHandler UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatingAccount();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {

        }
    }
    public class AccounEvent : EventArgs
    {
        private Account acc;
        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        public AccounEvent(Account acc)
        {
            this.acc = acc;
        }
    }
}
