using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove__
{
    class Program
    {
        static void Main(string[] args)
        {


            //Remove
            //string str1 = "0123456";
            //string str2 = str1.Remove(6);
            //Console.WriteLine(str2);
            //Console.ReadKey();


            //substring
            string str1 = "One Two Three";
                string str2 = str1.Substring(4,3);
                Console.WriteLine("substring : {0}", str2);
                Console.ReadKey();


        }
    }
}
