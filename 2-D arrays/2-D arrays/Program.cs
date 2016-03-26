using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class matrix
    {
        public int[,] m1 = new int[3, 3];
        public void insert()
        {
            Console.WriteLine("Enter Values in 2D array matrics");
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {

                    m1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void display()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(m1[i, j]);
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            matrix m = new matrix();
            m.insert();
            m.display();
        }

    }
}


