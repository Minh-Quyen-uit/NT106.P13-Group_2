using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance {
            get  {if(instance == null) instance = new AccountDAO(); return instance; }
            private set => instance=value; 
        }
        private AccountDAO() { }

        public bool login(string username, string password) {

            // dang loi vi chuoi truyen qua tcp co ve chua on lam
            //username = "staff01";
            //password = "staff01123456@";
            //string query = " begin select * from dbo.UserAccount where UserName = N'" + username + "' and PassWord = N'" + password + "' end";
            string query = "select * from dbo.UserAccount where UserName = N'staff01' and PassWord = N'staff01123456@'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);



            return result.Rows.Count > 0;
        }
    }

}
