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
    public partial class fMenu : Form
    {
        private string thongBao = "";
        private string loaiTk;
        private string tk;

        public fMenu(string _loaiTk, string _tk)
        {
            this.loaiTk = _loaiTk;
            this.tk = _tk;
            InitializeComponent();
        }

        private void fMenu_Load(object sender, EventArgs e)
        {
            switch (this.loaiTk)
            {
                case "admin":
                    menuGv.Visible = false;
                    menuSv.Visible = false;
                    break;
                case "gv":
                    menuAdmin.Visible = false;
                    menuSv.Visible = false;
                    break;
                case "sv":
                    menuGv.Visible = false;
                    menuAdmin.Visible = false;
                    break;
                default:
                    break;
            }

        }

        private void mntripExit_Click(object sender, EventArgs e)
        {
            this.thongBao = "Thoát chương trình?";
            Application.Exit();
        }

        private void mntripLogout_Click(object sender, EventArgs e)
        {
            this.thongBao = "Đăng xuất?";
            this.Close();
        }

        private void fMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this.thongBao, "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void mntripSinhvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new fDsSV().ShowDialog();
            this.Show();
        }

        private void mntripGiangVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new fDsGiaovien().ShowDialog();
            this.Show();
        }

        private void mntripLop_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new fDsLop().ShowDialog();
            this.Show();
        }

        private void mntripMonHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new fDsMH().ShowDialog();
            this.Show();
        }

        private void mntripDiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new fDsDiemThi().ShowDialog();
            this.Show();
        }
        //------------------------------------------------------------
        //------------------------------------------------------------
        //SinhVien
        //------------------------------------------------------------
        //------------------------------------------------------------

        private void mnDkMon_Click(object sender, EventArgs e)
        {
            new fDangKyMon(this.tk).ShowDialog();
        }

        private void mnDetailUserSV_Click(object sender, EventArgs e)
        {
            new fSinhVien(this.tk).ShowDialog();
        }

        private void mnXemDiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new fXemDiem(this.tk).ShowDialog();
            this.Show();
        }
        //------------------------------------------------------------
        //------------------------------------------------------------
        //GiangVien
        //------------------------------------------------------------
        //------------------------------------------------------------

        private void mnDetailUserGV_Click(object sender, EventArgs e)
        {
            new fGiaoVien(this.tk).ShowDialog();
        }

        private void mnChamDiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new fDsLopCuaGiaoVien(this.tk).ShowDialog();
            this.Show();
        }
    }
}
