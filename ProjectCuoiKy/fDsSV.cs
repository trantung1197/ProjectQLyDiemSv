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
    public partial class fDsSV : Form
    {
        private string tukhoa = "";

        public fDsSV()
        {
            InitializeComponent();
        }

        private void fDsSV_Load(object sender, EventArgs e)
        {
            loadDsSinhVien();
        }

        private void dgvDsSV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var msv = dgvDsSV.Rows[e.RowIndex].Cells["maSV"].Value.ToString();

                new fSinhVien(msv).ShowDialog();
                loadDsSinhVien();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new fSinhVien(null).ShowDialog();
            loadDsSinhVien();
        }

        private void loadDsSinhVien()
        {
            Database db = new Database();
            List<CustomParameter> parameters = new List<CustomParameter>();

            parameters.Add(new CustomParameter(){
                key = "@tuKhoa",
                value = this.tukhoa
            });
            dgvDsSV.DataSource = db.SelectData("SelectAllSinhVien",parameters);

            dgvDsSV.Columns["maSV"].HeaderText = "Mã SV";
            dgvDsSV.Columns["hoTenDemSV"].HeaderText = "Họ";
            dgvDsSV.Columns["tenSV"].HeaderText = "Tên";
            dgvDsSV.Columns["ngaySinh"].HeaderText = "Ngày Sinh";
            dgvDsSV.Columns["gioiTinh"].HeaderText = "Giới Tính";
            dgvDsSV.Columns["queQuan"].HeaderText = "Quê Quán";
            dgvDsSV.Columns["dienThoai"].HeaderText = "Điện Thoại";
            dgvDsSV.Columns["email"].HeaderText = "Email";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.tukhoa = txtSearchSV.Text;
            loadDsSinhVien();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void dgvDsSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDsSV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDsSV_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
