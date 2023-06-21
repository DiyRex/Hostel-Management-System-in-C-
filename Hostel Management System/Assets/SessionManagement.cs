using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Controllers
{
    internal class SessionManagement
    {
        private static string LoggedUser;

        public static void setUserSession(string username)
        {
            LoggedUser = username;
        }

        public static string getUserSession()
        {
            return LoggedUser;
        }

        public static void clearUserSession()
        {
            LoggedUser = null;
        }
    }
}
