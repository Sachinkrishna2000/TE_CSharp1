using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class Employee
    {
        public static void Main()
        {
            int emp_id;
            string emp_name;
            int emp_sal;
            Console.WriteLine("This is Main Method");
            Employeedetails(out emp_id, out emp_name, out emp_sal);
            Employee s = new Employee();
            s.Displaydetails(emp_id, emp_name, emp_sal);
        }
        public static void Employeedetails(out int emp_id, out string emp_name, out int emp_sal)
        {
            Console.WriteLine("Enter the Employee Id");
            emp_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            emp_name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Employee Salary");
            emp_sal = Convert.ToInt32(Console.ReadLine());

        }
        public void Displaydetails(int emp_id, string emp_name, int emp_sal)
        {
            Console.WriteLine("The Employee Details are:");
            Console.WriteLine($"Employee ID:{emp_id}");
           
            Console.WriteLine($"Employee Name:{emp_name}");
            
            Console.WriteLine($"Employee Salary:{emp_sal}");
        }
    }
}
