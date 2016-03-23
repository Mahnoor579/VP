using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_and_trim
{
    class Program
    {
        static void Main(string[] args)
        {
           //TRIM
            string str1 = "Hello world";
            string str2 = "Mahnoor Ahmed";
            //str1.Trim();
            //Console.WriteLine(str1);
            //Console.ReadKey();
            //replace
            str1 = str1.Replace(" ", string.Empty);
            Console.WriteLine(str1);
            Console.ReadKey();

        }
       
        
        
    }
}
