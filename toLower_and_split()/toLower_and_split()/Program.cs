using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toLower_and_split__
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = "I am doing SOFTWARE engineering from BAHRIA University Islamabad";
            //    string str2 = str1.ToLower();
            //Console.WriteLine("{0}", str2);
            //Console.ReadKey();

            //split
            string str1 = "i am mahnoor";
            string[] str2 = str1.Split(' ');
            foreach (string word in str2)

            {

                Console.WriteLine(word);
                Console.ReadKey();

            }
        }
    }
}
