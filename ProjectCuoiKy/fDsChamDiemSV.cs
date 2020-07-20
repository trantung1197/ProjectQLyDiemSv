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
    public partial class fDsChamDiemSV : Form
    {
        private string maLopHoc;
        private Database db = new Database();

        public fDsChamDiemSV(string maLopHoc)
        {
            this.maLopHoc = maLopHoc;
            InitializeComponent();
        }

        private void dgvDsSvDiem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var msv = dgvDsSvDiem.Rows[e.RowIndex].Cells["maSV"].Value.ToString();

                new fChamDiem(msv, this.maLopHoc).ShowDialog();
                loadDsSv();
            }
        }

        private void loadDsSv()
        {
            List<CustomParameter> parameters = new List<CustomParameter>();

            parameters.Add(new CustomParameter()
            {
                key = "@maLopHoc",
                value = this.maLopHoc
            });

            dgvDsSvDiem.DataSource = db.SelectData("DsSVChamDiem", parameters);

            dgvDsSvDiem.Columns["maSV"].HeaderText = "Mã SV";
            dgvDsSvDiem.Columns["hoTenDemSV"].HeaderText = "Họ";
            dgvDsSvDiem.Columns["tenSV"].HeaderText = "Tên";
            dgvDsSvDiem.Columns["diemLan1"].HeaderText = "Điểm lần 1";
            dgvDsSvDiem.Columns["diemLan2"].HeaderText = "Điểm lân 2";
        }

        private void fDsChamDiemSV_Load(object sender, EventArgs e)
        {
            this.Text = this.maLopHoc;
            loadDsSv();
        }
    }
}
