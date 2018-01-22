using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using DataAccess;
using Entity;
namespace QuanLyKhachSan
{
    public partial class LoginForm : Form
    {
        SpDataAccess sda = new SpDataAccess();
        Entity.QuyenNV qnv = new Entity.QuyenNV();
        MainForm main_form;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void login()
        {
            try
            {
                qnv.Ma_nv = txtUser.Text;
                qnv.Mat_khau = txtPass.Text;
                DataTable dt1 = sda.Login(qnv);
                if (dt1.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhâp thành công !");
                    this.Hide();
                    this.Dispose(false);
                    main_form = new MainForm();
                    main_form.Show();
                }else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !");
                }
                //DataTable dt2 = 
                //DataRow dr = dt.Rows[0];
                //MessageBox.Show("Xin chào " + r["hoten"].ToString() + "!", "Xin chào", MessageBoxButtons.OK);

            }catch(Exception e)
            {
                MessageBox.Show("Đăng nhập thất bại: "+e.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
