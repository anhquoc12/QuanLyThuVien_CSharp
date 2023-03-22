using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class form_QLMuonTra : Form
    {
        public form_QLMuonTra()
        {
            InitializeComponent();
            dateNgayMuon.MinDate= DateTime.Now;
        }

        private void btnTaoPhieuMuon_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnCancle.Enabled = true;
            btnTaoPhieuMuon.Enabled = false;

            txtMaDocGia.Enabled = true;
            txtTienSach.Enabled= true;
            comTenSach.Enabled= true;
            dateNgayMuon.Enabled= true;;
            numSoLuongMuon.Enabled= true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text == "" || comTenSach.Text == "" || txtTienSach.Text == "" || numSoLuongMuon.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Không Thể Lưu",
                    buttons: MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Thông tin đã Lưu", "Lưu Thành Công",
                    buttons: MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }

            btnLuu.Enabled = false;
            btnCancle.Enabled = false;
            btnTaoPhieuMuon.Enabled = true;

            txtMaDocGia.Enabled = false;
            txtMaDocGia.Text = "";
            txtTienSach.Enabled = false;
            txtTienSach.Text = "";
            comTenSach.Enabled = false;
            comTenSach.Text = "";
            dateNgayMuon.Enabled = false;
            dateNgayMuon.Text = "";
            numSoLuongMuon.Enabled = false;
            numSoLuongMuon.Text = "";
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtMaDocGia.Text = "";
            txtTienSach.Text = "";
            comTenSach.Text = "";
            dateNgayMuon.Text = "";
            numSoLuongMuon.Text = "";

        }

        private void txtTienSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
