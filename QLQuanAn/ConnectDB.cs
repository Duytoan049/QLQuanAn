using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLQuanAn
{
    public class ConnectDB
    {
        private string connectionString = "Server=Jin\\SQLEXPRESS;Database=qlquanan;Integrated Security=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void TestConnection()
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static string USER { get; private set; } = "";

        public bool CheckLogin(string username, string password)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT hoten FROM nhanvien 
                    WHERE sdt = @username
                    AND matkhau = @password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Kiểm tra nếu có dữ liệu
                        {
                            USER = reader["hoten"].ToString(); // Lưu tên nhân viên vào biến USER
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // Hàm thực thi câu lệnh SQL
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;
            using (SqlConnection conn = new SqlConnection("Server=Jin\\SQLEXPRESS;Database=qlquanan;Integrated Security=True;"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    cmd.CommandType = CommandType.Text;

                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    }

                    conn.Open();
                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return res;
        }
        // Hàm lấy dữ liệu từ SQL
        public static void loadData(string qry, DataGridView gv, ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
            using (SqlConnection conn = new SqlConnection("Server=Jin\\SQLEXPRESS;Database=qlquanan;Integrated Security=True;"))
            
            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                    for (int i = 0; i < lb.Items.Count; i++)
                    {
                        string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                        gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                    }

                    gv.DataSource = dt;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Hàm số thứ tự
        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }
    }
}
