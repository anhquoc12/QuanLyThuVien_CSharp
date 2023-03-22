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
//using System.Windows.Forms.DataVisualization.Charting;

namespace LibraryManagement
{
    public partial class Form_Stat : Form
    {
        public Form_Stat()
        {
            InitializeComponent();
        }
        private void fillChartColumn()
        {

            //AddXY value in chstat in series named as Salary  
            chColumn.Series["Revenue"].Points.AddXY("Kiểm Thử Phần Mềm", "10000");
            chColumn.Series["Revenue"].Points.AddXY("Luyện Đọc Tiếng Anh", "8000");
            chColumn.Series["Revenue"].Points.AddXY("Giáo trình Excel", "7000");
            chColumn.Series["Revenue"].Points.AddXY("Triết Học Max-Lenin", "10000");
            chColumn.Series["Revenue"].Points.AddXY("Cấu Trúc Dữ Liệu Và Giải Thuật", "8500");
            //chart title  
            chColumn.Titles.Add("Salary Chart");
            chColumn.Series["Revenue"].Color = Color.LightBlue;
        }

        private void Form_Stat_Load(object sender, EventArgs e)
        {
            fillChartColumn();
        }
    }
}
