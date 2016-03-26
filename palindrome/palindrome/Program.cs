using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "madam";
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            string str2 = new string(ch);
            if (str.Equals(str2))
            {
                Console.WriteLine("palindrome");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("not palindrome");
                Console.ReadKey();
            }

        }
    }
}
