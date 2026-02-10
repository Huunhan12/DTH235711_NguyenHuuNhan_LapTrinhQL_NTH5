namespace QuanLyBanHang.Reports
{
    partial class FrmThongKeSanPham
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            cboHangSanXuat = new ComboBox();
            panel1 = new Panel();
            btnLocKetQua = new Button();
            label2 = new Label();
            label1 = new Label();
            cboLoaiSanPham = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(155, 38);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(212, 28);
            cboHangSanXuat.TabIndex = 0;
            cboHangSanXuat.SelectedIndexChanged += cboHangSanXuat_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboLoaiSanPham);
            panel1.Controls.Add(cboHangSanXuat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 110);
            panel1.TabIndex = 1;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocKetQua.Location = new Point(762, 33);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(183, 33);
            btnLocKetQua.TabIndex = 4;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(418, 43);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 3;
            label2.Text = "Loại sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 43);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 2;
            label1.Text = "Hãng sản xuất: ";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(573, 38);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(151, 28);
            cboLoaiSanPham.TabIndex = 1;
            // 
            // FrmThongKeSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 592);
            Controls.Add(panel1);
            Name = "FrmThongKeSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Sản Phẩm";
            Load += FrmThongKeSanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComboBox cboHangSanXuat;
        private Panel panel1;
        private Label label1;
        private ComboBox cboLoaiSanPham;
        private Button btnLocKetQua;
        private Label label2;
    }
}