using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    internal class DBHelper
    {
        private SqlConnection _conn;
        private static DBHelper _Instance;
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string s = @"Data Source=LAPTOP-VOUN1RK2\CVTHNGA;Initial Catalog=PBL3;Integrated Security=True;Trust Server Certificate=True";
                    _Instance = new DBHelper(s);
                }
                return _Instance;
            }
            private set { }
        }
        private DBHelper(string s)
        {
            _conn = new SqlConnection(s);
        }
        public DataTable GetRecord(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter(query, _conn);
            _conn.Open();
            adt.Fill(dt);
            _conn.Close();
            return dt;
        }
        public void ExcuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _conn);
            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }


    }
}
