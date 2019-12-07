using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using QuanLiQuanCafe.DAO;


namespace QuanLiQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instancse;

        public static AccountDAO Instancse
        {
            get { if (instancse == null) instancse = new AccountDAO(); return AccountDAO.instancse; }
            private set { AccountDAO.instancse = value; }
        }
        private AccountDAO() { 
        
        }
        public bool Login(string username, string password) {
            string query = " USP_Login @username , @password";
           DataTable  result = Dataprovider.Instances.ExcuteQuery(query, new object[]{username,password});
            return result.Rows.Count>0;
        }
    }
}
