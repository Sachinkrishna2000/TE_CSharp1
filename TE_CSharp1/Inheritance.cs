using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    public class Bonus
    {
        protected int bonus = 1000;

        protected void display()
        {
            Console.WriteLine($"The Bonus is {bonus}");
        }
    }
    public class Staff : Bonus
    {
        protected int sal;
        public Staff(int sal)
        {
            this.sal = sal;
            
        }
        public void displaystaff()
        {
            bonus = 3 * bonus;
            display();
            Console.WriteLine($"The Staff Salary is {this.sal + bonus}");
        }
        
    }
    public class NonStaff : Bonus
    {
        protected int sal;
        public NonStaff(int sal)
        {
            this.sal = sal;

        }
        public void displaynonstaff()
        {
            bonus = 2 * bonus;
            display();
            Console.WriteLine($"The Non-Staff Salary is {this.sal + bonus}");
        }

    }
    internal class Inheritance
    {
        public static void Main()
        {
            Staff s = new Staff(30000);
            s.displaystaff();
            NonStaff ns = new NonStaff(10000);
            ns.displaynonstaff();
        }
    }
}
