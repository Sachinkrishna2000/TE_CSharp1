using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class Exception
    {
        public static void Main()
        {
            int[] a = { 10, 8, 6, 4, 8, 2, 3 };
            
            try
            {
                int b = Convert.ToInt32(Console.ReadLine());
                //If b value entered is some characters gives FormatException Error
                //If b value entered is some big number like 100000000 gives OverflowException error

                int div = a[1] / b;
                Console.WriteLine(div);
                //This statement will be executed if b!=0 else DivideByZero Exception

                Console.WriteLine(a[b]);
                //If b value entered is greater than array length then IndexOutOfrange Exception else this statement will be executed

                Console.WriteLine();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            //for (int i = 0; i < a.Length; i++)
            //{


            //}
        }
    }
}
