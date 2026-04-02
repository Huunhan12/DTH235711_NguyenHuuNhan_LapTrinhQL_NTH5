using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.NhanVien
{
    public partial class ktNhanVien : UserControl
    {
        public ktNhanVien()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        tkCauLenh tkcl = new tkCauLenh();
        DataTable dt = new DataTable();

        private void label2_Click(object sender, EventArgs e)
        {
            txtH.Text = "VD: Tên nhân viên, quê quán, chức vụ, phòng ban....";
        }
        private void txtH_Click(object sender, EventArgs e)
        {
            txtH.Text = "";
        }
        private void txtH_TextChanged(object sender, EventArgs e)
        {

        }
        private void load()
        {
            dt.Clear();
            dt = cl.LayThongTinNV1("NV");
            dataGridView1.DataSource = dt;
        }

        private void ktNhanVien_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtH.Text))
            {
                if (txtH.Text.ToLower() == "all")
                    load();
                else
                {
                    int gt = 0;
                    if (radioButton1.Checked == true)
                        gt = 0;
                    if (radioButton2.Checked == true)
                        gt = 1;
                    if (radioButton3.Checked == true)
                        gt = 2;
                    dt.Clear();
                    dt = tkcl.tkNhanVien(txtH.Text, gt);
                    dataGridView1.DataSource = dt;
                }
            }
            else
                MessageBox.Show("Nhập nội dung cần tìm trước");
        }
    }
}
