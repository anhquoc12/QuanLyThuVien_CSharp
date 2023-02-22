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
    public partial class Form_QLSV : Form
    {
        public Form_QLSV()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuQLDG_Click(object sender, EventArgs e)
        {
            Form_DocGia f = new Form_DocGia();
            f.Show();
        }

        //    private void menuDanhMuc_Click(object sender, EventArgs e)
        //    {

        //    }
    }
}
