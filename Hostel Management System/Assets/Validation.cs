using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Controllers
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

        public static bool AreAnyTextBoxEmpty(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
