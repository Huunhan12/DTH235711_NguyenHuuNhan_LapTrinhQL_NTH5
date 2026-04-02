using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.ThongKe
{
    public partial class abc : UserControl
    {
        public abc()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt1 = new DataTable();
        private void abc_Load(object sender, EventArgs e)
        {
            layTenNhanVien();
        }
        private void layTenNhanVien()
        {
            dt1.Clear();
            dt1 = cl.pcLayNhanVien("0");
            cbTen.DataSource = dt1;
            cbTen.DisplayMember = "TenNV";
            cbTen.ValueMember = "MaNhanVien";
        }

        private void cbTen_SelectedIndexChanged(object sender, EventArgs e)
        {

            QuanLy.UserControl1.manv = cbTen.SelectedValue.ToString();
        }
    }
    }

