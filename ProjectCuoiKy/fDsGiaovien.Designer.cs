namespace ProjectCuoiKy
{
    partial class fDsGiaovien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDsGiaovien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDsGv = new System.Windows.Forms.DataGridView();
            this.txtSearchGv = new System.Windows.Forms.TextBox();
            this.btnSearchGv = new System.Windows.Forms.Button();
            this.btnAddGv = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnAddGv);
            this.panel1.Controls.Add(this.btnSearchGv);
            this.panel1.Controls.Add(this.txtSearchGv);
            this.panel1.Controls.Add(this.dgvDsGv);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 320);
            this.panel1.TabIndex = 0;
            // 
            // dgvDsGv
            // 
            this.dgvDsGv.AllowUserToAddRows = false;
            this.dgvDsGv.AllowUserToDeleteRows = false;
            this.dgvDsGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsGv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDsGv.Location = new System.Drawing.Point(0, 55);
            this.dgvDsGv.Name = "dgvDsGv";
            this.dgvDsGv.ReadOnly = true;
            this.dgvDsGv.Size = new System.Drawing.Size(797, 265);
            this.dgvDsGv.TabIndex = 3;
            this.dgvDsGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsGv_CellContentClick);
            this.dgvDsGv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsGv_CellDoubleClick);
            this.dgvDsGv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsGv_CellEnter);
            // 
            // txtSearchGv
            // 
            this.txtSearchGv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSearchGv.Location = new System.Drawing.Point(257, 13);
            this.txtSearchGv.Name = "txtSearchGv";
            this.txtSearchGv.Size = new System.Drawing.Size(257, 24);
            this.txtSearchGv.TabIndex = 0;
            // 
            // btnSearchGv
            // 
            this.btnSearchGv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearchGv.Location = new System.Drawing.Point(134, 11);
            this.btnSearchGv.Name = "btnSearchGv";
            this.btnSearchGv.Size = new System.Drawing.Size(117, 29);
            this.btnSearchGv.TabIndex = 1;
            this.btnSearchGv.Text = "Tìm kiếm";
            this.btnSearchGv.UseVisualStyleBackColor = true;
            this.btnSearchGv.Click += new System.EventHandler(this.btnSearchGv_Click);
            // 
            // btnAddGv
            // 
            this.btnAddGv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddGv.ForeColor = System.Drawing.Color.Black;
            this.btnAddGv.Location = new System.Drawing.Point(11, 11);
            this.btnAddGv.Name = "btnAddGv";
            this.btnAddGv.Size = new System.Drawing.Size(117, 29);
            this.btnAddGv.TabIndex = 2;
            this.btnAddGv.Text = "Thêm";
            this.btnAddGv.UseVisualStyleBackColor = true;
            this.btnAddGv.Click += new System.EventHandler(this.btnAddGv_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(699, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 26);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // fDsGiaovien
            // 
            this.AcceptButton = this.btnSearchGv;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDsGiaovien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Giảng Viên";
            this.Load += new System.EventHandler(this.fDsGiaovien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsGv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddGv;
        private System.Windows.Forms.Button btnSearchGv;
        private System.Windows.Forms.TextBox txtSearchGv;
        private System.Windows.Forms.DataGridView dgvDsGv;
        private System.Windows.Forms.Button btnBack;
    }
}