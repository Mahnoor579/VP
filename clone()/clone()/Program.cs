using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clone__
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "I", "am", "mahnoor" };
            string[] cloned = array.Clone() as string[];
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(string.Join(" ", cloned));
            Console.WriteLine("-------------------------------------");
            Console.ReadKey();
            //for changing clones 2nd element
            cloned[2] = "student";
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(string.Join(" ", cloned));
            Console.ReadKey();

        }
    }
}
