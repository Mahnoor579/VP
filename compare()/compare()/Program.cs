using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare__
{
    class Program
    {
        static void Main(string[] args)
        {
           //compare
            string a = "Hello";
            string b = "world";
            int c = string.Compare(a, b);
            Console.WriteLine(c);

            c = string.CompareOrdinal(b, a);
            Console.WriteLine(c);

            c = a.CompareTo(b);
            Console.WriteLine(c);
            c = b.CompareTo(a);
            Console.WriteLine(c);
            Console.ReadKey();
            //concat
            string a = "hi";
            string b = "mahnoor";
           Console.WriteLine( string.Concat(a," ", b));
           Console.ReadKey();



        }
    }
}
