using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DTO;

namespace Library.DAO
{
    public class SachDAO
    {
        public SachDAO() { }
        public IQueryable<Sach> LoadSach()
        {
            //DataProvider dp = new DataProvider();
            //dp.Connect();
            //string sql = "SELECT * FROM Sach";
            //DataTable table = new DataTable();
            //table.Load(dp.ExecuteReader(sql));
            //dp.Disconnect();
            //return table;
            using(var db = new LibraryEntities())
            {
                var query = from s in db.Saches select s; return query;
            }

        }
    }
}
