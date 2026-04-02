namespace QuanLyNhanSu.QuanLy
{
    partial class UserControl1
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
            label1 = new Label();
            rdTen = new RadioButton();
            btThem = new Button();
            panel1 = new Panel();
            btLuu = new Button();
            btSua = new Button();
            btXoa = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTen = new TextBox();
            txtTien = new TextBox();
            dtpTu = new DateTimePicker();
            dtpDen = new DateTimePicker();
            dataGridView1 = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            LoaiPC = new DataGridViewTextBoxColumn();
            Tien = new DataGridViewTextBoxColumn();
            TuNgay = new DataGridViewTextBoxColumn();
            DenNgay = new DataGridViewTextBoxColumn();
            rdTat = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(430, 17);
            label1.Name = "label1";
            label1.Size = new Size(137, 38);
            label1.TabIndex = 0;
            label1.Text = "PHỤ CẤP";
            // 
            // rdTen
            // 
            rdTen.AutoSize = true;
            rdTen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdTen.Location = new Point(29, 69);
            rdTen.Name = "rdTen";
            rdTen.Size = new Size(183, 27);
            rdTen.TabIndex = 1;
            rdTen.TabStop = true;
            rdTen.Text = "Theo tên nhân viên";
            rdTen.UseVisualStyleBackColor = true;
            rdTen.CheckedChanged += rdTen_CheckedChanged;
            // 
            // btThem
            // 
            btThem.BackColor = Color.MediumSlateBlue;
            btThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThem.ForeColor = Color.White;
            btThem.Location = new Point(29, 163);
            btThem.Name = "btThem";
            btThem.Size = new Size(100, 38);
            btThem.TabIndex = 2;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(30, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 45);
            panel1.TabIndex = 3;
            // 
            // btLuu
            // 
            btLuu.BackColor = Color.MediumSlateBlue;
            btLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLuu.ForeColor = Color.White;
            btLuu.Location = new Point(135, 163);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(100, 38);
            btLuu.TabIndex = 4;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = false;
            btLuu.Click += btLuu_Click;
            // 
            // btSua
            // 
            btSua.BackColor = Color.MediumSlateBlue;
            btSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSua.ForeColor = Color.White;
            btSua.Location = new Point(241, 163);
            btSua.Name = "btSua";
            btSua.Size = new Size(100, 38);
            btSua.TabIndex = 5;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = false;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.MediumSlateBlue;
            btXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoa.ForeColor = Color.White;
            btXoa.Location = new Point(347, 163);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(100, 38);
            btXoa.TabIndex = 6;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(470, 106);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 7;
            label2.Text = "Tên phụ cấp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(470, 153);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Từ ngày:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(796, 151);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 9;
            label4.Text = "Đến ngày:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(796, 100);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 10;
            label5.Text = "Số tiền:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(590, 99);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(184, 27);
            txtTen.TabIndex = 11;
            // 
            // txtTien
            // 
            txtTien.Location = new Point(881, 97);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(184, 27);
            txtTien.TabIndex = 12;
            // 
            // dtpTu
            // 
            dtpTu.Location = new Point(593, 146);
            dtpTu.Name = "dtpTu";
            dtpTu.Size = new Size(181, 27);
            dtpTu.TabIndex = 13;
            // 
            // dtpDen
            // 
            dtpDen.Location = new Point(881, 146);
            dtpDen.Name = "dtpDen";
            dtpDen.Size = new Size(181, 27);
            dtpDen.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenNV, LoaiPC, Tien, TuNgay, DenNgay });
            dataGridView1.Location = new Point(33, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1032, 235);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // LoaiPC
            // 
            LoaiPC.DataPropertyName = "LoaiPC";
            LoaiPC.HeaderText = "Tên Phụ Cấp";
            LoaiPC.MinimumWidth = 6;
            LoaiPC.Name = "LoaiPC";
            LoaiPC.ReadOnly = true;
            // 
            // Tien
            // 
            Tien.DataPropertyName = "Tien";
            Tien.HeaderText = "Tiền";
            Tien.MinimumWidth = 6;
            Tien.Name = "Tien";
            Tien.ReadOnly = true;
            // 
            // TuNgay
            // 
            TuNgay.DataPropertyName = "TuNgay";
            TuNgay.HeaderText = "Từ Ngày";
            TuNgay.MinimumWidth = 6;
            TuNgay.Name = "TuNgay";
            TuNgay.ReadOnly = true;
            // 
            // DenNgay
            // 
            DenNgay.DataPropertyName = "DenNgay";
            DenNgay.HeaderText = "Đến Ngày";
            DenNgay.MinimumWidth = 6;
            DenNgay.Name = "DenNgay";
            DenNgay.ReadOnly = true;
            // 
            // rdTat
            // 
            rdTat.AutoSize = true;
            rdTat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdTat.Location = new Point(241, 69);
            rdTat.Name = "rdTat";
            rdTat.Size = new Size(161, 27);
            rdTat.TabIndex = 16;
            rdTat.TabStop = true;
            rdTat.Text = "Tất cả nhân viên";
            rdTat.UseVisualStyleBackColor = true;
            rdTat.CheckedChanged += rdTat_CheckedChanged;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rdTat);
            Controls.Add(dataGridView1);
            Controls.Add(dtpDen);
            Controls.Add(dtpTu);
            Controls.Add(txtTien);
            Controls.Add(txtTen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btXoa);
            Controls.Add(btSua);
            Controls.Add(btLuu);
            Controls.Add(panel1);
            Controls.Add(btThem);
            Controls.Add(rdTen);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(1098, 481);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rdTen;
        private Button btThem;
        private Panel panel1;
        private Button btLuu;
        private Button btSua;
        private Button btXoa;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTen;
        private TextBox txtTien;
        private DateTimePicker dtpTu;
        private DateTimePicker dtpDen;
        private DataGridView dataGridView1;
        private RadioButton rdTat;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn LoaiPC;
        private DataGridViewTextBoxColumn Tien;
        private DataGridViewTextBoxColumn TuNgay;
        private DataGridViewTextBoxColumn DenNgay;
    }
}
