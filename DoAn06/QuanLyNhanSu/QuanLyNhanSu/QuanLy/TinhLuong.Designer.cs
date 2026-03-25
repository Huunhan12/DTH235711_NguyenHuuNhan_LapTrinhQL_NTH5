namespace QuanLyNhanSu.QuanLy
{
    partial class TinhLuong
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
            dataGridView1 = new DataGridView();
            Ma = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            HeSoLuong = new DataGridViewTextBoxColumn();
            SNL = new DataGridViewTextBoxColumn();
            T = new DataGridViewTextBoxColumn();
            P = new DataGridViewTextBoxColumn();
            PhuCap = new DataGridViewTextBoxColumn();
            TL = new DataGridViewTextBoxColumn();
            lbChucVu = new Label();
            lbTen = new Label();
            btCapNhat = new Guna.UI2.WinForms.Guna2Button();
            cbHeSoLuong = new ComboBox();
            txtLCB = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            btXem = new Guna.UI2.WinForms.Guna2Button();
            txtNam = new TextBox();
            label7 = new Label();
            txtThang = new TextBox();
            lbTB = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lbChucVu);
            panel1.Controls.Add(lbTen);
            panel1.Controls.Add(btCapNhat);
            panel1.Controls.Add(cbHeSoLuong);
            panel1.Controls.Add(txtLCB);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(16, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 367);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ma, TenNV, HeSoLuong, SNL, T, P, PhuCap, TL });
            dataGridView1.Location = new Point(0, 177);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1054, 188);
            dataGridView1.TabIndex = 52;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Ma
            // 
            Ma.DataPropertyName = "MaNhanVien";
            Ma.HeaderText = "Mã Nhân Viên";
            Ma.MinimumWidth = 6;
            Ma.Name = "Ma";
            Ma.ReadOnly = true;
            Ma.Width = 125;
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "TenNV";
            TenNV.HeaderText = "Tên Nhân Viên";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            TenNV.ReadOnly = true;
            TenNV.Width = 125;
            // 
            // HeSoLuong
            // 
            HeSoLuong.DataPropertyName = "HeSoLuong";
            HeSoLuong.HeaderText = "Hệ Số Lương";
            HeSoLuong.MinimumWidth = 6;
            HeSoLuong.Name = "HeSoLuong";
            HeSoLuong.ReadOnly = true;
            HeSoLuong.Width = 125;
            // 
            // SNL
            // 
            SNL.DataPropertyName = "NL";
            SNL.HeaderText = "Số Ngày Làm";
            SNL.MinimumWidth = 6;
            SNL.Name = "SNL";
            SNL.ReadOnly = true;
            SNL.Width = 125;
            // 
            // T
            // 
            T.DataPropertyName = "T";
            T.HeaderText = "Tiền Thưởng";
            T.MinimumWidth = 6;
            T.Name = "T";
            T.ReadOnly = true;
            T.Width = 125;
            // 
            // P
            // 
            P.DataPropertyName = "P";
            P.HeaderText = "Tiền Phạt";
            P.MinimumWidth = 6;
            P.Name = "P";
            P.ReadOnly = true;
            P.Width = 125;
            // 
            // PhuCap
            // 
            PhuCap.DataPropertyName = "Tien";
            PhuCap.HeaderText = "Phụ Cấp";
            PhuCap.MinimumWidth = 6;
            PhuCap.Name = "PhuCap";
            PhuCap.ReadOnly = true;
            PhuCap.Width = 125;
            // 
            // TL
            // 
            TL.DataPropertyName = "TL";
            TL.HeaderText = "Tổng Lương";
            TL.MinimumWidth = 6;
            TL.Name = "TL";
            TL.ReadOnly = true;
            TL.Width = 125;
            // 
            // lbChucVu
            // 
            lbChucVu.AutoSize = true;
            lbChucVu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbChucVu.Location = new Point(155, 112);
            lbChucVu.Name = "lbChucVu";
            lbChucVu.Size = new Size(70, 23);
            lbChucVu.TabIndex = 51;
            lbChucVu.Text = "ChucVu";
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTen.Location = new Point(155, 58);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(36, 23);
            lbTen.TabIndex = 50;
            lbTen.Text = "Ten";
            // 
            // btCapNhat
            // 
            btCapNhat.BorderRadius = 20;
            btCapNhat.CustomizableEdges = customizableEdges1;
            btCapNhat.DisabledState.BorderColor = Color.DarkGray;
            btCapNhat.DisabledState.CustomBorderColor = Color.DarkGray;
            btCapNhat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btCapNhat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btCapNhat.FillColor = Color.MediumSlateBlue;
            btCapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCapNhat.ForeColor = Color.White;
            btCapNhat.Location = new Point(722, 94);
            btCapNhat.Name = "btCapNhat";
            btCapNhat.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btCapNhat.Size = new Size(195, 38);
            btCapNhat.TabIndex = 49;
            btCapNhat.Text = "Cập nhật";
            btCapNhat.Click += btCapNhat_Click;
            // 
            // cbHeSoLuong
            // 
            cbHeSoLuong.FormattingEnabled = true;
            cbHeSoLuong.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbHeSoLuong.Location = new Point(466, 53);
            cbHeSoLuong.Name = "cbHeSoLuong";
            cbHeSoLuong.Size = new Size(159, 28);
            cbHeSoLuong.TabIndex = 24;
            cbHeSoLuong.SelectedIndexChanged += cbHeSoLuong_SelectedIndexChanged;
            // 
            // txtLCB
            // 
            txtLCB.BorderColor = Color.Black;
            txtLCB.BorderRadius = 15;
            txtLCB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            txtLCB.CustomizableEdges = customizableEdges3;
            txtLCB.DefaultText = "";
            txtLCB.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLCB.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLCB.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLCB.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLCB.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLCB.Font = new Font("Segoe UI", 9F);
            txtLCB.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLCB.Location = new Point(466, 99);
            txtLCB.Margin = new Padding(3, 4, 3, 4);
            txtLCB.Name = "txtLCB";
            txtLCB.PlaceholderForeColor = Color.White;
            txtLCB.PlaceholderText = "";
            txtLCB.SelectedText = "";
            txtLCB.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtLCB.Size = new Size(159, 33);
            txtLCB.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(631, 109);
            label6.Name = "label6";
            label6.Size = new Size(47, 23);
            label6.TabIndex = 17;
            label6.Text = "VND";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(334, 109);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 16;
            label5.Text = "Lương cơ bản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(334, 58);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 15;
            label4.Text = "Hệ số lương:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 58);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 14;
            label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 109);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 13;
            label2.Text = "Chức vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 0);
            label1.Name = "label1";
            label1.Size = new Size(371, 38);
            label1.TabIndex = 0;
            label1.Text = "BẢNG LƯƠNG NHÂN VIÊN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(518, 415);
            label8.Name = "label8";
            label8.Size = new Size(197, 23);
            label8.TabIndex = 57;
            label8.Text = "Bảng lương theo tháng";
            // 
            // btXem
            // 
            btXem.BorderRadius = 20;
            btXem.CustomizableEdges = customizableEdges5;
            btXem.DisabledState.BorderColor = Color.DarkGray;
            btXem.DisabledState.CustomBorderColor = Color.DarkGray;
            btXem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btXem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btXem.FillColor = Color.MediumSlateBlue;
            btXem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXem.ForeColor = Color.White;
            btXem.Location = new Point(933, 401);
            btXem.Name = "btXem";
            btXem.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btXem.Size = new Size(128, 44);
            btXem.TabIndex = 56;
            btXem.Text = "Xem";
            btXem.Click += btXem_Click;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(812, 411);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(99, 27);
            txtNam.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(791, 414);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 54;
            label7.Text = "/";
            // 
            // txtThang
            // 
            txtThang.Location = new Point(724, 411);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(61, 27);
            txtThang.TabIndex = 53;
            // 
            // lbTB
            // 
            lbTB.AutoSize = true;
            lbTB.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTB.ForeColor = Color.IndianRed;
            lbTB.Location = new Point(426, 418);
            lbTB.Name = "lbTB";
            lbTB.Size = new Size(0, 20);
            lbTB.TabIndex = 58;
            // 
            // TinhLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(lbTB);
            Controls.Add(btXem);
            Controls.Add(panel1);
            Controls.Add(txtNam);
            Controls.Add(txtThang);
            Controls.Add(label7);
            Name = "TinhLuong";
            Size = new Size(1095, 505);
            Load += TinhLuong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtLCB;
        private ComboBox cbHeSoLuong;
        private Label lbChucVu;
        private Label lbTen;
        private Guna.UI2.WinForms.Guna2Button btCapNhat;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Ma;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn HeSoLuong;
        private DataGridViewTextBoxColumn SNL;
        private DataGridViewTextBoxColumn T;
        private DataGridViewTextBoxColumn P;
        private DataGridViewTextBoxColumn PhuCap;
        private DataGridViewTextBoxColumn TL;
        private Label label8;
        private Guna.UI2.WinForms.Guna2Button btXem;
        private TextBox txtNam;
        private Label label7;
        private TextBox txtThang;
        private Label lbTB;
    }
}
