using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.TK
{
    public partial class tkSoNgayDiLam : UserControl
    {
        public tkSoNgayDiLam()
        {
            InitializeComponent();
        }
        tkCauLenh tkcl = new tkCauLenh();
        DataTable dt = new DataTable();
        int thang = DateTime.Now.Month, nam = DateTime.Now.Year, ngay = DateTime.Now.Day;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tkSoNgayDiLam_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            btXem.Enabled = false;
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaydau = Convert.ToDateTime(Convert.ToInt32(cbThang.Text) + "/" + "01/" + Convert.ToInt32(cbNam.Text) + " ");
                DateTime ngaycuoi = Convert.ToDateTime(Convert.ToInt32(cbThang.Text) + "/" + "29/" + Convert.ToInt32(cbNam.Text) + " ");
                dt.Clear();
                dt = tkcl.tkSoNgayDiLamCuaNhanVien(ngaydau, ngaycuoi, 1);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            btXem.Enabled = true;
        }
    }
}
