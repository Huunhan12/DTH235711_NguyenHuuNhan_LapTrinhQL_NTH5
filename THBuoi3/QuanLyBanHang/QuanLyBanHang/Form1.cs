using QuanLyBanHang.Forms;

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.Show();
            this.Hide();
        }
    }
}
