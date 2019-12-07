using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QuanLiQuanCafe.DAO
{
    public class Dataprovider
    {
        private static Dataprovider instances;//đóng gói crl + r +e

        public static Dataprovider Instances
        {
            get {if(instances==null) instances = new Dataprovider(); return Dataprovider.instances; }
            private set { Dataprovider.instances = value; }
        }
        private Dataprovider(){
        
        }
       
        private string stringCon = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLiQuanCafe;User ID=sa; Password=sa2012";

        public DataTable ExcuteQuery(string query,object [] parameter=null) {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(stringCon)) {
                connection.Open();
                SqlCommand comman = new SqlCommand(query, connection);
                
                
               
                if (parameter != null) {
                    string[] para = query.Split(' ');
                    int i = 0;
                    foreach (string item in para)
                    {
                        if (item.Contains('@')) {
                            comman.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(comman);
                adapter.Fill(table);
                connection.Close();
            
            }
            return table;
           
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;//trả về số trường hợp lệ, chỉ sử dụng cho insert, update,delete
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(stringCon))
            {
                connection.Open();
                SqlCommand comman = new SqlCommand(query, connection);



                if (parameter != null)
                {
                    string[] para = query.Split(' ');
                    int i = 0;
                    foreach (string item in para)
                    {
                        if (item.Contains('@'))
                        {
                            comman.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(comman);
                data = comman.ExecuteNonQuery();
                connection.Close();

            }
            return data;

        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(stringCon))
            {
                connection.Open();
                SqlCommand comman = new SqlCommand(query, connection);



                if (parameter != null)
                {
                    string[] para = query.Split(' ');
                    int i = 0;
                    foreach (string item in para)
                    {
                        if (item.Contains('@'))
                        {
                            comman.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(comman);
                data = comman.ExecuteScalar();//phu hop voi select *
                connection.Close();

            }
            return data;

        }

    }
}
