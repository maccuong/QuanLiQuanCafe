using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using QuanLiQuanCafe.DAO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLiQuanCafe
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
            LoadTable();
        }
        #region method
        void LoadTable() {
           List<Table> tablelist= TableDAO.Instances.LoadTable();
           foreach (Table item in tablelist) {
               Button btn = new Button() { Width=TableDAO.tableWidth,Height=TableDAO.TableHeight};
               btn.Text = item.Name + Environment.NewLine + item.Tatus;
              
               switch(item.Tatus){

                   case "Trống": {
                       btn.BackColor = Color.DarkGreen;
                       
                       break;
                   }
                   default:
                       btn.BackColor = Color.Gold;
                       break;
               }
               fnlTable.Controls.Add(btn);
               
           }
        }
        #endregion
        #region event
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileAcount fprofile = new ProfileAcount();
            fprofile.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin1 fadmin = new fAdmin1();
            fadmin.ShowDialog();
        }
        #endregion
    }
}
