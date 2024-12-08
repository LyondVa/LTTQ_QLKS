using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace Hotel
{
    public class function : IFunction
    {
        public string dtbName = "";
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + dtbName + ";Initial Catalog=QLKS;Integrated Security=True;;Connection Timeout=5";
            return con;
        }
        //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DTB\QLKS_Remote.mdf;Integrated Security=True";
        //Data Source=DESKTOP-QEN4LJI ;Initial Catalog=QLKS;Integrated Security=True
        public int TestConnection()
        {
            SqlConnection con = getConnection();
            try
            {
                con.Open();
                con.Close();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public virtual DataSet getData(string query)
        {
            try
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public virtual void setData(string query, string message)
        {
            try
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public virtual void setDataNoMsg(string query)
        {
            try
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
        public void ToExcel(DataGridView dataGridView, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = null;
            Worksheet worksheet = null;

            try
            {
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Quản lý khách hàng";

                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                workbook.SaveAs(fileName);
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xuất dữ liệu ra Excel thất bại!\n" + ex.Message);
            }
            finally
            {
                workbook?.Close();
                excel.Quit();

                ReleaseObject(worksheet);
                ReleaseObject(workbook);
                ReleaseObject(excel);
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        public virtual string getData2(string query)
        {
            string result = ""; // Giá trị mặc định nếu không có dữ liệu

            // Sử dụng try-catch để xử lý các lỗi có thể xảy ra
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object queryResult = command.ExecuteScalar();
                        if (queryResult != null)
                        {
                            // Chuyển đổi kết quả sang kiểu string và gán vào biến result
                            result = queryResult.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                // Có thể bạn muốn log lỗi hoặc thực hiện các hành động khác tùy thuộc vào yêu cầu của bạn
                Console.WriteLine("Error: " + ex.Message);
            }

            return result;
        }

    }
    public static class EventHub
    {
        // Define the delegate for the event
        public delegate void DatabaseUpdatedEventHandler();
        // Define the static event based on the delegate
        public static event DatabaseUpdatedEventHandler DatabaseUpdated;
        public static event DatabaseUpdatedEventHandler ServicesUpdated;
        public static event DatabaseUpdatedEventHandler CustomerUpdated;
        public static event DatabaseUpdatedEventHandler EmployeeUpdated;

        // Static method to raise the event
        public static void OnDatabaseUpdated()
        {
            DatabaseUpdated?.Invoke();
        }
        public static void OnServicesUpdated()
        {
            ServicesUpdated?.Invoke();
        }
        public static void OnCustomerUpdated()
        {
            CustomerUpdated?.Invoke();
        }
        public static void OnEmployeeUpdated()
        {
            EmployeeUpdated?.Invoke();
        }
    }

}
