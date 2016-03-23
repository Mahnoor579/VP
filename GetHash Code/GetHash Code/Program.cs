using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHash_Code
{
    class Student
    {
        public int age = 20;
        public virtual void print()
        {
            Console.WriteLine(age);
            Console.ReadKey();

        }
        public class student2 : Student
        {
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
        static void Main(string[] args)
        {
            student2 sd2 = new student2();
            sd2.GetHashCode();

        }
    }
}
