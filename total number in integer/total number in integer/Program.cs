using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace total_number_in_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, count = 0;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                number = number / 10;
                count++;
            }
            Console.WriteLine("Total number in the integer : {0}", count);
            Console.ReadLine();
        }
    }
}
