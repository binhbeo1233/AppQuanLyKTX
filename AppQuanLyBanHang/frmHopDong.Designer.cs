﻿namespace AppQuanLyBanHang
{
    partial class frmHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.txtDmasv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtMHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBd = new System.Windows.Forms.DateTimePicker();
            this.dtpkt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvhd = new System.Windows.Forms.DataGridView();
            this.mahopdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDmasv
            // 
            this.txtDmasv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDmasv.Location = new System.Drawing.Point(515, 78);
            this.txtDmasv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDmasv.Name = "txtDmasv";
            this.txtDmasv.Size = new System.Drawing.Size(181, 22);
            this.txtDmasv.TabIndex = 9;
            // 
            // txtmanv
            // 
            this.txtmanv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmanv.Location = new System.Drawing.Point(145, 134);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(181, 22);
            this.txtmanv.TabIndex = 7;
            // 
            // txtMHD
            // 
            this.txtMHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMHD.Location = new System.Drawing.Point(145, 79);
            this.txtMHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMHD.Name = "txtMHD";
            this.txtMHD.Size = new System.Drawing.Size(181, 22);
            this.txtMHD.TabIndex = 6;
            this.txtMHD.TextChanged += new System.EventHandler(this.txtMHD_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã hợp đồng:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(364, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "QUẢN LÝ HỢP ĐỒNG\r\n";
            // 
            // dtpBd
            // 
            this.dtpBd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBd.Location = new System.Drawing.Point(881, 75);
            this.dtpBd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBd.Name = "dtpBd";
            this.dtpBd.Size = new System.Drawing.Size(159, 22);
            this.dtpBd.TabIndex = 15;
            // 
            // dtpkt
            // 
            this.dtpkt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkt.Location = new System.Drawing.Point(881, 132);
            this.dtpkt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpkt.Name = "dtpkt";
            this.dtpkt.Size = new System.Drawing.Size(159, 22);
            this.dtpkt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(772, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày hết hạn:";
            // 
            // dgvhd
            // 
            this.dgvhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahopdong,
            this.mssv,
            this.manv,
            this.ngaybatdau,
            this.ngayhethan,
            this.maphong});
            this.dgvhd.Location = new System.Drawing.Point(3, 188);
            this.dgvhd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvhd.Name = "dgvhd";
            this.dgvhd.RowHeadersWidth = 51;
            this.dgvhd.Size = new System.Drawing.Size(1060, 277);
            this.dgvhd.TabIndex = 19;
            this.dgvhd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhd_CellClick);
            // 
            // mahopdong
            // 
            this.mahopdong.DataPropertyName = "mahopdong";
            this.mahopdong.HeaderText = "Mã hợp đồng";
            this.mahopdong.MinimumWidth = 6;
            this.mahopdong.Name = "mahopdong";
            this.mahopdong.Width = 119;
            // 
            // mssv
            // 
            this.mssv.DataPropertyName = "mssv";
            this.mssv.HeaderText = "Mã sinh viên";
            this.mssv.MinimumWidth = 6;
            this.mssv.Name = "mssv";
            this.mssv.Width = 150;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 119;
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.DataPropertyName = "ngaybatdau";
            this.ngaybatdau.HeaderText = "Ngày bắt đầu";
            this.ngaybatdau.MinimumWidth = 6;
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.Width = 125;
            // 
            // ngayhethan
            // 
            this.ngayhethan.DataPropertyName = "ngayhethan";
            this.ngayhethan.HeaderText = "Ngày hết hạn";
            this.ngayhethan.MinimumWidth = 6;
            this.ngayhethan.Name = "ngayhethan";
            this.ngayhethan.Width = 125;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.Width = 119;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(565, 502);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(113, 37);
            this.btnTimkiem.TabIndex = 26;
            this.btnTimkiem.Text = "&  Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.Location = new System.Drawing.Point(912, 502);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(113, 37);
            this.btnLammoi.TabIndex = 24;
            this.btnLammoi.Text = "&Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(392, 502);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 37);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(219, 502);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 37);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(45, 502);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 37);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(739, 502);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(117, 37);
            this.btnIn.TabIndex = 36;
            this.btnIn.Text = "&In hợp đồng";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtMaphong
            // 
            this.txtMaphong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaphong.Location = new System.Drawing.Point(515, 130);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(181, 22);
            this.txtMaphong.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Mã phòng:";
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 554);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvhd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpkt);
            this.Controls.Add(this.dtpBd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDmasv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.txtMHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hợp Đồng";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDmasv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtMHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBd;
        private System.Windows.Forms.DateTimePicker dtpkt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvhd;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahopdong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhethan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
    }
}