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
    public partial class fMonHoc : Form
    {
        private string mmh;

        public fMonHoc(string _mmh)
        {
            this.mmh = _mmh;
            InitializeComponent();
        }

        private void fMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.mmh))
            {
                this.Text = "Thêm môn học mới";
            }
            else
            {
                this.Text = "Cập nhật môn học";
                var r = new Database().Select("SelectAllMonHoc'" + this.mmh + "'");
                txtTenMH.Text = r["tenMonHoc"].ToString();
                txtSTC.Text = r["soTinChi"].ToString();
                txtMaMon.Text = r["maMonHoc"].ToString();
                txtMaMon.ReadOnly = true;
            }

            this.MaximizeBox = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string sql = "";
            List<CustomParameter> parameters = new List<CustomParameter>();
            Database db = new Database();

            string _tenMonHoc = txtTenMH.Text;
            string _maMonHoc = txtMaMon.Text;
            string _soTinChi = txtSTC.Text;

            if (string.IsNullOrEmpty(txtTenMH.Text) ||
                string.IsNullOrEmpty(txtMaMon.Text) ||
                string.IsNullOrEmpty(txtSTC.Text))
            {
                MessageBox.Show("Vui lòng không để trống thông tin");
                txtMaMon.Select();
                return;
            }

            try
            {
                var stc = int.Parse(txtSTC.Text);
                if (stc <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0");
                    txtSTC.Select();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Số tín chỉ phải là số nguyên");
                txtSTC.Select();
                return;
            }

            

            if (string.IsNullOrEmpty(this.mmh))
            {
                sql = "AddMonHoc";
            }
            else
            {
                sql = "UpdateMonHoc";
            }

            parameters.Add(new CustomParameter() { key = "@tenMonHoc", value = _tenMonHoc });
            parameters.Add(new CustomParameter() { key = "@maMonHoc", value = _maMonHoc });
            parameters.Add(new CustomParameter() { key = "@soTinChi", value = _soTinChi });

            var rs = db.Execute(sql, parameters);

            if(rs == 1)
            {
                if (string.IsNullOrEmpty(this.mmh))
                {
                    this.Text = "Thêm môn học mới thành công";
                }
                else
                {
                    this.Text = "Cập nhật môn học thành công";
                }

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }
    }
}
