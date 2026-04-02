namespace QuanLyNhanSu.TK
{
    partial class tkNVNghiCoPhep
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
            rdT = new RadioButton();
            rdNTN = new RadioButton();
            txtNgay = new TextBox();
            cbThang = new ComboBox();
            cbNam = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btXem = new Button();
            dtgv = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            ntn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 0);
            label1.Name = "label1";
            label1.Size = new Size(446, 38);
            label1.TabIndex = 1;
            label1.Text = "XEM NHÂN VIÊN NGHĨ CÓ PHÉP";
            // 
            // rdT
            // 
            rdT.AutoSize = true;
            rdT.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdT.Location = new Point(117, 119);
            rdT.Name = "rdT";
            rdT.Size = new Size(250, 27);
            rdT.TabIndex = 25;
            rdT.TabStop = true;
            rdT.Text = "Xem theo tháng trong năm";
            rdT.UseVisualStyleBackColor = true;
            rdT.CheckedChanged += rdT_CheckedChanged;
            // 
            // rdNTN
            // 
            rdNTN.AutoSize = true;
            rdNTN.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdNTN.Location = new Point(117, 60);
            rdNTN.Name = "rdNTN";
            rdNTN.Size = new Size(244, 27);
            rdNTN.TabIndex = 26;
            rdNTN.TabStop = true;
            rdNTN.Text = "Xem theo ngày tháng năm";
            rdNTN.UseVisualStyleBackColor = true;
            rdNTN.CheckedChanged += rdNTN_CheckedChanged;
            // 
            // txtNgay
            // 
            txtNgay.Location = new Point(417, 96);
            txtNgay.Name = "txtNgay";
            txtNgay.Size = new Size(72, 27);
            txtNgay.TabIndex = 27;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cbThang.Location = new Point(517, 96);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(53, 28);
            cbThang.TabIndex = 28;
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Items.AddRange(new object[] { "2016", "2017", "2018", "2019", "2020" });
            cbNam.Location = new Point(597, 96);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(88, 28);
            cbNam.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(496, 100);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 30;
            label2.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(576, 98);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 31;
            label3.Text = "/";
            // 
            // btXem
            // 
            btXem.BackColor = Color.MediumSlateBlue;
            btXem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXem.ForeColor = Color.White;
            btXem.Location = new Point(274, 170);
            btXem.Name = "btXem";
            btXem.Size = new Size(337, 38);
            btXem.TabIndex = 32;
            btXem.Text = "Xem";
            btXem.UseVisualStyleBackColor = false;
            btXem.Click += btXem_Click;
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
            dtgv.TabIndex = 33;
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
            // tkNVNghiCoPhep
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
            Controls.Add(rdNTN);
            Controls.Add(rdT);
            Controls.Add(label1);
            Name = "tkNVNghiCoPhep";
            Size = new Size(865, 513);
            Load += tkNVNghiCoPhep_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rdT;
        private RadioButton rdNTN;
        private TextBox txtNgay;
        private ComboBox cbThang;
        private ComboBox cbNam;
        private Label label2;
        private Label label3;
        private Button btXem;
        private DataGridView dtgv;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn ntn;
    }
}
