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
    public partial class fDsGiaovien : Form
    {
        private string tuKhoa = " ";

        public fDsGiaovien()
        {
            InitializeComponent();
        }

        private void fDsGiaovien_Load(object sender, EventArgs e)
        {
            loadDataDsGv();
        }

        private void loadDataDsGv()
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            Database db = new Database();

            parameters.Add(new CustomParameter()
            {
                key = "@tuKhoa",
                value = this.tuKhoa
            });

            dgvDsGv.DataSource = new Database().SelectData("SelectAllGiangVien", parameters);

            dgvDsGv.Columns["maGV"].HeaderText = "Mã GV";
            dgvDsGv.Columns["hoTen"].HeaderText = "Họ Tên"; 
            dgvDsGv.Columns["ngaySinh"].HeaderText = "Ngày Sinh";
            dgvDsGv.Columns["gioiTinh"].HeaderText = "Giới Tính";
            dgvDsGv.Columns["dienThoai"].HeaderText = "Điện Thoại";
            dgvDsGv.Columns["email"].HeaderText = "Email";
        }

        private void dgvDsGv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var mgv = dgvDsGv.Rows[e.RowIndex].Cells["maGV"].Value.ToString();

                new fGiaoVien(mgv).ShowDialog();
                loadDataDsGv();
            }
        }

        private void btnSearchGv_Click(object sender, EventArgs e)
        {
            this.tuKhoa = txtSearchGv.Text;
            loadDataDsGv();
        }

        private void dgvDsGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddGv_Click(object sender, EventArgs e)
        {
            new fGiaoVien(null).ShowDialog();
            loadDataDsGv();
        }

        private void dgvDsGv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
