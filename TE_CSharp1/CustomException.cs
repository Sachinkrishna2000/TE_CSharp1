using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    public class AgeException : ApplicationException
    {
        //Constructor 
        public AgeException(string message) : base(message)
        {

        }
    }
    internal class CustomException
    {
        public static void Main()
        {
            try
            {
                int age;
                Console.WriteLine("Enter the Age Of the Student");
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 22)
                {
                    throw (new AgeException("Sorry!!! The Student is Not Eligible For The Trainee Engineer Role"));

                }
                else
                {
                    Console.WriteLine("Congrats!!! The Student is eligible for the role Trainee Engineer");
                }
            }
            catch(AgeException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
