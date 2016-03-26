using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaping
{
    class Swap
    {
        int a;
        int b;
        int temp;

        public void getData()
        {
            Console.WriteLine("\t \t S W A P I N G   W I T H   3 R D   V A R I A B L E  ");

            Console.WriteLine("\n Please Enter the Value of 1st Integer");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Value of 2nd Integer");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public void swaping()
        {

            temp = a;
            a = b;
            b = temp;

        }
        public void ShowData()
        {
            Console.WriteLine("Value of 1st Integer after swaping is {0}", a);
            Console.WriteLine("Value of 2nd Integer after swaping is {0}", b);
            Console.ReadKey();
        }
    };
    class Program
    {
        static void Main(string[] args)
        {

            Swap s1 = new Swap();
            s1.getData();
            s1.swaping();
            s1.ShowData();

        }
    }
}