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
    public partial class fChamDiem : Form
    {
        private string msv;
        private string maLopHoc;

        public fChamDiem(string msv, string maLopHoc)
        {
            this.msv = msv;
            this.maLopHoc = maLopHoc;
            InitializeComponent();
        }

        private void fChamDiem_Load(object sender, EventArgs e)
        {
            txtMaSV.Text = this.msv;
            nmLan1.Maximum = 10;
            nmLan1.Minimum = 0;
            nmLan2.Maximum = 10;
            nmLan2.Minimum = 0;

            string sql = "Select * from tbDiemThi where maSV = '" + this.msv + "' and maLopHoc = " + this.maLopHoc + "";

            var r = new Database().Select(sql);

            nmLan1.Value = int.Parse(r["diemLan1"].ToString());
            nmLan2.Value = int.Parse(r["diemLan2"].ToString());
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string diemLan1 = nmLan1.Value.ToString();
            string diemLan2 = nmLan2.Value.ToString();

            List<CustomParameter> lstPara = new List<CustomParameter>() {
                new CustomParameter(){
                    key="@maSV",value=this.msv
                },
                 new CustomParameter(){
                    key="@maLopHoc",value=this.maLopHoc
                },
                new CustomParameter(){
                    key="@diemlan1", value = diemLan1
                },
                new CustomParameter(){
                    key="@diemlan2", value = diemLan2
                }
            };

            var rs = new Database().Execute("UpdateDiem", lstPara);

            if (rs == 1)
            {
                MessageBox.Show("Cập nhật điểm thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Cập nhật điểm không thành công");
            }
        }
    }
}
