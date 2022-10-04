using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    public class Details
    {
        
        public int emp_id = 1001;
        public string emp_name = "John";

        internal int emp_id1 = 1002;
        internal string emp_name1 = "Sam";
        

        public void display_public()
        {
            Console.WriteLine("This is Employee Details From Public Method");
            Console.WriteLine($"The Employee ID is: {emp_id} and Employee Name is : {emp_name}");
        }

        internal void display_internal()
        {
            Console.WriteLine("This is Employee Details From Internal Method");
            Console.WriteLine($"The Employee ID is: {emp_id1} and Employee Name is : {emp_name1}");
        }
    }
    internal class PublicInt
    {
        public static void Main()
        {
            Details det = new Details();
            det.display_public();
            Console.WriteLine();
            det.display_internal();
        }
    }
}
