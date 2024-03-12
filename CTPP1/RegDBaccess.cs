using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CTPP1
{
    internal class RegDBaccess
    {
       

        public static void SavePerson(RegistrationModel person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Registration (FirstName, LastName, Email, Signature, UserName) values (@FirstName, @LastName, @Email, @Signature, @UserName)", person );
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
