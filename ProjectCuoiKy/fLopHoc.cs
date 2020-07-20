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
    public partial class fLopHoc : Form
    {
        private string maLopHoc;
        private Database db = new Database();

        public fLopHoc(string _mlop)
        {
            this.maLopHoc = _mlop;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fLopHoc_Load(object sender, EventArgs e)
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter() { key = "@tuKhoa", value = "" });

            cbMonHoc.DataSource = db.SelectData("SelectAllMonHoc", parameters);
            cbMonHoc.DisplayMember = "tenMonHoc";
            cbMonHoc.ValueMember = "maMonHoc";
            cbMonHoc.SelectedIndex = -1;

            cbGV.DataSource = db.SelectData("SelectAllGiangVien", parameters);
            cbGV.DisplayMember = "hoTen";
            cbGV.ValueMember = "maGV";
            cbGV.SelectedIndex = -1;

            if (string.IsNullOrEmpty(this.maLopHoc))
            {
                this.Text = "Thêm lớp học";
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                var r = db.Select("SelectOneLopHoc'" + this.maLopHoc + "'");
                cbGV.SelectedValue = r["maGV"].ToString();
                cbMonHoc.SelectedValue = r["maMonHoc"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbMonHoc.SelectedIndex < 0 || cbGV.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng không để trống thông tin", "Thông báo");
                return;
            }

            string sql;
            string _maMonHoc = cbMonHoc.SelectedValue.ToString();
            string _maGV = cbGV.SelectedValue.ToString();
            List<CustomParameter> parameters = new List<CustomParameter>();
           
           
            if (string.IsNullOrEmpty(this.maLopHoc))
            {
                sql = "AddLopHoc";
            }
            else
            {
                sql = "updateLopHoc";
                parameters.Add(new CustomParameter() { key = "@maLopHoc", value = this.maLopHoc });
            }

            parameters.Add(new CustomParameter() { key = "@maMonHoc", value = _maMonHoc });
            parameters.Add(new CustomParameter() { key = "@maGV", value = _maGV });

            var kq = db.Execute(sql, parameters);

            if (kq == 1)
            {
                if (string.IsNullOrEmpty(this.maLopHoc))
                    MessageBox.Show("Thêm lớp học thành công", "Thông báo");
                else
                    MessageBox.Show("Cập nhật lớp học thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại!", "Thông báo");
            }
        }
    }
}
