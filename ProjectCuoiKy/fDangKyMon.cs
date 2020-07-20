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
    public partial class fDangKyMon : Form
    {
        private string tk;
        private Database db = new Database();
        private string tuKhoa = "";
        private bool statusDk = false;

        public fDangKyMon(string _tk)
        {
            this.tk = _tk;
            InitializeComponent();
        }

        private void fDangKyMon_Load(object sender, EventArgs e)
        {
            TextForm();
            LoadListMonDaDK();
        }

        private void dgvDkMon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.statusDk)
            {
                return;
            }
            else
            {
                if(dgvDkMon.Rows[e.RowIndex].Index >= 0)
                {
                    if (DialogResult.Yes ==
                        MessageBox.Show("Bạn muốn đăng ký môn: " +
                        dgvDkMon.Rows[e.RowIndex].Cells["tenMonHoc"].Value.ToString(),
                        "Đăng ký",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question))
                    {
                        List<CustomParameter> parameters = new List<CustomParameter>()
                        {
                            new CustomParameter()
                            {
                                key="@maLopHoc",
                                value=dgvDkMon.Rows[e.RowIndex].Cells["maLopHoc"].Value.ToString()
                            },
                            new CustomParameter()
                            {
                                key="@maSV",
                                value=this.tk
                            }
                        };

                        var rs = db.Execute("DangkyMon", parameters);

                        if (rs == -1)
                        {
                            MessageBox.Show("Học phần này bạn đã đăng ký", "Thông báo");
                            return;
                        }
                        else if(rs == 1){
                            MessageBox.Show("Đăng ký môn học thành công", "Thông báo");
                            LoadListMon();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký môn học không thành công", "Thông báo");
                        }
                    }
                }
            }
        }

        private void dangKyMon(string maMon)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            this.statusDk = !this.statusDk;
            TextForm();
        }

        private void LoadListMon()
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter() { key = "@maSV", value = this.tk });

            dgvDkMon.DataSource = db.SelectData("SelectAllLopChuaDKy", parameters);

            dgvDkMon.Columns["maLopHoc"].HeaderText = "Mã lớp";
            dgvDkMon.Columns["tenMonHoc"].HeaderText = "Tên môn";
            dgvDkMon.Columns["giangVien"].HeaderText = "Giảng viên";
            dgvDkMon.Columns["soTinChi"].HeaderText = "Số TC";
        }

        private void LoadListMonDaDK()
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter() { key = "@maSV", value = this.tk });

            dgvDkMon.DataSource = db.SelectData("SelectAllMonDaDk", parameters);

            dgvDkMon.Columns["maLopHoc"].HeaderText = "Mã lớp";
            dgvDkMon.Columns["tenMonHoc"].HeaderText = "Tên môn";
            dgvDkMon.Columns["giangVien"].HeaderText = "Giảng viên";
            dgvDkMon.Columns["soTinChi"].HeaderText = "Số TC";
            
        }

        private void TextForm()
        {
            if (this.statusDk)
            {
                this.Text = "Đăng ký môn học - Click chọn môn học để đăng ký";
                btnSwitch.Text = "Quay lại";
                btnBackDk.Hide();
                LoadListMon();
            }
            else
            {
                this.Text = "Danh sách môn học đã đăng ký";
                btnSwitch.Text = "Đăng ký môn mới";
                btnBackDk.Show();
                LoadListMonDaDK();
            }
        }

        private void btnSearchDkMon_Click(object sender, EventArgs e)
        {
        }
    }
}
