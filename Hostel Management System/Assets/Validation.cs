using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Assets
{
    internal class Validation
    {
        public static bool isMatchingPassword(string Password, string confirmPassword)
        {
            if (Password == confirmPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AreAnyStringsEmpty(params string[] strings)
        {
            foreach (string str in strings)
            {
                if (string.IsNullOrWhiteSpace(str))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
