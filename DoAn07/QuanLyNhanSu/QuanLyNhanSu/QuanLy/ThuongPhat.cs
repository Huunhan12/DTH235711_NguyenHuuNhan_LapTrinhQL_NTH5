using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.QuanLy
{
    public partial class ThuongPhat : UserControl
    {
        public ThuongPhat()
        {
            InitializeComponent();
        }

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
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnLuu = new Guna.UI2.WinForms.Guna2Button();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            dataGridView1 = new DataGridView();
            TenNhanVien = new DataGridViewTextBoxColumn();
            Loai = new DataGridViewTextBoxColumn();
            VND = new DataGridViewTextBoxColumn();
            LyDo = new DataGridViewTextBoxColumn();
            rdPhat = new RadioButton();
            rdThuong = new RadioButton();
            txtLyDo = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            label2 = new Label();
            txtT = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            cbThang = new ComboBox();
            cbNam = new ComboBox();
            label8 = new Label();
            btXem = new Guna.UI2.WinForms.Guna2Button();
            label7 = new Label();
            cbPhongBan = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(rdPhat);
            panel1.Controls.Add(rdThuong);
            panel1.Controls.Add(txtLyDo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtT);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbThang);
            panel1.Controls.Add(cbNam);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btXem);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbPhongBan);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 484);
            panel1.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.BorderRadius = 20;
            btnXoa.CustomizableEdges = customizableEdges1;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.FillColor = Color.MediumSlateBlue;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(963, 393);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnXoa.Size = new Size(128, 44);
            btnXoa.TabIndex = 74;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BorderRadius = 20;
            btnLuu.CustomizableEdges = customizableEdges3;
            btnLuu.DisabledState.BorderColor = Color.DarkGray;
            btnLuu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLuu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLuu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLuu.FillColor = Color.MediumSlateBlue;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(816, 393);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLuu.Size = new Size(128, 44);
            btnLuu.TabIndex = 73;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.BorderRadius = 20;
            btnThem.CustomizableEdges = customizableEdges5;
            btnThem.DisabledState.BorderColor = Color.DarkGray;
            btnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThem.FillColor = Color.MediumSlateBlue;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(669, 393);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnThem.Size = new Size(128, 44);
            btnThem.TabIndex = 72;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TenNhanVien, Loai, VND, LyDo });
            dataGridView1.Location = new Point(0, 154);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(632, 327);
            dataGridView1.TabIndex = 9;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNV";
            TenNhanVien.HeaderText = "Tên Nhân Viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            // 
            // Loai
            // 
            Loai.DataPropertyName = "Loai";
            Loai.HeaderText = "Thưởng/Phạt";
            Loai.MinimumWidth = 6;
            Loai.Name = "Loai";
            Loai.ReadOnly = true;
            // 
            // VND
            // 
            VND.DataPropertyName = "Tien";
            VND.HeaderText = "VND";
            VND.MinimumWidth = 6;
            VND.Name = "VND";
            VND.ReadOnly = true;
            // 
            // LyDo
            // 
            LyDo.DataPropertyName = "LyDo";
            LyDo.HeaderText = "Lý Do";
            LyDo.MinimumWidth = 6;
            LyDo.Name = "LyDo";
            LyDo.ReadOnly = true;
            // 
            // rdPhat
            // 
            rdPhat.AutoSize = true;
            rdPhat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdPhat.Location = new Point(872, 108);
            rdPhat.Name = "rdPhat";
            rdPhat.Size = new Size(68, 29);
            rdPhat.TabIndex = 71;
            rdPhat.TabStop = true;
            rdPhat.Text = "Phạt";
            rdPhat.UseVisualStyleBackColor = true;
            // 
            // rdThuong
            // 
            rdThuong.AutoSize = true;
            rdThuong.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdThuong.Location = new Point(744, 108);
            rdThuong.Name = "rdThuong";
            rdThuong.Size = new Size(95, 29);
            rdThuong.TabIndex = 70;
            rdThuong.TabStop = true;
            rdThuong.Text = "Thưởng";
            rdThuong.UseVisualStyleBackColor = true;
            // 
            // txtLyDo
            // 
            txtLyDo.BorderColor = Color.Black;
            txtLyDo.BorderRadius = 15;
            txtLyDo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            txtLyDo.CustomizableEdges = customizableEdges7;
            txtLyDo.DefaultText = "";
            txtLyDo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLyDo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLyDo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLyDo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLyDo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLyDo.Font = new Font("Segoe UI", 9F);
            txtLyDo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLyDo.Location = new Point(740, 154);
            txtLyDo.Margin = new Padding(3, 4, 3, 4);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.PlaceholderForeColor = Color.White;
            txtLyDo.PlaceholderText = "";
            txtLyDo.SelectedText = "";
            txtLyDo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtLyDo.Size = new Size(341, 159);
            txtLyDo.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(669, 168);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 68;
            label4.Text = "Lý do:";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(669, 343);
            label2.Name = "label2";
            label2.Size = new Size(49, 23);
            label2.TabIndex = 67;
            label2.Text = "Tiền:";
            // 
            // txtT
            // 
            txtT.BorderColor = Color.Black;
            txtT.BorderRadius = 15;
            txtT.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            txtT.CustomizableEdges = customizableEdges9;
            txtT.DefaultText = "";
            txtT.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtT.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtT.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtT.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtT.Font = new Font("Segoe UI", 9F);
            txtT.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtT.Location = new Point(740, 333);
            txtT.Margin = new Padding(3, 4, 3, 4);
            txtT.Name = "txtT";
            txtT.PlaceholderForeColor = Color.White;
            txtT.PlaceholderText = "";
            txtT.SelectedText = "";
            txtT.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtT.Size = new Size(159, 33);
            txtT.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(905, 343);
            label6.Name = "label6";
            label6.Size = new Size(47, 23);
            label6.TabIndex = 65;
            label6.Text = "VND";
            // 
            // cbThang
            // 
            cbThang.FormattingEnabled = true;
            cbThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbThang.Location = new Point(756, 61);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(72, 28);
            cbThang.TabIndex = 64;
            // 
            // cbNam
            // 
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(855, 61);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(95, 28);
            cbNam.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(596, 66);
            label8.Name = "label8";
            label8.Size = new Size(139, 23);
            label8.TabIndex = 62;
            label8.Text = "Xem theo tháng";
            // 
            // btXem
            // 
            btXem.BorderRadius = 20;
            btXem.CustomizableEdges = customizableEdges11;
            btXem.DisabledState.BorderColor = Color.DarkGray;
            btXem.DisabledState.CustomBorderColor = Color.DarkGray;
            btXem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btXem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btXem.FillColor = Color.MediumSlateBlue;
            btXem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXem.ForeColor = Color.White;
            btXem.Location = new Point(976, 50);
            btXem.Name = "btXem";
            btXem.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btXem.Size = new Size(128, 44);
            btXem.TabIndex = 61;
            btXem.Text = "Xem";
            btXem.Click += btXem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(834, 63);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 59;
            label7.Text = "/";
            // 
            // cbPhongBan
            // 
            cbPhongBan.FormattingEnabled = true;
            cbPhongBan.Items.AddRange(new object[] { "Tất Cả", "Phòng Giám Đốc", "Phòng Phó Giám Đốc", "Phòng Kế Toán", "Phòng Kinh Doanh", "Phòng Kỹ Thuật" });
            cbPhongBan.Location = new Point(159, 61);
            cbPhongBan.Name = "cbPhongBan";
            cbPhongBan.Size = new Size(151, 28);
            cbPhongBan.TabIndex = 16;
            cbPhongBan.SelectedIndexChanged += cbPhongBan_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 66);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 15;
            label3.Text = "Phòng ban:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(429, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 38);
            label1.TabIndex = 0;
            label1.Text = "THƯỞNG PHẠT";
            // 
            // ThuongPhat
            // 
            Controls.Add(panel1);
            Name = "ThuongPhat";
            Size = new Size(1169, 583);
            Load += ThuongPhat_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        string mapb = null, manv = null, tenpb = null;
        string tennv = null, loai = null;
        int tien = 0, thang = DateTime.Now.Month, nam = DateTime.Now.Year;
        DateTime nd, nc;
        private void load()
        {
            nd = Convert.ToDateTime(thang + "/1" + "/" + nam);
            nc = Convert.ToDateTime(thang + "/30" + "/" + nam);
            txtLyDo.Enabled = false;
            txtT.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            rdThuong.Enabled = false;
            rdPhat.Enabled = false;
            cbThang.Text = thang.ToString(); ;
            cbNam.Text = nam.ToString();
            cbPhongBan.Text = "Tất Cả";
            dt.Clear();
            dt = cl.LayNhanVienTuMaPB("0", nd, nc);
            dataGridView1.DataSource = dt;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ThuongPhat_Load(object sender, EventArgs e)
        {
            load();
        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLyDo.Enabled = false;
            txtT.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtLyDo.Text = null;
            txtT.Text = null;
            if (cbPhongBan.Text == "Tất Cả")
                load();
            else
            {
                dr = cl.layMaPBTuTenPB(cbPhongBan.Text);
                while (dr.Read())
                    mapb = dr.GetString(0);
                dt.Clear();
                dt = cl.LayNhanVienTuMaPB(mapb, nd, nc);
                dataGridView1.DataSource = dt;
            }
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtLyDo.Enabled = true;
            txtT.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            rdThuong.Enabled = true;
            rdPhat.Enabled = true;
            tennv = dataGridView1.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["Loai"].Value.ToString() == "Thưởng")
            {
                rdThuong.Checked = true;
                loai = "Thưởng";
            }
            else
            {
                rdPhat.Checked = true;
                loai = "Phạt";
            }
            txtLyDo.Text = dataGridView1.CurrentRow.Cells["LyDo"].Value.ToString();
            txtT.Text = dataGridView1.CurrentRow.Cells["VND"].Value.ToString();
            cbPhongBan.Text = layTenPhongBan(layMaNhanVien(tennv));
        }
        private string layMaNhanVien(string tennv)
        {
            dr = cl.layMaNVTuTenNV(tennv);
            while (dr.Read())
                manv = dr.GetString(0);
            return manv;
        }
        private string layTenPhongBan(string ma)
        {
            dr = cl.layTenPBTuMaNV(ma);
            while (dr.Read())
                tenpb = dr.GetString(0);
            return tenpb;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPhongBan.Text) || cbPhongBan.Text == "Tất Cả")
                MessageBox.Show("Vui lòng chọn Phòng Ban và Tên nhân viên trước");
            else
            {
                txtLyDo.Enabled = true;
                txtT.Enabled = true;
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                rdThuong.Enabled = true;
                rdPhat.Enabled = true;
                txtLyDo.Text = null;
                txtT.Text = null;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (rdPhat.Checked == true)
                loai = "Phạt";
            else loai = "Thưởng";
            if (!string.IsNullOrEmpty(txtLyDo.Text))
            {
                if (!string.IsNullOrEmpty(txtT.Text))
                {
                    dr = cl.ThemThuongPhat(layMaNhanVien(tennv), loai, Convert.ToInt32(txtT.Text), txtLyDo.Text, DateTime.Now);
                    load();
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (rdPhat.Checked == true)
                loai = "Phạt";
            else loai = "Thưởng";
            if (MessageBox.Show("Bạn Thật Sự Muốn Xóa!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dr = cl.XoaThuongPhat(layMaNhanVien(tennv), loai, Convert.ToInt32(txtT.Text), txtLyDo.Text);
                load();
            }
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            nd = Convert.ToDateTime(cbThang.Text + "/1" + "/" + cbNam.Text);
            nc = Convert.ToDateTime(cbThang.Text + "/30" + "/" + cbNam.Text);
            dt.Clear();
            dt = cl.LayNhanVienTuMaPB("0", nd, nc);
            dataGridView1.DataSource = dt;
        }
    }
}
