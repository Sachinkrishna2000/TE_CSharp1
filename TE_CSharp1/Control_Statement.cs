using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class Control_Statement
    {
        public static void Main()
        {
            Control_Statement s = new Control_Statement();
            Condition();
            s.Loops();
        }

        public static void Condition()
        {
            int a, b, c;
            Console.WriteLine("If Else Condition Static Method to Calculate Greatest Of 3 No.s");
            Console.WriteLine("Enter the First Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            c = Convert.ToInt32(Console.ReadLine());

            if(a > b && a > c)
            {
                Console.WriteLine($"First Number {a} is Greatest");
            }
            else if (b > c)
            {
                Console.WriteLine($"Second Number {b} is Greatest");
            }
            else
            {
                Console.WriteLine($"Third Number {c} is Greatest");
            }
           
        }

        public void Loops()
        {
            int size, i;
            
            Console.WriteLine("Looping Concept in Instance Method to Print an Array");
            Console.WriteLine("Enter the size of the Array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for(i=0; i < size; i++)
            {
                Console.WriteLine($"Enter the {i+1}Th Element Of The Array");
                arr[i] = Convert.ToInt32(Console.ReadLine()); ;
            }
            Console.WriteLine("The Array is :");
            for(i=0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
