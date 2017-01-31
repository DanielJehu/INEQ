using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserDAL
    {
        // select * from user WHERRE Username = '' AND pasword

        static string CONNECTIONSTRING = "Data Source=WENDY-PC\DANIEL;Initial Catalog = Ineq; Integrated Security = True";

        public static bool loguearse(string username, string password)
        {

            

            SqlConnection conn = new SqlConnection(CONNECTIONSTRING);

            string query = "SELECT * FROM User WHERE"

            Sqlcommand cmd = new Sqlcommand(query)

                cmd
        }

    }
}
