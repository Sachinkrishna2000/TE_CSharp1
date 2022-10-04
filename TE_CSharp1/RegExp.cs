using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class RegExp
    {
        public static void Main()
        {
            string mobile;
            Console.WriteLine("Enter the 10 digit Mobile No.");
            mobile = Convert.ToString(Console.ReadLine());
            var validate_mobile = Regex.IsMatch(mobile, @"^([7-9]{1})([0-9]{9})$");
            Console.WriteLine(validate_mobile);
        }
    }
}
