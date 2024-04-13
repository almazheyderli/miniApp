using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public static class Helper
    {
        public static bool CorrectName(this string name)
        {
            return name.Length >= 3 && char.IsUpper(name[0]);
        }
        public static bool CorrectSurname(this string surname)
        {
            return surname.Length >= 3 && char.IsUpper(surname[0]);
        }

        public static bool CorrectClassName(this string className)
        {

            return char.IsUpper(className[0]) && char.IsUpper(className[1]) &&
                   char.IsDigit(className[2]) && char.IsDigit(className[3]) && char.IsDigit(className[4]) && className.Length == 5;
        }
    }
}
