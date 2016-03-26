using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_and_finding_desired_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 5, 3, 9, 1, 0 };
            int temp = 0;
            // sorting an array
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            // end sorting of an array
            int bignumber = arr[arr.Length - 1];     // finding 1st big number in an array
            Console.WriteLine("Ist big number in an array:{0} ", bignumber);
            //-----------------------------------------------------------------------------------

            int secondbig = arr[arr.Length - 2]; // finding second big number in an array
            Console.WriteLine("2nd big number in an array:{0} ", secondbig);
            //-----------------------------------------------------------------------------------

            int firstSamllest = arr[0];
            Console.WriteLine("Ist small number in an array:{0} ", firstSamllest);
            //-----------------------------------------------------------------------------------

            int secondSamllest = arr[1];
            Console.WriteLine("2nd small number in an array:{0} ", secondSamllest);
            //-----------------------------------------------------------------------------------
            Console.ReadLine();
        

        }
    }
}
