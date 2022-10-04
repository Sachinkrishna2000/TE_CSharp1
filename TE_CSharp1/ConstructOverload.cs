using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    public class add
    {
        public add(int x, int y)
        {
            Console.WriteLine($"The sum is {x + y}");
        }
        public add(float x, float y)
        {
            Console.WriteLine($"The sum is {x + y}");
        }
        public add(string x, string y)
        {
            Console.WriteLine($"The sum is {x + y}");
        }
    }
    internal class ConstructOverload
    {
        public static void Main()
        {
            add a = new add(1, 2);
            add b = new add(1.5f, 2.5f);
            add c = new add("John", "Smith");
        }
    }
}
