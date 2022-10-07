using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class DictHash
    {
        public static void Display_Dictionary()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Sam");
            d.Add(2, "David");
            d.Add(3, "John");
            Console.WriteLine("DICTIONARY");
            foreach (var obj in d)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            var key = new List<int>(d.Keys);
            foreach (var obj in key)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            var values = new List<string>(d.Values);
            foreach (var obj in values)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Key: {d[1]}");
            //Console.WriteLine($"Key: {vs[0]}");//If the key is not found -> raise an exception

        }
        /// <summary>
        /// Hashtable -> class -> using System.Collections;
        /// not type specific
        /// key-value pair
        /// </summary>

        public static void Display_Hashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Rob");
            ht.Add(2, 123);
            ht.Add(3, "Charlie");
            ht.Add(4, 1234);
            ht.Add(5, "Alex");
            ht.Add(6, 123456);
            Console.WriteLine("HASHTABLE");
            Console.WriteLine("-----------------------------------------");
            //ICollection Interface
            ICollection key = ht.Keys;
            foreach (var obj in key)
            {
                Console.WriteLine(ht[obj]);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Key: {ht[1]}");
            Console.WriteLine($"Key: {ht[2]}");//If the key is not found -> null value
        }

        public static void Main()
        {
           
            Display_Dictionary();
            Console.WriteLine("-----------------------------------------");
            Display_Hashtable();
        }
    }
}
