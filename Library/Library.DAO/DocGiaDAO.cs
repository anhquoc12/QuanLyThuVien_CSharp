using Library.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAO
{
    public class DocGiaDAO
    {
        public DocGiaDAO() { }
        public IQueryable<DocGia> LoadDocGia()
        {
            //DataProvider dp = new DataProvider();
            //dp.Connect();
            //string sql = "SELECT * FROM DocGia";
            //DataTable table = new DataTable();
            //table.Load(dp.ExecuteReader(sql));
            //dp.Disconnect();
            //return table;

            using (var db = new LibraryEntities())
            {
                var query = from s in db.DocGias select s; 
                return query;
            }
        }
    }
}
