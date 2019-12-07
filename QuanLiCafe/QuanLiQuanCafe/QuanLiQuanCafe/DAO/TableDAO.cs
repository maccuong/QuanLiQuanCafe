using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLiQuanCafe.DAO;
using System.Data.SqlClient;

namespace QuanLiQuanCafe.DAO
{
    class TableDAO
    {
        private static TableDAO instances;
        public static int tableWidth=100;
        public static int TableHeight=100;
        internal static TableDAO Instances
        {
            get { if (instances == null)instances = new TableDAO(); return TableDAO.instances; }
            private set { TableDAO.instances = value; }
        
        }
        public List<Table> LoadTable() {
            List<Table> tabelist = new List<Table>();
            DataTable data = Dataprovider.Instances.ExcuteQuery("dbo.USP_Tablefood");


            foreach (DataRow item in data.Rows) {
                Table table = new Table(item);
                tabelist.Add(table);
            }

            return tabelist;
        }
    }
}
