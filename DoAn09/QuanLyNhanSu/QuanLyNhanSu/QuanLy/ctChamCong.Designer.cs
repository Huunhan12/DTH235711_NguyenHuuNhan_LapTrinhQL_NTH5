namespace QuanLyNhanSu.QuanLy
{
    partial class ctChamCong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            cbCC = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            dtpNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btXoa = new Guna.UI2.WinForms.Guna2Button();
            dataGridView1 = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewComboBoxColumn();
            lbTinhTrang = new Label();
            lbTen = new Label();
            lbMa = new Label();
            btCapNhat = new Guna.UI2.WinForms.Guna2Button();
            label = new Label();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbCC);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpNgay);
            panel1.Controls.Add(btXoa);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lbTinhTrang);
            panel1.Controls.Add(lbTen);
            panel1.Controls.Add(lbMa);
            panel1.Controls.Add(btCapNhat);
            panel1.Controls.Add(label);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 449);
            panel1.TabIndex = 0;
            // 
            // cbCC
            // 
            cbCC.AutoSize = true;
            cbCC.Location = new Point(877, 389);
            cbCC.Name = "cbCC";
            cbCC.Size = new Size(147, 24);
            cbCC.TabIndex = 56;
            cbCC.Text = "Chấm công tất cả";
            cbCC.UseVisualStyleBackColor = true;
            cbCC.CheckedChanged += cbCC_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(805, 429);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 55;
            label2.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 411);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 54;
            label3.Text = "Chọn ngày:";
            // 
            // dtpNgay
            // 
            dtpNgay.BorderRadius = 10;
            dtpNgay.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            dtpNgay.Checked = true;
            dtpNgay.CustomizableEdges = customizableEdges1;
            dtpNgay.FillColor = Color.White;
            dtpNgay.Font = new Font("Segoe UI", 9F);
            dtpNgay.Format = DateTimePickerFormat.Long;
            dtpNgay.Location = new Point(143, 399);
            dtpNgay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpNgay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpNgay.Size = new Size(212, 45);
            dtpNgay.TabIndex = 53;
            dtpNgay.Value = new DateTime(2026, 3, 5, 22, 18, 1, 891);
            // 
            // btXoa
            // 
            btXoa.BorderRadius = 20;
            btXoa.CustomizableEdges = customizableEdges3;
            btXoa.DisabledState.BorderColor = Color.DarkGray;
            btXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btXoa.FillColor = Color.MediumSlateBlue;
            btXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoa.ForeColor = Color.White;
            btXoa.Location = new Point(409, 399);
            btXoa.Name = "btXoa";
            btXoa.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btXoa.Size = new Size(178, 38);
            btXoa.TabIndex = 52;
            btXoa.Text = "Xóa chấm công";
            btXoa.Click += btXoa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenNV, TinhTrang });
            dataGridView1.Location = new Point(0, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1053, 274);
            dataGridView1.TabIndex = 2;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã Nhân Viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "TenNV";
            TenNV.HeaderText = "Tên Nhân Viên";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            TenNV.ReadOnly = true;
            // 
            // TinhTrang
            // 
            TinhTrang.HeaderText = "Tình Trang";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            // 
            // lbTinhTrang
            // 
            lbTinhTrang.AutoSize = true;
            lbTinhTrang.Font = new Font("Segoe UI", 10.2F);
            lbTinhTrang.Location = new Point(736, 73);
            lbTinhTrang.Name = "lbTinhTrang";
            lbTinhTrang.Size = new Size(55, 23);
            lbTinhTrang.TabIndex = 51;
            lbTinhTrang.Text = "label5";
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.Font = new Font("Segoe UI", 10.2F);
            lbTen.Location = new Point(409, 73);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(55, 23);
            lbTen.TabIndex = 50;
            lbTen.Text = "label4";
            // 
            // lbMa
            // 
            lbMa.AutoSize = true;
            lbMa.Font = new Font("Segoe UI", 10.2F);
            lbMa.Location = new Point(143, 73);
            lbMa.Name = "lbMa";
            lbMa.Size = new Size(55, 23);
            lbMa.TabIndex = 49;
            lbMa.Text = "label3";
            // 
            // btCapNhat
            // 
            btCapNhat.BorderRadius = 20;
            btCapNhat.CustomizableEdges = customizableEdges5;
            btCapNhat.DisabledState.BorderColor = Color.DarkGray;
            btCapNhat.DisabledState.CustomBorderColor = Color.DarkGray;
            btCapNhat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btCapNhat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btCapNhat.FillColor = Color.MediumSlateBlue;
            btCapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCapNhat.ForeColor = Color.White;
            btCapNhat.Location = new Point(877, 58);
            btCapNhat.Name = "btCapNhat";
            btCapNhat.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btCapNhat.Size = new Size(153, 38);
            btCapNhat.TabIndex = 48;
            btCapNhat.Text = "Cập nhật";
            btCapNhat.Click += btCapNhat_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(631, 73);
            label.Name = "label";
            label.Size = new Size(99, 23);
            label.TabIndex = 12;
            label.Text = "Tình trạng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(267, 73);
            label6.Name = "label6";
            label6.Size = new Size(124, 23);
            label6.TabIndex = 11;
            label6.Text = "Tên nhân viên:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 73);
            label7.Name = "label7";
            label7.Size = new Size(122, 23);
            label7.TabIndex = 10;
            label7.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(437, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 38);
            label1.TabIndex = 0;
            label1.Text = "CHẤM CÔNG";
            // 
            // ctChamCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ctChamCong";
            Size = new Size(1099, 486);
            Load += ctChamCong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label7;
        private Label label;
        private Label label6;
        private Label lbTinhTrang;
        private Label lbTen;
        private Label lbMa;
        private Guna.UI2.WinForms.Guna2Button btCapNhat;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewComboBoxColumn TinhTrang;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgay;
        private CheckBox cbCC;
        private Label label2;
        private Label label3;
    }
}
