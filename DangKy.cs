using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO_Game
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();

        private void btnDK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(
                    "insert into TaiKhoan (Taikhoan, Matkhau) values ('{0}', '{1}')", txtTaiKhoan.Text, txtMatKhau.Text);

                bool isSuccess = kn.ThucThi(query);

                if (isSuccess)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    DangNhap frm = new DangNhap();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
