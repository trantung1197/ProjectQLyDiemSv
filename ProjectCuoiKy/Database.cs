using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCuoiKy
{
    class Database
    {
        private string connectionStr = "Data Source=localhost;Initial Catalog=QuanLyDiemSinhVien_1;Integrated Security=True";
        private SqlConnection connection;
        private DataTable dt;
        private SqlCommand cmd;

        public Database()
        {
            try
            {
                connection = new SqlConnection(connectionStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connected fail: " + ex.Message);
            }
        }

        public DataTable SelectData(string sql, List<CustomParameter> parameters)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand(sql, connection);
                dt = new DataTable();

                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in parameters)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand(sql, connection);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public int Execute(string sql, List<CustomParameter> parameters)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand(sql, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var p in parameters)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi: " + ex.Message);
                return -100;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
