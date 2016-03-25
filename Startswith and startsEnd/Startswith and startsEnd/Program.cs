using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startswith_and_startsEnd
{
    class Program
    {
        static void Main(string[] args)
        {
             string str1 = "mahnoor";
            if (str1.StartsWith("m"))
            {
                Console.WriteLine("True");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("false");
                Console.ReadKey();
            }

            if (str1.EndsWith("r")) 
            {
                Console.WriteLine("True");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("True");
                Console.ReadKey();
            }
          
           
        }
    }
}
