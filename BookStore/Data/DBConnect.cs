using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data {
    class DBConnect {

        public static int BOPHAN = 1;
        public static int ADMIN = 2;
        public static int BANHANG = 1;
        public static string TENNHANVIEN = "Dương";
        public static string MANHANVIEN = "2";

        // Tạo kết nối
        string strConnect = "Data Source=BANH-MY\\BANHMY;Initial Catalog=BANSACH;Integrated Security=True";
        SqlConnection connect = null;

        // Mở kết nối
        private void ConnectData() {
            connect = new SqlConnection(strConnect);
            if (connect.State != ConnectionState.Open)
                connect.Open();
        }

        // Đóng kết nối
        private void ConnectClose() {
            if (connect.State != ConnectionState.Closed)
                connect.Close();
            connect.Dispose();
        }

        // Thực thi câu lệnh dạng Select trả về một DataTable
        public DataTable GetData(string sql) {
            DataTable db = new DataTable();
            ConnectData();
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sql, connect);
            sqldataAdapter.Fill(db);
            ConnectClose();
            return db;
        }

        // Hàm trả về số lượng bản ghi liên quan
        public int CountRecord(string sql) {
            int numRecord = 0;
            DataTable dt = new DataTable();
            ConnectData();
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sql, connect);
            sqldataAdapter.Fill(dt);
            if (dt.Rows[0][0].ToString() != "")
                numRecord = int.Parse(dt.Rows[0][0].ToString());
            ConnectClose();
            return numRecord;
        }

        public string GetName(string sql) {
            string name = "";
            DataTable dt = new DataTable();
            ConnectData();
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sql, connect);
            sqldataAdapter.Fill(dt);
            name = dt.Rows[0][0].ToString();
            ConnectClose();
            return name;
        }


        // Hàm thực hiện lệnh Insert or Update or Delete
        public void UpdataData(string sql) {
            ConnectData();
            SqlCommand strSQL = new SqlCommand();
            strSQL.Connection = connect;
            strSQL.CommandText = sql;
            strSQL.ExecuteNonQuery();
            ConnectClose();
        }

    }
}
