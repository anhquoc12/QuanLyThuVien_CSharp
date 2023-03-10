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
        String format_date = "MM/yyyy";
        Random rand = new Random();
        private void fillChartTotal()
        {

            //AddXY value in chartStat in series named as Salary  
            chartStat.Series["Revenue"].Points.AddXY("Kiểm Thử Phần Mềm", "10000");
            chartStat.Series["Revenue"].Points.AddXY("Luyện Đọc Tiếng Anh", "8000");
            chartStat.Series["Revenue"].Points.AddXY("Giáo trình Excel", "7000");
            chartStat.Series["Revenue"].Points.AddXY("Triết Học Max-Lenin", "10000");
            chartStat.Series["Revenue"].Points.AddXY("Cấu Trúc Dữ Liệu Và Giải Thuật", "8500");
            //chart title  
            chartStat.Titles.Add("Salary Chart");
        }

        private void Form_Stat_Load(object sender, EventArgs e)
        {
            fillChartTotal();
            
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
