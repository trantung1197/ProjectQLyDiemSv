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
    public partial class fDsLopCuaGiaoVien : Form
    {
        private string mgv;

        public fDsLopCuaGiaoVien(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }

        private void fChamDiem_Load(object sender, EventArgs e)
        {
            loadDsLopCuaGv();
        }

        private void loadDsLopCuaGv()
        {
            List<CustomParameter> parameters = new List<CustomParameter>() { 
                new CustomParameter()
                {
                    key="@maGV",
                    value= this.mgv
                }
            };
            Database db = new Database();

            dgvChamDiem.DataSource = new Database().SelectData("DsLopCuaGV", parameters);

            dgvChamDiem.Columns["maLopHoc"].HeaderText = "Mã lớp";
            dgvChamDiem.Columns["maMonHoc"].HeaderText = "Mã môn";
            dgvChamDiem.Columns["tenMonHoc"].HeaderText = "Tên môn";
            dgvChamDiem.Columns["soTinChi"].HeaderText = "Số TC";
            dgvChamDiem.Columns["stt"].HeaderText = "Sỉ số";
        }

        private void dgvChamDiem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var maLopHoc = dgvChamDiem.Rows[e.RowIndex].Cells["maLopHoc"].Value.ToString();

                new fDsChamDiemSV(maLopHoc).ShowDialog();
                loadDsLopCuaGv();
            }
        }
    }
}
