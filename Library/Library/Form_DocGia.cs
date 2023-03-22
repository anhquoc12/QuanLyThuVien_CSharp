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
    public partial class Form_DocGia : Form
    {
        public Form_DocGia()
        {
            InitializeComponent();
        }
        private void init()
        {
            txtMaDocGia.Text = "";
            txtTenDocGia.Text = "";
            txtBirthDay.Text = DateTime.Now.ToString();
            txtSDT.Text = "";
        }
        
        private void reset()
        {
            btnCancle.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtMaDocGia.Enabled = false;
            txtTenDocGia.Enabled = false;
            txtBirthDay.Enabled = false;
            txtSDT.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaDocGia.Enabled = true;
            txtTenDocGia.Enabled = true;
            txtBirthDay.Enabled= true;
            txtSDT.Enabled = true;
            btnCancle.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text == "" || txtTenDocGia.Text == "" || txtSDT.Text == "")
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
            init();
            reset();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
