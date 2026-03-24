using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.CaiDat
{
    public partial class CaiDat : Form
    {
        public CaiDat()
        {
            InitializeComponent();

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            pnLoad.Controls.Clear();
            dmk.Dock = DockStyle.Fill;
            pnLoad.Controls.Add(dmk);
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            DoiThongTin dt = new DoiThongTin();
            pnLoad.Controls.Clear();
            dt.Dock = DockStyle.Fill;
            pnLoad.Controls.Add(dt);
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan tt = new TaoTaiKhoan();
            pnLoad.Controls.Clear();
            tt.Dock = DockStyle.Fill;
            pnLoad.Controls.Add(tt);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Chu Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Chu Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Restart();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.Show();
            this.Hide();
        }
    }
}
