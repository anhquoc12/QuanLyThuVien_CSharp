using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DTO;
using Library.DAO;
using System.Data;

namespace Library.BUS
{
    public class SachBUS
    {
        public SachBUS() { }
        public List<Sach> LoadSach()
        {
            return new SachDAO().LoadSach().ToList();
        }
    }
}
