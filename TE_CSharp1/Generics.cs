using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class Generics
    {
        // Declare Generic Delegate
        public delegate T AreaDelegate<T>(T a);
        public class Area
        {
            public int AreaSquare(int a)
            {
                return a * a;
            }
            public int AreaCube(int x)
            {
                return 6 * x * x;
            }
            public int AreaCircle(int r)
            {
                int b = Convert.ToInt32(Math.PI);
                return b * r * r;
            }
            public double AreaSquare(double a)
            {
                return a * a;
            }
            public double AreaCube(double x)
            {
                return 6 * x * x;
            }
            public double AreaCircle(double r)
            {
                //int b = Convert.ToInt32(Math.PI);
                return Math.PI * r * r;
            }
        }
        class Result
        {
            public static void Main(string[] args)
            {
                Area ar = new Area();
                Console.WriteLine("The Results Of Generic Delegates are-");
                
                // Instantiate delegate with AreaSquare method using int
                AreaDelegate<int> dlgt = new AreaDelegate<int>(ar.AreaSquare);
                Console.WriteLine("Area Of Square in int: " + dlgt(10));
                // Instantiate delegate with AreaCube method
                dlgt = ar.AreaCube;
                Console.WriteLine("Area Of Cube in int: " + dlgt(10));

                // Instantiate delegate with AreaCircle method
                dlgt = ar.AreaCircle;
                Console.WriteLine("Area Of Circle in int: " + dlgt(10));

                // Instantiate delegate with AreaSquare method using double
                AreaDelegate<double> dlgt1 = new AreaDelegate<double>(ar.AreaSquare);
                Console.WriteLine("Area Of Square in double: " + dlgt1(10.5));

                // Instantiate delegate with AreaCube method using double
                dlgt1 = ar.AreaCube;
                Console.WriteLine("Area Of Cube in double: " + dlgt1(10.5));

                // Instantiate delegate with AreaCircle method using double
                dlgt1 = ar.AreaCircle;
                Console.WriteLine("Area Of Circle in double: " + dlgt1(10.5));

                
            }
        }
    }
}
