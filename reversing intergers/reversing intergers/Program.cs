using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversing_intergers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, reverse = 0, remainder = 0;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;

            }
            Console.WriteLine("The reverse number is : {0}", reverse);
            Console.ReadLine();
        }
    }
}
