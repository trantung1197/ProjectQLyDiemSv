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
    public partial class fXemDiem : Form
    {
        private string msv;
        private Database db = new Database();

        public fXemDiem(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }

        private void fXemDiem_Load(object sender, EventArgs e)
        {
            
            loadDsDiem();
        }

        private void loadDsDiem()
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter() { key = "@maSV", value = this.msv });

            dgvXemDiem.DataSource = db.SelectData("XemDiem", parameters);

            dgvXemDiem.Columns["diemLan1"].HeaderText = "Điểm lần 1";
            dgvXemDiem.Columns["diemLan2"].HeaderText = "Điểm lần 2";
            dgvXemDiem.Columns["diemTB"].HeaderText = "Điểm tổng";
            dgvXemDiem.Columns["tenMonHoc"].HeaderText = "Tên môn";
            dgvXemDiem.Columns["giangVien"].HeaderText = "Giảng viên";
            dgvXemDiem.Columns["soTinChi"].HeaderText = "Số TC";
        }
    }
}
