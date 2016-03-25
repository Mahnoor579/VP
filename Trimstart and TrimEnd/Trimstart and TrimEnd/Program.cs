using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimstart_and_TrimEnd
{
    class Program
    {
        static void Main(string[] args)
        {

            // TRIM END (SIMPLE)
            //string str1 = "hello!!@";
            //string str2 = str1.TrimEnd('!','@');
            //Console.WriteLine(str2);
            //Console.ReadKey();
            

            //TRIM END(ARRAYS)
           // string[] str1 = { "hi!!", "whats up?" };
           //foreach (string str2 in str1)
           //{
           //    string str3 = str2.TrimEnd('!', '?');
           //    Console.WriteLine(str3);
           //    Console.ReadKey();


               //TRIM START

            string str1 = "@@Hello";
            string str2 = str1.TrimStart('@');
            Console.WriteLine(str2);
            Console.ReadKey();


           }
        }
    }

