using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCuoiKy
{
    public partial class fSinhVien : Form
    {
        private string msv;

        public fSinhVien(string _msv)
        {
            this.msv = _msv;
            InitializeComponent();
        }

        private void fSinhVien_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            if (string.IsNullOrEmpty(this.msv))
            {
                this.Text = "Thêm Sinh Viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin sinh viên";
                var r = new Database().Select("SelectAllSinhVien '" + this.msv + "'");

                //MessageBox.Show(r["gioiTinh"].ToString());

                txtHoTenDem.Text = r["hoTenDemSV"].ToString();
                txtTen.Text = r["tenSV"].ToString();

                if (r["gioiTinh"].ToString().CompareTo("Nam") == 0)
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }

                mNgSinh.Text = r["ngaySinh"].ToString();
                txtQueQuan.Text = r["queQuan"].ToString();
                txtSdt.Text = r["dienThoai"].ToString();
                txtEmail.Text = r["email"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            string sql = "";
            string hoTenDemSV = txtHoTenDem.Text;
            string tenSV = txtTen.Text;
            string gioiTinh = rbtnNam.Checked ? "1" : "0";
           
            DateTime ngaySinh;
            try
            {
                ngaySinh = DateTime.ParseExact(mNgSinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                mNgSinh.Select();
                return;
            }

            string email = txtEmail.Text;
            string dienThoai = txtSdt.Text;
            string queQuan = txtQueQuan.Text;

            if (string.IsNullOrEmpty(this.msv))
            {
                sql = "AddSinhVien";
            }
            else
            {
                sql = "UpdateSinhVien";
                lstPara.Add(new CustomParameter()
                {
                    key = "@maSV",
                    value = this.msv
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@hoTenDemSV",
                value = hoTenDemSV
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@tenSV",
                value = tenSV
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@ngaySinh",
                value = ngaySinh.ToString("yyyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@gioiTinh",
                value = gioiTinh
            });
            
            lstPara.Add(new CustomParameter()
            {
                key = "@dienThoai",
                value = dienThoai
            });
            
            lstPara.Add(new CustomParameter()
            {
                key = "@queQuan",
                value = queQuan
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = email
            });

            var rs = new Database().Execute(sql, lstPara);

            if (rs == 1)
            {

                string mess = string.IsNullOrEmpty(this.msv) ? "Thêm thành công" : "Cập nhật thành công";
                MessageBox.Show(mess);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại!");
            }
        }

        private void rbtnNu_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbtnNam_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
