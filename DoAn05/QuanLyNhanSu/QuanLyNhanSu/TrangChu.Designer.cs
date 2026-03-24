namespace QuanLyNhanSu
{
    partial class TrangChu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnCaiDat = new FontAwesome.Sharp.IconButton();
            btnThongKe = new FontAwesome.Sharp.IconButton();
            btnXemNV = new FontAwesome.Sharp.IconButton();
            btnQL = new FontAwesome.Sharp.IconButton();
            btnTrangChu = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelTileBar = new Panel();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(101, 113, 212);
            panelMenu.Controls.Add(btnCaiDat);
            panelMenu.Controls.Add(btnThongKe);
            panelMenu.Controls.Add(btnXemNV);
            panelMenu.Controls.Add(btnQL);
            panelMenu.Controls.Add(btnTrangChu);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(236, 609);
            panelMenu.TabIndex = 3;
            // 
            // btnCaiDat
            // 
            btnCaiDat.Dock = DockStyle.Bottom;
            btnCaiDat.FlatAppearance.BorderSize = 0;
            btnCaiDat.FlatStyle = FlatStyle.Flat;
            btnCaiDat.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCaiDat.ForeColor = Color.White;
            btnCaiDat.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            btnCaiDat.IconColor = Color.White;
            btnCaiDat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCaiDat.IconSize = 40;
            btnCaiDat.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaiDat.Location = new Point(0, 566);
            btnCaiDat.Name = "btnCaiDat";
            btnCaiDat.Padding = new Padding(10, 0, 0, 0);
            btnCaiDat.Size = new Size(236, 43);
            btnCaiDat.TabIndex = 5;
            btnCaiDat.Text = "    Cài đật";
            btnCaiDat.TextAlign = ContentAlignment.MiddleLeft;
            btnCaiDat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCaiDat.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.IconChar = FontAwesome.Sharp.IconChar.FileArrowDown;
            btnThongKe.IconColor = Color.White;
            btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThongKe.IconSize = 40;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(0, 254);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(10, 0, 0, 0);
            btnThongKe.Size = new Size(236, 43);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "    Thông kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnXemNV
            // 
            btnXemNV.Dock = DockStyle.Top;
            btnXemNV.FlatAppearance.BorderSize = 0;
            btnXemNV.FlatStyle = FlatStyle.Flat;
            btnXemNV.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXemNV.ForeColor = Color.White;
            btnXemNV.IconChar = FontAwesome.Sharp.IconChar.Elevator;
            btnXemNV.IconColor = Color.White;
            btnXemNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnXemNV.IconSize = 40;
            btnXemNV.ImageAlign = ContentAlignment.MiddleLeft;
            btnXemNV.Location = new Point(0, 211);
            btnXemNV.Name = "btnXemNV";
            btnXemNV.Padding = new Padding(10, 0, 0, 0);
            btnXemNV.Size = new Size(236, 43);
            btnXemNV.TabIndex = 3;
            btnXemNV.Text = "    Xem nhân viên";
            btnXemNV.TextAlign = ContentAlignment.MiddleLeft;
            btnXemNV.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXemNV.UseVisualStyleBackColor = true;
            // 
            // btnQL
            // 
            btnQL.Dock = DockStyle.Top;
            btnQL.FlatAppearance.BorderSize = 0;
            btnQL.FlatStyle = FlatStyle.Flat;
            btnQL.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQL.ForeColor = Color.White;
            btnQL.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            btnQL.IconColor = Color.White;
            btnQL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQL.IconSize = 40;
            btnQL.ImageAlign = ContentAlignment.MiddleLeft;
            btnQL.Location = new Point(0, 168);
            btnQL.Name = "btnQL";
            btnQL.Padding = new Padding(10, 0, 0, 0);
            btnQL.Size = new Size(236, 43);
            btnQL.TabIndex = 2;
            btnQL.Text = "    Quản lý ";
            btnQL.TextAlign = ContentAlignment.MiddleLeft;
            btnQL.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQL.UseVisualStyleBackColor = true;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Dock = DockStyle.Top;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTrangChu.ForeColor = Color.White;
            btnTrangChu.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnTrangChu.IconColor = Color.White;
            btnTrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTrangChu.IconSize = 40;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 125);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Padding = new Padding(10, 0, 0, 0);
            btnTrangChu.Size = new Size(236, 43);
            btnTrangChu.TabIndex = 1;
            btnTrangChu.Text = "    Trang chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 125);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 20F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 56);
            label2.Name = "label2";
            label2.Size = new Size(185, 46);
            label2.TabIndex = 2;
            label2.Text = "NHÂN SỰ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 10);
            label1.Name = "label1";
            label1.Size = new Size(183, 46);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ ";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Black", 20F);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.ImeMode = ImeMode.NoControl;
            guna2HtmlLabel1.Location = new Point(0, 10);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = null;
            // 
            // panelTileBar
            // 
            panelTileBar.Dock = DockStyle.Top;
            panelTileBar.Location = new Point(236, 0);
            panelTileBar.Name = "panelTileBar";
            panelTileBar.Size = new Size(941, 60);
            panelTileBar.TabIndex = 4;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(236, 60);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(941, 549);
            panelDesktop.TabIndex = 5;
            // 
            // QuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 609);
            Controls.Add(panelDesktop);
            Controls.Add(panelTileBar);
            Controls.Add(panelMenu);
            Name = "QuanLy";
            Text = "QuanLy";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnCaiDat;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnXemNV;
        private FontAwesome.Sharp.IconButton btnQL;
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Panel panelTileBar;
        private Panel panelDesktop;
    }
}