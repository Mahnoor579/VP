using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_1
{
    class Program
    {
        class Circle
        {
            double radius;
            public void getvalue (double rad)
            {
                radius = rad;
            }
            public double area()
            {
                return 3.14 * radius * radius;
            }
            public void display ()
            {
                Console.WriteLine("The area of the circle is : " + area());
               
            }
        }
       
        
        static void Main(string[] args)
        {
            double rad;
          
            Console.WriteLine("please enter the radius:");
            rad = Convert.ToDouble(Console.ReadLine());
            Circle c1 = new Circle();
            c1.getvalue(rad);
            c1.display();
            Console.Read();

            
        }
    }
}
