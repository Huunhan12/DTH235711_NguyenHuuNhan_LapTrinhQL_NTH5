namespace QuanLyNhanSu.CaiDat
{
    partial class TaoTaiKhoan
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            label6 = new Label();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            cbQuyen = new ComboBox();
            txtMK = new Guna.UI2.WinForms.Guna2TextBox();
            txtTK = new Guna.UI2.WinForms.Guna2TextBox();
            lbMaNV = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(cbQuyen);
            panel1.Controls.Add(txtMK);
            panel1.Controls.Add(txtTK);
            panel1.Controls.Add(lbMaNV);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 316);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenNhanVien, ChucVu });
            dataGridView1.Location = new Point(563, 110);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(480, 188);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã Nhân Viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            MaNhanVien.Width = 125;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNV";
            TenNhanVien.HeaderText = "Tên Nhân Viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            TenNhanVien.Width = 125;
            // 
            // ChucVu
            // 
            ChucVu.DataPropertyName = "TenCV";
            ChucVu.HeaderText = "Chức Vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            ChucVu.ReadOnly = true;
            ChucVu.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(624, 67);
            label6.Name = "label6";
            label6.Size = new Size(226, 23);
            label6.TabIndex = 24;
            label6.Text = "Nhân viên chưa có tài khản";
            label6.Click += label6_Click;
            // 
            // btnLuu
            // 
            btnLuu.BorderRadius = 20;
            btnLuu.CustomizableEdges = customizableEdges1;
            btnLuu.DisabledState.BorderColor = Color.DarkGray;
            btnLuu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLuu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLuu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLuu.FillColor = Color.MediumSlateBlue;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(197, 265);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLuu.Size = new Size(308, 38);
            btnLuu.TabIndex = 23;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // cbQuyen
            // 
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Items.AddRange(new object[] { "Super Admin", "Admin", "User " });
            cbQuyen.Location = new Point(197, 215);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new Size(308, 28);
            cbQuyen.TabIndex = 14;
            // 
            // txtMK
            // 
            txtMK.BorderColor = Color.Black;
            txtMK.BorderRadius = 15;
            txtMK.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            txtMK.CustomizableEdges = customizableEdges3;
            txtMK.DefaultText = "";
            txtMK.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMK.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMK.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMK.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMK.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMK.Font = new Font("Segoe UI", 9F);
            txtMK.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMK.Location = new Point(197, 162);
            txtMK.Margin = new Padding(3, 4, 3, 4);
            txtMK.Name = "txtMK";
            txtMK.PlaceholderForeColor = Color.White;
            txtMK.PlaceholderText = "";
            txtMK.SelectedText = "";
            txtMK.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMK.Size = new Size(308, 33);
            txtMK.TabIndex = 13;
            // 
            // txtTK
            // 
            txtTK.BorderColor = Color.Black;
            txtTK.BorderRadius = 15;
            txtTK.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            txtTK.CustomizableEdges = customizableEdges5;
            txtTK.DefaultText = "";
            txtTK.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTK.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTK.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTK.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTK.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTK.Font = new Font("Segoe UI", 9F);
            txtTK.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTK.Location = new Point(197, 110);
            txtTK.Margin = new Padding(3, 4, 3, 4);
            txtTK.Name = "txtTK";
            txtTK.PlaceholderForeColor = Color.White;
            txtTK.PlaceholderText = "";
            txtTK.SelectedText = "";
            txtTK.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTK.Size = new Size(308, 33);
            txtTK.TabIndex = 12;
            // 
            // lbMaNV
            // 
            lbMaNV.AutoSize = true;
            lbMaNV.Location = new Point(197, 70);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(50, 20);
            lbMaNV.TabIndex = 6;
            lbMaNV.Text = "label6";
            lbMaNV.Click += lbMaNV_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 220);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 5;
            label5.Text = "Quyền hạn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 172);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 4;
            label4.Text = "Mật khẩu: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 120);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 3;
            label3.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 69);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 2;
            label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(392, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 38);
            label1.TabIndex = 0;
            label1.Text = "THÊM TÀI KHOẢN ";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // TaoTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "TaoTaiKhoan";
            Size = new Size(1200, 411);
            Load += TaoTaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lbMaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtMK;
        private Guna.UI2.WinForms.Guna2TextBox txtTK;
        private ComboBox cbQuyen;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn ChucVu;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}
