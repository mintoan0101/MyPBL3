using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccessLayer
{
    public class DBConnection
    {
        public MySqlCommand command;
        public MySqlDataReader reader;
        public MySqlDataAdapter adapter;
        public MySqlConnection connection;
        public DBConnection()
        {
            string constr = "server = localhost; user = root; pwd = 010104; database = pbl3; port = 3306";
            connection = new MySqlConnection(constr);
        }
        //Hàm trả về datatable lưu trữ database
        public DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();
            connection.Open();
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
  
        //Hàm thực thi các câu lệnh chèn, xóa, update database
        public int ExcuteData(string query)
        {
            connection.Close();
            command = new MySqlCommand(query, connection);
            connection.Open();
            int row =  command.ExecuteNonQuery();
            connection.Close();
            return row;

        }
        //HashSet lưu trữ các danh mục dữ liệu riêng biệt của 1 cột thuộc tính
        public HashSet<string> GetSeperatedDataByColumn(string table_name, string column_name)
        {
            HashSet<string> list = new HashSet<string>();
            connection.Open();
            command = new MySqlCommand("select * from " + table_name, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(column_name);
                list.Add(name);
            }
            connection.Close();
            return list;
        }
        //List lưu trữ tên các cột
        public List<string> getNameColumns(string table_name)
        {
            List<string> list = new List<string>();
            connection.Open();
            command = new MySqlCommand("show columns from " + table_name, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string column_name = reader.GetString(0);
                list.Add(column_name);
            }
            connection.Close();
            return list;
        }
        //List lưu trữ các dữ liệu của 1 cột
        public List<string> GetDataInColumn(string table_name, string column_name)
        {
            List<string> list = new List<string>();
            connection.Open();
            command = new MySqlCommand("SELECT " + column_name + " FROM " + table_name, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                list.Add(name);
            }
            connection.Close();
            return list;
        }
        //String lưu dữ liệu của 1 ô
        public string GetStringDataCell(string table_name, string column_name, string condition)
        {
            string value = "";
            connection.Open();
            command = new MySqlCommand("SELECT " + column_name + " FROM " + table_name + " WHERE " + condition, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                value = reader.GetString(0);
            }
            connection.Close();
            return value;
        }
        //String lưu dữ liệu của 1 ô bằng câu lệnh query
        public string GetStringDataCellByQueryCommand(string query)
        {
            string value = "";
            connection.Open();
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                value = reader.GetString(0);
            }
            connection.Close();
            return value;
        }
        //Double lưu dữ liệu của 1 ô bằng câu lệnh query
        public double GetDoubleDataCellByQueryCommand(string query)
        {
            double value = 0;
            connection.Open();
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                value = reader.GetDouble(0);
            }
            connection.Close();
            return value;
        }
        //Int lưu dữ liệu cửa 1 ô
        public int GetIntDataCell(string table_name, string column_name, string condition)
        {
            int value = -1;
            connection.Open();
            command = new MySqlCommand("SELECT " + column_name + " FROM " + table_name + " WHERE " + condition, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                value = reader.GetInt32(0);
            }
            connection.Close();
            return value;
        }
        //Int lưu dữ liệu cửa 1 ô
        public int GetIntDataCellByQueryCommand(string query)
        {
            int value = -1;
            connection.Open();
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                value = reader.GetInt32(0);
            }
            connection.Close();
            return value;
        }
        //Đếm bao nhiêu hàng thỏa mãn điều kiện tương ứng
        public int CountRowByCondition(string table_name, string condition)
        {
            int count = GetIntDataCellByQueryCommand("SELECT COUNT(*) FROM " + table_name + " " + condition);
            return count;
        }
        //Cách lấy id cuối cùng của 1 table
        public string GetLastId(string query)
        {
            DataTable dt = this.GetData(query);
            int count = dt.Rows.Count;
            return dt.Rows[count-1][0].ToString();
        }
        //Hàm đếm số lượng hàng của 1 table
        public int CountRows(string query)
        {
            DataTable dt = this.GetData(query);
           
            return dt.Rows.Count;
        }
    }
}
