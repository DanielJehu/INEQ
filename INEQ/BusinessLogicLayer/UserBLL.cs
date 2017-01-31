#region librerias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
namespace BusinessLogicLayer
{
    public class UserBLL
    {
        public static string loguearse(string)
        {
            string strErr;

            if (string.IsNullOrEmpty(username) && 
            {

                return strErr "exiten datos vacios"
            }
            else
            {


            }
            bool isLogIn = DataAccessLayer.UserDAL.loguearse(username,password);

            if (isLogIn)
            {
                return strErr = "";

            }

            else
            {


            }

        }


    }
}
