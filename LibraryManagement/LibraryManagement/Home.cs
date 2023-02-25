﻿using System;
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
    public partial class Home : Form
    {
        public Home()
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

        private void menuMuon_Tra_Click(object sender, EventArgs e)
        {
            form_QLMuonTra f = new form_QLMuonTra();
            f.Show();
        }

        private void menuStat_Click(object sender, EventArgs e)
        {
            Form_Stat f = new Form_Stat();
            f.Show();
        }

        //    private void menuDanhMuc_Click(object sender, EventArgs e)
        //    {

        //    }
    }
}