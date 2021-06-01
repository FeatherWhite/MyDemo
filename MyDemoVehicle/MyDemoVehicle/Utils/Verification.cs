using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyDemoVehicle.Utils
{
    public static class Verification
    {
        public static bool IsFloat(string str)
        {
            string regextext = @"^\d+\.\d+$";
            Regex regex = new Regex(regextext, RegexOptions.None);
            return regex.IsMatch(str);
        }
    }
}
