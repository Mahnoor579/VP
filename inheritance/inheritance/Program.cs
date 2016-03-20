using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        class shape
        {
            protected int height;
                protected int width;
            public void setheight (int h)
                {
                    height = h;
                }
            public void setwidth (int w)
            {
                width = w;
            }

        }
        class Rectangle:shape
        {
            public void area()
            {
                int a = height * width;
                Console.WriteLine("Area of rectangle is :" + a);
            }
        }
        static void Main(string[] args)
        {
            int h;
            int w;
            Console.WriteLine("please enter height and width");
            h = Convert.ToInt32(Console.ReadLine());
            w = Convert.ToInt32(Console.ReadLine());


            
            
            Rectangle r1 = new Rectangle();
            r1.setheight(h);
            r1.setwidth(w);
            r1.area();
            Console.Read();



        }
    }
}
