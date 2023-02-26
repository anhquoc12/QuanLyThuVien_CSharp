using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    internal class Utils
    {

        public static int GetDaysInMonth(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 30;
                case 2:
                    if (year % 4 == 0 && year % 100 != 0)
                        return 29;
                    else
                        return 28;
                default: 
                    return 31;
            }
        }
    }
}
