namespace QuanLyNhanSu.NhanVien
{
    partial class ktNhanVien
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            ibH = new Label();
            txtH = new TextBox();
            label6 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ibH);
            panel1.Controls.Add(txtH);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 519);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaNV, TenNV, GioiTinh, ChucVu });
            dataGridView1.Location = new Point(0, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(986, 319);
            dataGridView1.TabIndex = 26;
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
            TenNV.HeaderText = "Tên Nhân Viên";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            TenNV.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // ChucVu
            // 
            ChucVu.DataPropertyName = "TenCV";
            ChucVu.HeaderText = "Chức Vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            ChucVu.ReadOnly = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(865, 80);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(55, 27);
            radioButton3.TabIndex = 25;
            radioButton3.TabStop = true;
            radioButton3.Text = "Nữ";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(765, 80);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 27);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nam";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(655, 78);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(79, 27);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tất cả";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(331, 136);
            button1.Name = "button1";
            button1.Size = new Size(296, 38);
            button1.TabIndex = 22;
            button1.Text = "Xem Kết Quả";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ibH
            // 
            ibH.AutoSize = true;
            ibH.BackColor = Color.White;
            ibH.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibH.Location = new Point(607, 80);
            ibH.Name = "ibH";
            ibH.Size = new Size(20, 25);
            ibH.TabIndex = 16;
            ibH.Text = "?";
            ibH.Click += label2_Click;
            // 
            // txtH
            // 
            txtH.Location = new Point(161, 78);
            txtH.Name = "txtH";
            txtH.Size = new Size(440, 27);
            txtH.TabIndex = 15;
            txtH.TextChanged += txtH_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 82);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 14;
            label6.Text = "Nội dung cần tìm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 0);
            label1.Name = "label1";
            label1.Size = new Size(475, 38);
            label1.TabIndex = 0;
            label1.Text = "TÌM KIẾM THÔNG TIN NHÂN VIÊN";
            // 
            // ktNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ktNhanVien";
            Size = new Size(1058, 543);
            Load += ktNhanVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label ibH;
        private TextBox txtH;
        private Label label6;
        private Button button1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn ChucVu;
    }
}
