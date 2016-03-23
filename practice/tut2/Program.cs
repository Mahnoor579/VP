using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tut2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("please enter your name");
            string username = Console.ReadLine();
            Console.WriteLine("Hello" + username);
            Console.WriteLine("Hello {0}", username);
            Console.ReadLine();
            //2
            Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastname = Console.ReadLine();
            Console.WriteLine("\"Hello\" {0} {1}", firstname, lastname);
            Console.ReadLine();
            //3
            int number = 15;
            bool Isnumber10 = number == 10 ? true : false;

            Console.WriteLine("The number is {0}", Isnumber10);
            Console.ReadLine();
            //4
            string name = null;
            int? i = null;
            //5 null coelessing operator

            int Ticketsonsale = 100;
            int availabletickets = Ticketsonsale  ;
            Console.WriteLine("Available tickets are: {0}", Ticketsonsale);
            Console.ReadLine();


        }

            


            
        }
    }

