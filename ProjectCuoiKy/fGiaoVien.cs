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
    public partial class fGiaoVien : Form
    {
        private string mgv;

        public fGiaoVien(string _mgv)
        {
            this.mgv = _mgv;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fGiaoVien_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            if (string.IsNullOrEmpty(this.mgv))
            {
                this.Text = "Thêm Giảng Viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin giảng viên";
                var r = new Database().Select("SelectAllGiangVien_detail '" + this.mgv + "'");

                //MessageBox.Show(r["ngaySinh"].ToString());

                txtHoTenDem.Text = r["hoTenDemGV"].ToString();
                txtTen.Text = r["tenGV"].ToString();
                if (r["gioiTinh"].ToString().CompareTo("Nam") ==0)
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }

                mtxtNgSinh.Text = r["ngaySinh"].ToString();
                txtSdt.Text = r["dienThoai"].ToString();
                txtEmail.Text = r["email"].ToString();
            }
        }

        private void mtxtNgSinh_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            string sql = "";
            string hoTenDemGV = txtHoTenDem.Text;
            string tenGV = txtTen.Text;
            string gioiTinh = rbtnNam.Checked ? "1" : "0";

            DateTime ngaySinh;
            try
            {
                ngaySinh = DateTime.ParseExact(mtxtNgSinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                mtxtNgSinh.Select();
                return;
            }

            string email = txtEmail.Text;
            string dienThoai = txtSdt.Text;

            if (string.IsNullOrEmpty(this.mgv))
            {
                sql = "AddGiangVien";
            }
            else
            {
                sql = "UpdateGiangVien";
                lstPara.Add(new CustomParameter()
                {
                    key = "@maGV",
                    value = this.mgv
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@hoTenDemGV",
                value = hoTenDemGV
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@tenGV",
                value = tenGV
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
                key = "@email",
                value = email
            });

            var rs = new Database().Execute(sql, lstPara);

            if (rs == 1)
            {
                string mess = string.IsNullOrEmpty(this.mgv) ? "Thêm thành công" : "Cập nhật thành công";
                MessageBox.Show(mess);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại!");
            }
        }
    }
}
