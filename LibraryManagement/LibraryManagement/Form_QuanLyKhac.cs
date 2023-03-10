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
    public partial class Form_QuanLyKhac : Form
    {
        public Form_QuanLyKhac()
        {
            InitializeComponent();
        }

        private void init(int x)
        {
            if (x == 1)
            {
                txtMaTacGia.Text = "";
                txtTenTacGia.Text = "";
                txtSDT_TacGia.Text = "";
                txtEmail_TacGia.Text = "";
            }
            else
            {
                txtMaNCC.Text = "";
                txtTenNCC.Text = "";
                txtSDT_NCC.Text = "";
                txtEmail_NCC.Text = "";
            }
            
        }

        private void reset(int x)
        {
            
            if (x == 1)
            {
                btnCancle_TacGia.Enabled = false;
                btnSave_TacGia.Enabled = false;
                btnAdd_TacGia.Enabled = true;
                btnEdit_TacGia.Enabled = false;
                btnDelete_TacGia.Enabled = false;
                txtMaTacGia.Enabled = false;
                txtTenTacGia.Enabled = false;
                txtEmail_TacGia.Enabled = false;
                txtSDT_TacGia.Enabled = false;
            }
            else
            {
                btnCancle_NCC.Enabled = false;
                btnSave_NCC.Enabled = false;
                btnAdd_NCC.Enabled = true;
                btnEdit_NCC.Enabled = false;
                btnDelete_NCC.Enabled = false;
                txtMaNCC.Enabled = false;
                txtTenNCC.Enabled = false;
                txtEmail_NCC.Enabled = false;
                txtSDT_NCC.Enabled = false;
            }
        }

        private void btnAdd_TG_Click(object sender, EventArgs e)
        {
            txtMaTacGia.Enabled = true;
            txtTenTacGia.Enabled = true;
            txtSDT_TacGia.Enabled = true;
            txtEmail_TacGia.Enabled = true;
            btnCancle_TG.Enabled = true;
            btnSave_TG.Enabled = true;
            btnAdd_TG.Enabled = false;
        }

        private void btnSave_TG_Click(object sender, EventArgs e)
        {
            if (txtMaTacGia.Text == "" || txtTenTacGia.Text == "")
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
            init(1);
            reset(1);
        }

        private void btnCancle_TG_Click(object sender, EventArgs e)
        {
            init(1);
        }

        private void btnAdd_NCC_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtSDT_NCC.Enabled = true;
            txtEmail_NCC.Enabled = true;
            btnCancle_NCC.Enabled = true;
            btnSave_NCC.Enabled = true;
            btnAdd_NCC.Enabled = false;
        }

        private void btnSave_NCC_Click(object sender, EventArgs e)
        {
            if (txtMaTacGia.Text == "" || txtTenTacGia.Text == "")
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
            init(2);
        }

        private void btnCancle_NCC_Click(object sender, EventArgs e)
        {
            init(2);
        }

        private void txtSDT_TacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_NCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_NCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
