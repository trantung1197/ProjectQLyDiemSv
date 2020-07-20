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
    public partial class fDsMH : Form
    {
        private string tuKhoa = "";

        public fDsMH()
        {
            InitializeComponent();
        }

        private void fDsMH_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            loadDsMonHoc();
        }

        private void dgvDsMH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var mmh = dgvDsMH.Rows[e.RowIndex].Cells["maMonHoc"].Value.ToString();

                new fMonHoc(mmh).ShowDialog();
                loadDsMonHoc();
            }
        }

        private void loadDsMonHoc()
        {
            Database db = new Database();
            List<CustomParameter> parameters = new List<CustomParameter>();

            parameters.Add(new CustomParameter()
            {
                key = "@tuKhoa",
                value = this.tuKhoa
            });

            dgvDsMH.DataSource = db.SelectData("SelectAllMonHoc", parameters);

            dgvDsMH.Columns["maMonHoc"].HeaderText = "Mã môn";
            dgvDsMH.Columns["tenMonHoc"].HeaderText = "Tên môn";
            dgvDsMH.Columns["soTinChi"].HeaderText = "Số tín chỉ";
        }

        private void btnSearchMH_Click(object sender, EventArgs e)
        {
            this.tuKhoa = txtSearchMH.Text;
            loadDsMonHoc();
        }

        private void btnAddMH_Click(object sender, EventArgs e)
        {
            new fMonHoc(null).ShowDialog();
            loadDsMonHoc();
        }
    }
}
