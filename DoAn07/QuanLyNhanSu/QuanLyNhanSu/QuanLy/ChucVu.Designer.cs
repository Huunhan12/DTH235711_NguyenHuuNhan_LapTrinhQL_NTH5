namespace QuanLyNhanSu.QuanLy
{
    partial class ChucVu
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            lbTB = new Label();
            dataGridView1 = new DataGridView();
            MaCV = new DataGridViewTextBoxColumn();
            TenCV = new DataGridViewTextBoxColumn();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            btnSua = new Guna.UI2.WinForms.Guna2Button();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            txtMaCV = new Guna.UI2.WinForms.Guna2TextBox();
            txtTenCV = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTB);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtMaCV);
            panel1.Controls.Add(txtTenCV);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1105, 348);
            panel1.TabIndex = 0;
            // 
            // lbTB
            // 
            lbTB.AutoSize = true;
            lbTB.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTB.ForeColor = Color.IndianRed;
            lbTB.Location = new Point(18, 330);
            lbTB.Name = "lbTB";
            lbTB.Size = new Size(55, 23);
            lbTB.TabIndex = 53;
            lbTB.Text = "label3";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaCV, TenCV });
            dataGridView1.Location = new Point(546, 61);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(559, 271);
            dataGridView1.TabIndex = 52;
            // 
            // MaCV
            // 
            MaCV.DataPropertyName = "MaCV";
            MaCV.HeaderText = "Mã Chức Vụ";
            MaCV.MinimumWidth = 6;
            MaCV.Name = "MaCV";
            MaCV.ReadOnly = true;
            // 
            // TenCV
            // 
            TenCV.DataPropertyName = "TenCV";
            TenCV.HeaderText = "Tên Chức Vụ";
            TenCV.MinimumWidth = 6;
            TenCV.Name = "TenCV";
            TenCV.ReadOnly = true;
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
            btnLuu.Location = new Point(251, 197);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLuu.Size = new Size(178, 38);
            btnLuu.TabIndex = 51;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.BorderRadius = 20;
            btnSua.CustomizableEdges = customizableEdges3;
            btnSua.DisabledState.BorderColor = Color.DarkGray;
            btnSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSua.FillColor = Color.MediumSlateBlue;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(44, 259);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSua.Size = new Size(178, 38);
            btnSua.TabIndex = 50;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BorderRadius = 20;
            btnXoa.CustomizableEdges = customizableEdges5;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.FillColor = Color.MediumSlateBlue;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(251, 259);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnXoa.Size = new Size(178, 38);
            btnXoa.TabIndex = 49;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BorderRadius = 20;
            btnThem.CustomizableEdges = customizableEdges7;
            btnThem.DisabledState.BorderColor = Color.DarkGray;
            btnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThem.FillColor = Color.MediumSlateBlue;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(44, 197);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnThem.Size = new Size(178, 38);
            btnThem.TabIndex = 48;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // txtMaCV
            // 
            txtMaCV.BorderColor = Color.Black;
            txtMaCV.BorderRadius = 15;
            txtMaCV.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            txtMaCV.CustomizableEdges = customizableEdges9;
            txtMaCV.DefaultText = "";
            txtMaCV.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaCV.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaCV.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaCV.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaCV.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaCV.Font = new Font("Segoe UI", 9F);
            txtMaCV.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaCV.Location = new Point(158, 55);
            txtMaCV.Margin = new Padding(3, 4, 3, 4);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.PlaceholderForeColor = Color.White;
            txtMaCV.PlaceholderText = "";
            txtMaCV.SelectedText = "";
            txtMaCV.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtMaCV.Size = new Size(271, 33);
            txtMaCV.TabIndex = 21;
            // 
            // txtTenCV
            // 
            txtTenCV.BorderColor = Color.Black;
            txtTenCV.BorderRadius = 15;
            txtTenCV.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            txtTenCV.CustomizableEdges = customizableEdges11;
            txtTenCV.DefaultText = "";
            txtTenCV.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenCV.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenCV.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenCV.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenCV.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenCV.Font = new Font("Segoe UI", 9F);
            txtTenCV.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenCV.Location = new Point(158, 125);
            txtTenCV.Margin = new Padding(3, 4, 3, 4);
            txtTenCV.Name = "txtTenCV";
            txtTenCV.PlaceholderForeColor = Color.White;
            txtTenCV.PlaceholderText = "";
            txtTenCV.SelectedText = "";
            txtTenCV.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtTenCV.Size = new Size(271, 33);
            txtTenCV.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 65);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 12;
            label2.Text = "Mã chức vụ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 135);
            label7.Name = "label7";
            label7.Size = new Size(108, 23);
            label7.TabIndex = 11;
            label7.Text = "Tên chức vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(476, -3);
            label1.Name = "label1";
            label1.Size = new Size(141, 38);
            label1.TabIndex = 0;
            label1.Text = "CHỨC VỤ";
            // 
            // ChucVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ChucVu";
            Size = new Size(1196, 436);
            Load += ChucVu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtMaCV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenCV;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaCV;
        private DataGridViewTextBoxColumn TenCV;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Label lbTB;
    }
}
