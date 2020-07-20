using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCuoiKy
{
    public partial class fLogin : Form
    {
        public string userName = "";
        public string loaiTk;
        private Database db = new Database();

        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbLoaiTk.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản", "Thông báo");
                cbLoaiTk.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông tin trống");
                txtUsername.Select();
                return;
            }
            
            switch (cbLoaiTk.Text)
            {
                case "Quản Trị Viên":
                    this.loaiTk = "admin";
                    break;
                case "Sinh Viên":
                    this.loaiTk = "sv";
                    break;
                case "Giảng Viên":
                    this.loaiTk = "gv";
                    break;
                default:
                    break;
            }

            List<CustomParameter> parameters = new List<CustomParameter>() {
                new CustomParameter()
                {
                    key="@loaiTk",
                    value=this.loaiTk
                },
                new CustomParameter()
                {
                    key="@UserName",
                    value=txtUsername.Text
                },
                new CustomParameter()
                {
                    key="@Password",
                    value=txtPassword.Text
                }
            };

            var rs = db.SelectData("PrcLogin",parameters);

            if (rs.Rows.Count > 0)
            {
                fMenu f = new fMenu(this.loaiTk, txtUsername.Text);
                this.Hide();
                f.ShowDialog();
                try
                {
                    this.Show();

                }
                catch (Exception)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng","Thông báo");
                txtUsername.Text = "";
                txtUsername.Select();
                txtPassword.Text = "";
            }
 
            

        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cbLoaiTk.SelectedIndex = 0;
        }

        private void cbLoaiTk_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtUsername.Select();
            txtPassword.Text = "";
        }
    }
}
