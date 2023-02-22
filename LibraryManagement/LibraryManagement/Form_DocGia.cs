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
            txtId.Text = "";
            //txtId.Enabled = false;
            txtName.Text = "";
            //txtName.Enabled = false;
            txtDate.Text = DateTime.Now.ToString();
            //txtDate.Enabled = false;
            selGT.Text = "";
            //selGT.Enabled = false;
            txtAddress.Text = "";
            //txtAddress.Enabled = false;
            txtSDT.Text = "";
            //txtSDT.Enabled = false;
            txtKhoa.Text = "";
            //txtKhoa.Enabled = false;
            txtEmail.Text = "";
            //txtEmail.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = true;
            txtDate.Enabled= true;
            selGT.Enabled = true;
            txtAddress.Enabled = true;
            txtSDT.Enabled = true;
            txtKhoa.Enabled = true;
            txtEmail.Enabled = true;
            btnCancle.Enabled = true;
             btnSave.Enabled = true;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            //txtId.Enabled = false;
            txtName.Text = "";
            //txtName.Enabled = false;
            txtDate.Text = DateTime.Now.ToString();
            //txtDate.Enabled = false;
            selGT.Text = "";
            //selGT.Enabled = false;
            txtAddress.Text = "";
            //txtAddress.Enabled = false;
            txtSDT.Text = "";
            //txtSDT.Enabled = false;
            txtKhoa.Text = "";
            //txtKhoa.Enabled = false;
            txtEmail.Text = "";
            //txtEmail.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || selGT.Text == ""
                 || txtSDT.Text == "" || txtEmail.Text == ""
                || txtKhoa.Text == "" || txtAddress.Text == "")
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Không Thể Lưu",
                    buttons: MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Thông tin đã Lưu", "Lưu Thành Công",
                    buttons: MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }
    }
}
