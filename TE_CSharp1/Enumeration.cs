using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class Enumeration
    {
        enum Concepts
        {
            Cricket,
            Test_Match,
            Runs = 170,
            Wickets = 6,
            Extras = 15,
            Penalty = -3,
            Second_Day,
            Sunny_Day
        }
        public static void Main()
        {
            Console.WriteLine(Concepts.Cricket);
            Console.WriteLine(Concepts.Test_Match);

            Console.WriteLine(Concepts.Runs);
            int runs = (int)Concepts.Runs;
            Console.WriteLine(runs);

            var wick = (Concepts)6;
            Console.WriteLine(wick);
            int wicket = (int)Concepts.Wickets;
            Console.WriteLine(wicket);

            var extra = (Concepts)15;
            Console.WriteLine(extra);
            int ext = (int)Concepts.Extras;
            Console.WriteLine(ext);

            Console.WriteLine(Concepts.Penalty);
            int pen = (int)Concepts.Penalty;
            Console.WriteLine(pen);

            Console.WriteLine(Concepts.Second_Day);
            Console.WriteLine(Concepts.Sunny_Day);
            

        }


    }
}
