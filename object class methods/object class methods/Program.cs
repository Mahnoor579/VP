using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_class_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Equals
            bool b = object.Equals("a", 'a'.ToString());
            Console.WriteLine(b);
            Console.ReadKey();
            //Reference Equals
            bool a = object.ReferenceEquals("a", 'a'.ToString());
            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
