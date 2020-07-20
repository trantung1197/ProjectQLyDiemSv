namespace ProjectCuoiKy
{
    partial class fDsLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDsLop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddLop = new System.Windows.Forms.Button();
            this.btnSearchLop = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearchLop = new System.Windows.Forms.TextBox();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLopHoc);
            this.panel1.Controls.Add(this.txtSearchLop);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSearchLop);
            this.panel1.Controls.Add(this.btnAddLop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 289);
            this.panel1.TabIndex = 0;
            // 
            // btnAddLop
            // 
            this.btnAddLop.Location = new System.Drawing.Point(12, 12);
            this.btnAddLop.Name = "btnAddLop";
            this.btnAddLop.Size = new System.Drawing.Size(97, 23);
            this.btnAddLop.TabIndex = 1;
            this.btnAddLop.Text = "Thêm";
            this.btnAddLop.UseVisualStyleBackColor = true;
            this.btnAddLop.Click += new System.EventHandler(this.btnAddLop_Click);
            // 
            // btnSearchLop
            // 
            this.btnSearchLop.Location = new System.Drawing.Point(115, 12);
            this.btnSearchLop.Name = "btnSearchLop";
            this.btnSearchLop.Size = new System.Drawing.Size(75, 23);
            this.btnSearchLop.TabIndex = 0;
            this.btnSearchLop.Text = "Tìm kiếm";
            this.btnSearchLop.UseVisualStyleBackColor = true;
            this.btnSearchLop.Click += new System.EventHandler(this.btnSearchLop_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(534, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtSearchLop
            // 
            this.txtSearchLop.Location = new System.Drawing.Point(196, 14);
            this.txtSearchLop.Name = "txtSearchLop";
            this.txtSearchLop.Size = new System.Drawing.Size(180, 20);
            this.txtSearchLop.TabIndex = 0;
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.AllowUserToAddRows = false;
            this.dgvLopHoc.AllowUserToDeleteRows = false;
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLopHoc.Location = new System.Drawing.Point(0, 55);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.ReadOnly = true;
            this.dgvLopHoc.Size = new System.Drawing.Size(621, 234);
            this.dgvLopHoc.TabIndex = 3;
            this.dgvLopHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHoc_CellDoubleClick);
            // 
            // fDsLop
            // 
            this.AcceptButton = this.btnSearchLop;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(621, 289);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDsLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Lớp";
            this.Load += new System.EventHandler(this.fDsLop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchLop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearchLop;
        private System.Windows.Forms.Button btnAddLop;
        private System.Windows.Forms.DataGridView dgvLopHoc;
    }
}