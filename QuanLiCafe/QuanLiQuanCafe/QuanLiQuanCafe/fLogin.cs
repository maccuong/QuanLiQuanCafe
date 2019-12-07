using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiQuanCafe.DAO;

namespace QuanLiQuanCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTendangnhap.Text;
            string password = txtPassword.Text;
            if (login(username,password))
            {
                TableManager ftable = new TableManager();
                this.Hide();
                ftable.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu","Thông báo",MessageBoxButtons.OKCancel);
            }
        }
        bool login(string username, string password) {

            return AccountDAO.Instancse.Login(username,password);
        }
    }
}
