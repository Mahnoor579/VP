using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenbyarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] en = new int[3];
            
                Console.WriteLine("Enter Numbers");
                for (int i=0; i<= en.Length; i++ )
                {
                    en[i] = Convert.ToInt32(Console.ReadLine());
                }
            for (int i=0; i<=en.Length; i++)
            {
                if (en[i]%2==0)
                {
                    Console.WriteLine("Number is even");
                    Console.ReadLine();
                }
                else if (en[i]%2!=0)
                {
                    Console.WriteLine("Number is odd");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid NUMBER");
                    Console.ReadLine();
                }
            }
            


        }
    }
}
