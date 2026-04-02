namespace QuanLyNhanSu.TK
{
    partial class tkSoNgayDiLam
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
            label3 = new Label();
            cbNam = new ComboBox();
            cbThang = new ComboBox();
            label2 = new Label();
            btXem = new Button();
            dataGridView1 = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            Ng = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 38);
            label1.TabIndex = 35;
            label1.Text = "SỐ NGÀY ĐI LÀM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 94);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 44;
            label3.Text = "/";
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Items.AddRange(new object[] { "2016", "2017", "2018", "2019", "2020" });
            cbNam.Location = new Point(297, 92);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(88, 28);
            cbNam.TabIndex = 43;
            cbNam.SelectedIndexChanged += cbNam_SelectedIndexChanged;
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cbThang.Location = new Point(217, 92);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(53, 28);
            cbThang.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 100);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 45;
            label2.Text = "Xem theo tháng:";
            label2.Click += label2_Click;
            // 
            // btXem
            // 
            btXem.BackColor = Color.MediumSlateBlue;
            btXem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXem.ForeColor = Color.White;
            btXem.Location = new Point(420, 85);
            btXem.Name = "btXem";
            btXem.Size = new Size(337, 38);
            btXem.TabIndex = 46;
            btXem.Text = "Xem";
            btXem.UseVisualStyleBackColor = false;
            btXem.Click += btXem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaNV, TenNV, Ng });
            dataGridView1.Location = new Point(1, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(864, 341);
            dataGridView1.TabIndex = 47;
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
            // Ng
            // 
            Ng.DataPropertyName = "SoNN";
            Ng.HeaderText = "Ngày";
            Ng.MinimumWidth = 6;
            Ng.Name = "Ng";
            Ng.ReadOnly = true;
            // 
            // tkSoNgayDiLam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(btXem);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cbNam);
            Controls.Add(cbThang);
            Controls.Add(label1);
            Name = "tkSoNgayDiLam";
            Size = new Size(865, 513);
            Load += tkSoNgayDiLam_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private ComboBox cbNam;
        private ComboBox cbThang;
        private Label label2;
        private Button btXem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn Ng;
    }
}
