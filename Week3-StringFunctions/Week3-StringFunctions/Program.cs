using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "Denis Zoican";

            if (string.IsNullOrEmpty(s)) //First function
            {
                Console.WriteLine("String is empty");
            }
            else
            {
                Console.WriteLine(string.Format("The string is:\n{0}", s)); //Seconds function
            }

            Console.WriteLine("First letter of my name is {0}", s[s.IndexOf("Denis")]); ///Third function

            string s1 = " is a student";

            Console.WriteLine(string.Concat(s,s1)); ///Fourth function

            s = s.Replace("Denis", "Denis Alexandru"); ///Fifth function
            Console.WriteLine(s);

            if (s.Contains("Mihai")) ///sixth function
            {
                Console.WriteLine("Imposibil");
            } else
            {
                Console.WriteLine("Pe mine nu ma cheama Mihai.");
            }

            Console.WriteLine(s.ToLower()); ///seventh function
        }
    }
}
