using Library.DAO;
using Library.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BUS
{
    public class DocGiaBUS
    {
        public DocGiaBUS() { }
        public List<DocGia> LoadDocGia()
        {
            return new DocGiaDAO().LoadDocGia().ToList();
        }
    }
}
