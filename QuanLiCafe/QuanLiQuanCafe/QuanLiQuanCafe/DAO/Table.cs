using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLiQuanCafe.DAO
{
    public class Table
    {
        private int iD;
        private string name;
        public Table(int id,string name,string tatus) {
            this.ID = id;
            this.Name = name;
            this.Tatus = tatus;
        }
        public Table(DataRow row) {
            this.ID = (int)row["id"];
            this.Name = row["nametable"].ToString();
            this.Tatus = row["tatus"].ToString();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string tatus;

        public string Tatus
        {
            get { return tatus; }
            set { tatus = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
