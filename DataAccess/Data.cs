using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
namespace DataAccess
{
    public class Data
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public Data()
        {
            this.GetDBConnection();
        }

        public void GetDBConnection()
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);
                //con = new SqlConnection(@"Data Source=DESKTOP-K3GJVS8\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
                con.Open();
                //MessageBox.Show("Kết nối thành công với database !!!");
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không kết nối được với database !!!" + ex);
            }
        }

        //Du lieu bang sinh vien
        public DataTable GetTable(string proc)
        {
            //SqlConnection conn = GetDBConnection();
            var cmd = new SqlCommand(proc, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            return dt;
        }
        //Procedure return table
        public DataTable ProcedureGetTable(string sql, string[] Name, object[] Values, int so_luong)
        {
            //SqlConnection conn = GetDBConnection();
            
            var cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            for(int i = 0; i < so_luong; i++)
            {
                cmd.Parameters.AddWithValue(Name[i], Values[i]);
            }    
            SqlDataAdapter da = new SqlDataAdapter(cmd); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            return dt;
        }
        //Procedure return dataset
        public DataSet ProcedureGetDataSet(string sql, string[] Name, object[] Values, int so_luong)
        {
            //SqlConnection conn = GetDBConnection();

            var cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < so_luong; i++)
            {
                cmd.Parameters.AddWithValue(Name[i], Values[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd); //chuyen du lieu ve
            DataSet ds = new DataSet(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(ds);  // đổ dữ liệu vào kho
            return ds;
        }

        public SqlCommand GetCommand(string proc)
        {
            //SqlConnection conn = GetDBConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            var cmd = new SqlCommand(proc, con);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.ExecuteNonQuery();
            //cmd.Dispose();           
        }
        public int Excute(string sql, string[] Name, object[] Values, int so_luong)
        {
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            for (int i = 0; i < so_luong; i++)
            {
                cmd.Parameters.AddWithValue(Name[i], Values[i]);
            }
            return cmd.ExecuteNonQuery();
        }
    }
}

