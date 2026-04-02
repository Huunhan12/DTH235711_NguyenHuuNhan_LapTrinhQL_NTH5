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
    public partial class tkXemccTheoTen : UserControl
    {
        public tkXemccTheoTen()
        {
            InitializeComponent();
        }
        tkCauLenh tkcl = new tkCauLenh();
        DataTable dt = new DataTable();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            btXem.Enabled = true;
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaydau = Convert.ToDateTime(Convert.ToInt32(cbThang.Text) + "/" + "01/" + Convert.ToInt32(cbNam.Text) + " ");
                DateTime ngaycuoi = Convert.ToDateTime(Convert.ToInt32(cbThang.Text) + "/" + "29/" + Convert.ToInt32(cbNam.Text) + " ");
                dt.Clear();
                dt = tkcl.tkccXemTheoTenVaPhongBan(txtTen.Text, "abc", ngaydau, ngaycuoi, 1);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void load()
        {
            btXem.Enabled = false;
        }

        private void tkXemccTheoTen_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
