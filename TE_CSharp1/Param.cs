using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class Param
    {
       public static void Main()
        {
            Param p = new Param();
            p.Multiplication(1, 2, 3, 4, 5);
        }
        public void Multiplication(params int[] numbers)
        {
            int i,j,mul;
            for(i = 1; i <= numbers.Length; i++)
            {
                for(j = 1; j <= 10; j++)
                {
                    mul = i * j;
                    Console.WriteLine($"{i}x{j}={mul}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
