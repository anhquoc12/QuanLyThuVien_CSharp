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
    public partial class Form_Stat : Form
    {
        public Form_Stat()
        {
            InitializeComponent();
        }

        private void Form_Stat_Load(object sender, EventArgs e)
        {
            calStat.MaxDate = DateTime.Now;
        }

        private void rdDays_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDays.Checked == true)
            {
                numDays.Enabled= true;
            }
            else
            {
                numDays.Enabled= false;
            }
        }
    }
}
