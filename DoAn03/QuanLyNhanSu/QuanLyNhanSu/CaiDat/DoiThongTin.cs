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

namespace QuanLyNhanSu.CaiDat
{
    public partial class DoiThongTin : UserControl
    {
        public static string ma = null;
        CauLenh cl = new CauLenh();
        SqlDataReader dr;
        public DoiThongTin()
        {
            InitializeComponent();
        }
        string mapb = null, macv = null, maluong = null, mahd = null, ten = null;
        string gt = null, hinh = null;
        private void DoiThongTin_Load(object sender, EventArgs e)
        {
            lbLoi.Text = null;
            if (string.IsNullOrWhiteSpace(ma))
            {
                lbLoi.Text = "Chưa có mã nhân viên (biến DoiThongTin.ma đang null).";
                return;
            }

            try
            {
                dr = cl.LayThongTinNV(ma);
                while (dr.Read())
                {
                    lbMaNV.Text = dr.GetString(0);
                    mapb = dr.GetString(1);
                    macv = dr.GetString(2);
                    maluong = dr.GetInt32(3).ToString();
                    mahd = dr.GetString(4);
                    txtTen.Text = dr.GetString(5);
                    gt = dr.GetString(6);
                    dtpNgaySinh.Text = dr.GetDateTime(7).ToString();
                    txtSoCM.Text = dr.GetString(8);
                    txtDT.Text = dr.GetString(9);
                    txtTrinhDo.Text = dr.GetString(10);
                    txtDiaChi.Text = dr.GetString(11);
                    txtEmail.Text = dr.GetString(12);
                    txtHonNhan.Text = dr.GetString(13);
                    hinh = dr.GetString(14);
                }

                if (gt == "Nam")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
            }
            catch (Exception ex)
            {
                // Không để exception làm form không hiển thị
                lbLoi.Text = ex.Message;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTen.Text))
            {
                if (!string.IsNullOrEmpty(txtSoCM.Text))
                {
                    if (!string.IsNullOrEmpty(txtDT.Text))
                    {
                        if (!string.IsNullOrEmpty(txtTrinhDo.Text))
                        {
                            if (!string.IsNullOrEmpty(txtDiaChi.Text))
                            {
                                if (!string.IsNullOrEmpty(txtEmail.Text))
                                {
                                    if (!string.IsNullOrEmpty(txtHonNhan.Text))
                                    {
                                        if (MessageBox.Show("Bạn muốn sửa?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                        {
                                            dr.Close();
                                            dr = cl.SuaNhanVien(ma, mapb, Convert.ToInt32(maluong), mahd, txtTen.Text, gt, Convert.ToDateTime(dtpNgaySinh.Text),
                                                txtSoCM.Text, txtDT.Text, txtTrinhDo.Text, txtDiaChi.Text, txtEmail.Text, txtHonNhan.Text, hinh);

                                            lbLoi.Text = "Đã Lưu!!";
                                            if (ten != txtTen.Text)
                                                if (MessageBox.Show("Khởi động lại phần mềm để cập nhật thông tin vừa thay đổi?", "Thông Báo",
                                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                                    Application.Restart();
                                        }

                                    }
                                    else
                                    {
                                        lbLoi.Text = "Lỗi!!";
                                        txtHonNhan.Focus();
                                    }
                                }
                                else
                                {
                                    lbLoi.Text = "Lỗi!!";
                                    txtEmail.Focus();
                                }
                            }
                            else
                            {
                                lbLoi.Text = "Lỗi!!";
                                txtDiaChi.Focus();
                            }
                        }
                        else
                        {
                            lbLoi.Text = "Lỗi!!";
                            txtTrinhDo.Focus();
                        }
                    }
                    else
                    {
                        lbLoi.Text = "Lỗi!!";
                        txtDT.Focus();
                    }
                }
                else
                {
                    lbLoi.Text = "Lỗi!!";
                    txtSoCM.Focus();
                }
            }
            else
            {
                lbLoi.Text = "Lỗi!!";
                txtTen.Focus();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSoCM_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSoCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
