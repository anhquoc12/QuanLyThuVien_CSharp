using Library.BUS;
using Library.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTCSDL_QLThưViện
{
    public partial class Form_QuanLySach : Form
    {
        public Form_QuanLySach()
        {
            InitializeComponent();
        }


        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txtGia.Text == "" || txtLoaiSach.Text == ""
                || txtMaSach.Text == "" || txtTenSach.Text == ""
                || comTacGia.Text == "" || comNhaCungCap.Text == ""
                || txtNamXuatBan.Text == "" || txtSoLuong.Text == "")
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
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;

            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            comTacGia.Enabled = false;
            comNhaCungCap.Enabled = false;
            txtLoaiSach.Enabled = false;
            txtNamXuatBan.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGia.Enabled = false;

            txtMaSach.Text = "";
            txtTenSach.Text = "";
            comTacGia.Text = "";
            comNhaCungCap.Text = "";
            txtLoaiSach.Text = "";
            txtNamXuatBan.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            txtMaSach.Enabled = true;
            txtTenSach.Enabled = true;
            comTacGia.Enabled = true;
            comNhaCungCap.Enabled = true;
            txtLoaiSach.Enabled = true;
            txtNamXuatBan.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGia.Enabled = true;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;

            txtMaSach.Text = "";
            txtTenSach.Text = "";
            comTacGia.Text = "";
            comNhaCungCap.Text = "";
            txtLoaiSach.Text = "";
            txtNamXuatBan.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form_QuanLySach_Load(object sender, EventArgs e)
        {
            //DataTable dt = new SachBUS().LoadSach();
            //dataSach.DataSource = dt;
            dataSach.DataSource = new SachBUS().LoadSach();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdMaSach.Checked) 
            {
            
            }
        }
    }
}
