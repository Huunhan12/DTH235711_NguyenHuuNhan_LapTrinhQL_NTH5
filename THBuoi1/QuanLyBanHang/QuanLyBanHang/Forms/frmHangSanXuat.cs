using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.Forms
{
    public partial class frmHangSanXuat : Form
    {
        QLBHDbContext context = new QLBHDbContext();     // CSDL
        bool xuLyThem = false;                           // kiểm tra Thêm hay Sửa
        int id;                                         // mã hãng sản xuất
        public frmHangSanXuat()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenHangSanXuat.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<HangSanXuat> hsx = context.HangSanXuat.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = hsx;

            txtTenHangSanXuat.DataBindings.Clear();
            txtTenHangSanXuat.DataBindings.Add(
                "Text",
                bindingSource,
                "TenHangSanXuat",
                false,
                DataSourceUpdateMode.Never
            );

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenHangSanXuat.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(
                dataGridView.CurrentRow.Cells["ID"].Value.ToString()
            );
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Xác nhận xóa hãng sản xuất?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(
                    dataGridView.CurrentRow.Cells["ID"].Value.ToString()
                );

                HangSanXuat hsx = context.HangSanXuat.Find(id);
                if (hsx != null)
                {
                    context.HangSanXuat.Remove(hsx);
                    context.SaveChanges();
                }

                frmHangSanXuat_Load(sender, e);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHangSanXuat.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên hãng sản xuất!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (xuLyThem)
            {
                HangSanXuat hsx = new HangSanXuat();
                hsx.TenHangSanXuat = txtTenHangSanXuat.Text;

                context.HangSanXuat.Add(hsx);
                context.SaveChanges();
            }
            else
            {
                HangSanXuat hsx = context.HangSanXuat.Find(id);
                if (hsx != null)
                {
                    hsx.TenHangSanXuat = txtTenHangSanXuat.Text;
                    context.HangSanXuat.Update(hsx);
                    context.SaveChanges();
                }
            }

            frmHangSanXuat_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
