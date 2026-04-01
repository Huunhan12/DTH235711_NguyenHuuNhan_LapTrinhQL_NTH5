namespace QuanLyNhanSu.QuanLy
{
    partial class BaoHiem
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNoiCap = new TextBox();
            txtSo = new TextBox();
            txtTen = new TextBox();
            dtpNgayHH = new DateTimePicker();
            dtpNgayCap = new DateTimePicker();
            cbLoai = new ComboBox();
            label7 = new Label();
            btXoa = new Button();
            btSua = new Button();
            btLuu = new Button();
            btThem = new Button();
            dataGridView1 = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            LoaiBaoHiem = new DataGridViewTextBoxColumn();
            NgayHetHan = new DataGridViewTextBoxColumn();
            lbTB = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(726, 92);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 8;
            label2.Text = "Mã bảo hiểm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(363, 138);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 9;
            label1.Text = "Ngày hết hạn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(363, 92);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 10;
            label3.Text = "Loại bảo hiểm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(726, 138);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 11;
            label4.Text = "Nơi cấp:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 138);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 12;
            label5.Text = "Ngày cấp:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 92);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 13;
            label6.Text = "Tên nhân viên:";
            // 
            // txtNoiCap
            // 
            txtNoiCap.Location = new Point(843, 135);
            txtNoiCap.Name = "txtNoiCap";
            txtNoiCap.Size = new Size(381, 27);
            txtNoiCap.TabIndex = 14;
            // 
            // txtSo
            // 
            txtSo.Location = new Point(843, 92);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(381, 27);
            txtSo.TabIndex = 15;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(161, 89);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(184, 27);
            txtTen.TabIndex = 16;
            // 
            // dtpNgayHH
            // 
            dtpNgayHH.Location = new Point(486, 133);
            dtpNgayHH.Name = "dtpNgayHH";
            dtpNgayHH.Size = new Size(199, 27);
            dtpNgayHH.TabIndex = 17;
            // 
            // dtpNgayCap
            // 
            dtpNgayCap.Location = new Point(161, 133);
            dtpNgayCap.Name = "dtpNgayCap";
            dtpNgayCap.Size = new Size(184, 27);
            dtpNgayCap.TabIndex = 18;
            // 
            // cbLoai
            // 
            cbLoai.FormattingEnabled = true;
            cbLoai.Items.AddRange(new object[] { "Bảo Hiểm Thân Thể", "Bảo Hiểm Y Tế" });
            cbLoai.Location = new Point(483, 91);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(202, 28);
            cbLoai.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(548, 11);
            label7.Name = "label7";
            label7.Size = new Size(137, 38);
            label7.TabIndex = 20;
            label7.Text = "PHỤ CẤP";
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.MediumSlateBlue;
            btXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoa.ForeColor = Color.White;
            btXoa.Location = new Point(736, 196);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(100, 38);
            btXoa.TabIndex = 24;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btSua
            // 
            btSua.BackColor = Color.MediumSlateBlue;
            btSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSua.ForeColor = Color.White;
            btSua.Location = new Point(630, 196);
            btSua.Name = "btSua";
            btSua.Size = new Size(100, 38);
            btSua.TabIndex = 23;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = false;
            btSua.Click += btSua_Click;
            // 
            // btLuu
            // 
            btLuu.BackColor = Color.MediumSlateBlue;
            btLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLuu.ForeColor = Color.White;
            btLuu.Location = new Point(524, 196);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(100, 38);
            btLuu.TabIndex = 22;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = false;
            btLuu.Click += btLuu_Click;
            // 
            // btThem
            // 
            btThem.BackColor = Color.MediumSlateBlue;
            btThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThem.ForeColor = Color.White;
            btThem.Location = new Point(418, 196);
            btThem.Name = "btThem";
            btThem.Size = new Size(100, 38);
            btThem.TabIndex = 21;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenNV, LoaiBaoHiem, NgayHetHan });
            dataGridView1.Location = new Point(46, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1178, 314);
            dataGridView1.TabIndex = 25;
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
            // LoaiBaoHiem
            // 
            LoaiBaoHiem.DataPropertyName = "LoaiBaoHiem";
            LoaiBaoHiem.HeaderText = "Loại Bảo Hiểm";
            LoaiBaoHiem.MinimumWidth = 6;
            LoaiBaoHiem.Name = "LoaiBaoHiem";
            LoaiBaoHiem.ReadOnly = true;
            // 
            // NgayHetHan
            // 
            NgayHetHan.DataPropertyName = "NgayHetHan";
            NgayHetHan.HeaderText = "Ngày Hết Hạn";
            NgayHetHan.MinimumWidth = 6;
            NgayHetHan.Name = "NgayHetHan";
            NgayHetHan.ReadOnly = true;
            // 
            // lbTB
            // 
            lbTB.AutoSize = true;
            lbTB.ForeColor = Color.Red;
            lbTB.Location = new Point(290, 206);
            lbTB.Name = "lbTB";
            lbTB.Size = new Size(0, 20);
            lbTB.TabIndex = 26;
            // 
            // BaoHiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbTB);
            Controls.Add(dataGridView1);
            Controls.Add(btXoa);
            Controls.Add(btSua);
            Controls.Add(btLuu);
            Controls.Add(btThem);
            Controls.Add(label7);
            Controls.Add(cbLoai);
            Controls.Add(dtpNgayCap);
            Controls.Add(dtpNgayHH);
            Controls.Add(txtTen);
            Controls.Add(txtSo);
            Controls.Add(txtNoiCap);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "BaoHiem";
            Size = new Size(1276, 603);
            Load += BaoHiem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNoiCap;
        private TextBox txtSo;
        private TextBox txtTen;
        private DateTimePicker dtpNgayHH;
        private DateTimePicker dtpNgayCap;
        private ComboBox cbLoai;
        private Label label7;
        private Button btXoa;
        private Button btSua;
        private Button btLuu;
        private Button btThem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn LoaiBaoHiem;
        private DataGridViewTextBoxColumn NgayHetHan;
        private Label lbTB;
    }
}
