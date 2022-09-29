using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class Student
    {
        public static void Main()
        {
            int sid;
            string sname, sdept;
            Student s = new Student();
            s.StudentDetails(out sid, out sname, out sdept);
            Console.WriteLine("The Student Details are:");
            Console.WriteLine($"Student ID: {sid}");
            Console.WriteLine($"Student Name: {sname}");
            Console.WriteLine($"Student Department: {sdept}");
        }
        public void StudentDetails(out int sid, out string sname, out string sdept)
        {
            Console.WriteLine("Enter The Student Details");
            Console.WriteLine("Enter the Student ID");
            sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Name");
            sname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Student Department");
            sdept = Convert.ToString(Console.ReadLine());
        }
    }
}
