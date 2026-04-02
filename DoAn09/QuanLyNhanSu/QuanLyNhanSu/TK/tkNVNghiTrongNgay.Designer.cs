namespace QuanLyNhanSu.TK
{
    partial class tkNVNghiTrongNgay
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
            dtgv = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            ntn = new DataGridViewTextBoxColumn();
            btXem = new Button();
            label3 = new Label();
            label2 = new Label();
            cbNam = new ComboBox();
            cbThang = new ComboBox();
            txtNgay = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgv).BeginInit();
            SuspendLayout();
            // 
            // dtgv
            // 
            dtgv.AllowUserToAddRows = false;
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv.Columns.AddRange(new DataGridViewColumn[] { MaNV, TenNV, ntn });
            dtgv.Location = new Point(0, 227);
            dtgv.Name = "dtgv";
            dtgv.ReadOnly = true;
            dtgv.RowHeadersWidth = 51;
            dtgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv.Size = new Size(865, 286);
            dtgv.TabIndex = 43;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNhanVien";
            MaNV.HeaderText = "Mã Nhân Viên";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "TenNV";
            TenNV.HeaderText = "Tên Nhân Viên";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            TenNV.ReadOnly = true;
            // 
            // ntn
            // 
            ntn.DataPropertyName = "Ngay";
            ntn.HeaderText = "Ngày";
            ntn.MinimumWidth = 6;
            ntn.Name = "ntn";
            ntn.ReadOnly = true;
            // 
            // btXem
            // 
            btXem.BackColor = Color.MediumSlateBlue;
            btXem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXem.ForeColor = Color.White;
            btXem.Location = new Point(274, 170);
            btXem.Name = "btXem";
            btXem.Size = new Size(337, 38);
            btXem.TabIndex = 42;
            btXem.Text = "Xem";
            btXem.UseVisualStyleBackColor = false;
            btXem.Click += btXem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(576, 98);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 41;
            label3.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(496, 100);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 40;
            label2.Text = "/";
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Items.AddRange(new object[] { "2016", "2017", "2018", "2019", "2020" });
            cbNam.Location = new Point(597, 96);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(88, 28);
            cbNam.TabIndex = 39;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cbThang.Location = new Point(517, 96);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(53, 28);
            cbThang.TabIndex = 38;
            // 
            // txtNgay
            // 
            txtNgay.Location = new Point(417, 96);
            txtNgay.Name = "txtNgay";
            txtNgay.Size = new Size(72, 27);
            txtNgay.TabIndex = 37;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(117, 60);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(244, 27);
            radioButton1.TabIndex = 36;
            radioButton1.TabStop = true;
            radioButton1.Text = "Xem theo ngày tháng năm";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(117, 119);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(250, 27);
            radioButton2.TabIndex = 35;
            radioButton2.TabStop = true;
            radioButton2.Text = "Xem theo tháng trong năm";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 0);
            label1.Name = "label1";
            label1.Size = new Size(392, 38);
            label1.TabIndex = 34;
            label1.Text = "XEM NHÂN VIÊN NGHĨ LÀM";
            // 
            // tkNVNghiTrongNgay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgv);
            Controls.Add(btXem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbNam);
            Controls.Add(cbThang);
            Controls.Add(txtNgay);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(label1);
            Name = "tkNVNghiTrongNgay";
            Size = new Size(865, 513);
            Load += tkNVNghiTrongNgay_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn ntn;
        private Button btXem;
        private Label label3;
        private Label label2;
        private ComboBox cbNam;
        private ComboBox cbThang;
        private TextBox txtNgay;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
    }
}
