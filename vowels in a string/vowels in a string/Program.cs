using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels_in_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
          
                    int my_count = 0;
            Console.WriteLine("Enter a string:");
            string myString = Console.ReadLine();
            foreach (char ch_vowel in myString)
            {
                switch (ch_vowel)
                {
                    case 'a':
                    case 'A':
                        my_count++;
                        break;
                    case 'e':
                    case 'E':
                        my_count++;
                        break;
                    case 'i':
                    case 'I':
                        my_count++;
                        break;
                    case 'o':
                    case 'O':
                        my_count++;
                        break;
                    case 'u':
                    case 'U':
                        my_count++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Number of Vowels are: {0} ", my_count);
            Console.Read();
        }
    }
} 
    
    
