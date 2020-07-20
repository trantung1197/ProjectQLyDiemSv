namespace ProjectCuoiKy
{
    partial class fDangKyMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangKyMon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnBackDk = new System.Windows.Forms.Button();
            this.dgvDkMon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDkMon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSwitch);
            this.panel1.Controls.Add(this.btnBackDk);
            this.panel1.Controls.Add(this.dgvDkMon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 313);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(15, 11);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(131, 32);
            this.btnSwitch.TabIndex = 5;
            this.btnSwitch.Text = "Đăng ký môn";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnBackDk
            // 
            this.btnBackDk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackDk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackDk.Location = new System.Drawing.Point(540, 13);
            this.btnBackDk.Name = "btnBackDk";
            this.btnBackDk.Size = new System.Drawing.Size(94, 32);
            this.btnBackDk.TabIndex = 2;
            this.btnBackDk.Text = "Quay lại";
            this.btnBackDk.UseVisualStyleBackColor = true;
            // 
            // dgvDkMon
            // 
            this.dgvDkMon.AllowUserToAddRows = false;
            this.dgvDkMon.AllowUserToDeleteRows = false;
            this.dgvDkMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDkMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDkMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDkMon.Location = new System.Drawing.Point(0, 59);
            this.dgvDkMon.Name = "dgvDkMon";
            this.dgvDkMon.ReadOnly = true;
            this.dgvDkMon.Size = new System.Drawing.Size(644, 254);
            this.dgvDkMon.TabIndex = 4;
            this.dgvDkMon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDkMon_CellDoubleClick);
            // 
            // fDangKyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBackDk;
            this.ClientSize = new System.Drawing.Size(644, 313);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDangKyMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Môn Đã Đăng Ký";
            this.Load += new System.EventHandler(this.fDangKyMon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDkMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDkMon;
        private System.Windows.Forms.Button btnBackDk;
        private System.Windows.Forms.Button btnSwitch;
    }
}