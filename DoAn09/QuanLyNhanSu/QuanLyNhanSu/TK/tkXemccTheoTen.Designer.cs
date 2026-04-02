namespace QuanLyNhanSu.TK
{
    partial class tkXemccTheoTen
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
            btXem = new Button();
            label2 = new Label();
            label3 = new Label();
            cbNam = new ComboBox();
            cbThang = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            txtTen = new TextBox();
            dataGridView1 = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            Tt = new DataGridViewTextBoxColumn();
            Ng = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btXem
            // 
            btXem.BackColor = Color.MediumSlateBlue;
            btXem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXem.ForeColor = Color.White;
            btXem.Location = new Point(519, 72);
            btXem.Name = "btXem";
            btXem.Size = new Size(145, 83);
            btXem.TabIndex = 51;
            btXem.Text = "Xem";
            btXem.UseVisualStyleBackColor = false;
            btXem.Click += btXem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 87);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 50;
            label2.Text = "Xem theo tháng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 81);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 49;
            label3.Text = "/";
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Items.AddRange(new object[] { "2016", "2017", "2018", "2019", "2020" });
            cbNam.Location = new Point(396, 79);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(88, 28);
            cbNam.TabIndex = 48;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cbThang.Location = new Point(316, 79);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(53, 28);
            cbThang.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 0);
            label1.Name = "label1";
            label1.Size = new Size(385, 38);
            label1.TabIndex = 52;
            label1.Text = "XEM THEO TÊN NHÂN VIÊN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 135);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 53;
            label4.Text = "Tên nhân viên:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(316, 128);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(168, 27);
            txtTen.TabIndex = 54;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaNV, TenNV, Tt, Ng });
            dataGridView1.Location = new Point(0, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(865, 331);
            dataGridView1.TabIndex = 55;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNhanVien";
            MaNV.HeaderText = "Mã Nhân Viên";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.ReadOnly = true;
            MaNV.Width = 206;
            // 
            // TenNV
            // 
            TenNV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenNV.DataPropertyName = "TenNV";
            TenNV.HeaderText = "Tên Nhân Viên";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            TenNV.ReadOnly = true;
            // 
            // Tt
            // 
            Tt.DataPropertyName = "TinhTrang";
            Tt.HeaderText = "Tình Trạng";
            Tt.MinimumWidth = 6;
            Tt.Name = "Tt";
            Tt.ReadOnly = true;
            Tt.Width = 205;
            // 
            // Ng
            // 
            Ng.DataPropertyName = "Ngay";
            Ng.HeaderText = "Ngày";
            Ng.MinimumWidth = 6;
            Ng.Name = "Ng";
            Ng.ReadOnly = true;
            Ng.Width = 206;
            // 
            // tkXemccTheoTen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(txtTen);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btXem);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cbNam);
            Controls.Add(cbThang);
            Name = "tkXemccTheoTen";
            Size = new Size(865, 513);
            Load += tkXemccTheoTen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btXem;
        private Label label2;
        private Label label3;
        private ComboBox cbNam;
        private ComboBox cbThang;
        private Label label1;
        private Label label4;
        private TextBox txtTen;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn Tt;
        private DataGridViewTextBoxColumn Ng;
    }
}
