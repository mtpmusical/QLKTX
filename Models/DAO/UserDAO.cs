using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;

namespace Models.DAO
{
    public class UserDAO
    {
        private DBKTX db;

        public UserDAO()
        {
            db = new DBKTX();
        }
        public int login(string user, string pass)
        {
            var result = db.NGUOIDUNGs.SingleOrDefault(x => x.TenDangNhap.Contains(user) && x.MatKhau.Contains(pass));
            if (result == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public List<NGUOIDUNG> ListAll()
        {
            return db.NGUOIDUNGs.ToList();
        }
    }


  
}
