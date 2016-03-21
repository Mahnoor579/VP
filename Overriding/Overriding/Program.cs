using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Employee
    {
        public string firstName;
        public string secondName;
       
        public virtual void printName()
        {
            Console.WriteLine(firstName + " " + secondName);
            Console.ReadKey();
        }

        public class PartTimeEmployee : Employee
        {
            public override void printName()
            {
                Console.WriteLine(firstName + " " + secondName + "-PART TIME EMPLOYEE");
                Console.ReadKey();
            }
        }
        public class fulltimeEmployee : Employee
        {
            public override void printName()
            {
                Console.WriteLine(firstName + " " + secondName + "-FULL TIME  EMPLOYEE");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)

        {
            
            //fulltimeEmployee F1 = new fulltimeEmployee();

            //F1.firstName = "Mahnoor";
            //F1.secondName = "Ahmed";
           
            //F1.printName();
            Employee e1 = new Employee();
            e1.firstName = "Mahnoor";
            e1.secondName = "Ahmed";
            e1.printName();
            
        }
    }
}
