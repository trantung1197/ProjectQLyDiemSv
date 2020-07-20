namespace ProjectCuoiKy
{
    partial class fDsMH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDsMH));
            this.dgvDsMH = new System.Windows.Forms.DataGridView();
            this.btnSearchMH = new System.Windows.Forms.Button();
            this.btnAddMH = new System.Windows.Forms.Button();
            this.txtSearchMH = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsMH
            // 
            this.dgvDsMH.AllowUserToAddRows = false;
            this.dgvDsMH.AllowUserToDeleteRows = false;
            this.dgvDsMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsMH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDsMH.Location = new System.Drawing.Point(0, 56);
            this.dgvDsMH.Name = "dgvDsMH";
            this.dgvDsMH.ReadOnly = true;
            this.dgvDsMH.Size = new System.Drawing.Size(548, 298);
            this.dgvDsMH.TabIndex = 3;
            this.dgvDsMH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsMH_CellDoubleClick);
            // 
            // btnSearchMH
            // 
            this.btnSearchMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearchMH.Location = new System.Drawing.Point(109, 12);
            this.btnSearchMH.Name = "btnSearchMH";
            this.btnSearchMH.Size = new System.Drawing.Size(77, 29);
            this.btnSearchMH.TabIndex = 1;
            this.btnSearchMH.Text = "Tìm kiếm";
            this.btnSearchMH.UseVisualStyleBackColor = true;
            this.btnSearchMH.Click += new System.EventHandler(this.btnSearchMH_Click);
            // 
            // btnAddMH
            // 
            this.btnAddMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMH.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddMH.Location = new System.Drawing.Point(12, 12);
            this.btnAddMH.Name = "btnAddMH";
            this.btnAddMH.Size = new System.Drawing.Size(91, 29);
            this.btnAddMH.TabIndex = 2;
            this.btnAddMH.Text = "Thêm";
            this.btnAddMH.UseVisualStyleBackColor = true;
            this.btnAddMH.Click += new System.EventHandler(this.btnAddMH_Click);
            // 
            // txtSearchMH
            // 
            this.txtSearchMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMH.Location = new System.Drawing.Point(192, 14);
            this.txtSearchMH.Name = "txtSearchMH";
            this.txtSearchMH.Size = new System.Drawing.Size(167, 24);
            this.txtSearchMH.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(438, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 26);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // fDsMH
            // 
            this.AcceptButton = this.btnSearchMH;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(548, 354);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearchMH);
            this.Controls.Add(this.btnAddMH);
            this.Controls.Add(this.btnSearchMH);
            this.Controls.Add(this.dgvDsMH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDsMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Môn Học";
            this.Load += new System.EventHandler(this.fDsMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsMH;
        private System.Windows.Forms.Button btnSearchMH;
        private System.Windows.Forms.Button btnAddMH;
        private System.Windows.Forms.TextBox txtSearchMH;
        private System.Windows.Forms.Button btnBack;
    }
}