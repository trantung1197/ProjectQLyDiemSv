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
    public partial class fDsLop : Form
    {
        private string tuKhoa = "";

        public fDsLop()
        {
            InitializeComponent();
        }

        private void fDsLop_Load(object sender, EventArgs e)
        {
            LoadDsLop();
        }

        private void btnSearchLop_Click(object sender, EventArgs e)
        {
            LoadDsLop();
        }

        public void LoadDsLop()
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter() { key = "@tuKhoa", value = this.tuKhoa });

            dgvLopHoc.DataSource = new Database().SelectData("SelectAllLopHoc", parameters);

            dgvLopHoc.Columns["maLopHoc"].HeaderText = "Mã lớp";
            dgvLopHoc.Columns["tenMonHoc"].HeaderText = "Tên môn";
            dgvLopHoc.Columns["giangVien"].HeaderText = "Giảng viên";
            dgvLopHoc.Columns["soTinChi"].HeaderText = "Số TC";
        }

        private void btnAddLop_Click(object sender, EventArgs e)
        {
            var f = new fLopHoc(null).ShowDialog();
            LoadDsLop();
        }

        private void dgvLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                string _maLop = dgvLopHoc.Rows[e.RowIndex].Cells["maLopHoc"].Value.ToString();
                new fLopHoc(_maLop).ShowDialog();
                LoadDsLop();
            }
        }
    }
}
