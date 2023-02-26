using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibraryManagement
{
    public partial class Form_Stat : Form
    {
        public Form_Stat()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        private void fillChartTotal()
        {

            //AddXY value in chartStat in series named as Salary  
            chartTotal.Series["Revenue"].Points.AddXY("Kiểm Thử Phần Mềm", "10000");
            chartTotal.Series["Revenue"].Points.AddXY("Luyện Đọc Tiếng Anh", "8000");
            chartTotal.Series["Revenue"].Points.AddXY("Giáo trình Excel", "7000");
            chartTotal.Series["Revenue"].Points.AddXY("Triết Học Max-Lenin", "10000");
            chartTotal.Series["Revenue"].Points.AddXY("Cấu Trúc Dữ Liệu Và Giải Thuật", "8500");
            //chart title  
            chartTotal.Titles.Add("Salary Chart");
        }

        private void fillChartTop5Maxrent()
        {
            //chartMaxRent.BorderlineWidth= 2000;
            ////AddXY value in chartStat in series named as Salary  
            //chartMaxRent.Series["Count"].Points.AddXY("Kiểm Thử Phần Mềm", "4000");
            //chartMaxRent.Series["Count"].Points.AddXY("Luyện Đọc Tiếng Anh", "10000");
            //chartMaxRent.Series["Count"].Points.AddXY("Giáo trình Excel", "5000");
            //chartMaxRent.Series["Count"].Points.AddXY("Triết Học Max-Lenin", "7000");
            //chartMaxRent.Series["Count"].Points.AddXY("Cấu Trúc Dữ Liệu Và Giải Thuật", "8500");
            ////chart title  
            //chartTotal.Titles.Add("Salary Chart");

            for (int i = 1; i <= 12; i++)
            {
                chartMaxRent.Series["Count"].Points.AddXY(i.ToString(), Math.Abs(rand.Next(1000)));
            }
            chartMaxRent.Titles.Add("Total Of Year");
        }

        private void Form_Stat_Load(object sender, EventArgs e)
        {
            calStat.MaxDate = DateTime.Now;
            fillChartTotal();
            fillChartTop5Maxrent();
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
