using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_nonrepeated_character_in_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 1;
            string str = "mahnoor";
            char[] ch = str.ToCharArray();
            for (int i = 0; i<ch.Length; i++)
            {
                flag = 1;
                for (int j=i+1; j<ch.Length; j++)
                {
                    if(ch[i]==ch[j])
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag==1)
                {
                    Console.WriteLine("first non repeated character is: {0}", ch[i]);
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
