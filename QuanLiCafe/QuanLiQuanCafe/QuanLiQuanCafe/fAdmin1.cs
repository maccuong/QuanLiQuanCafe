using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLiQuanCafe.DAO;


namespace QuanLiQuanCafe
{
    public partial class fAdmin1 : Form
    {
        public fAdmin1()
        {
            InitializeComponent();
            LoadAccount();
        }
        public void LoadAccount() {
            string query = "EXEC dbo.GetAccountByUsername @username ";
            
            dgvtaiKhoan.DataSource=Dataprovider.Instances.ExcuteQuery(query, new object[]{"kimthoa","chicuong"});
        }
        public void Loadfood()
        {
            string query = "SELECT * FROM dbo.food";

            dgvfood.DataSource = Dataprovider.Instances.ExcuteNonQuery(query, new object[]{});
        }
    }
}
