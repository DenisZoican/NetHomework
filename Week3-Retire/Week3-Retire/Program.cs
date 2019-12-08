using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Retire
{
    class Program
    {
        public enum gender
        {
            Male,
            Female
        }

        static void Main(string[] args)
        {
            String x = Console.ReadLine();

            String[] separator = { " " };
            Int32 count = 4;

            String[] inputs = x.Split(separator, count, StringSplitOptions.RemoveEmptyEntries);

            DateTime date = new DateTime(Int32.Parse(inputs[0]), Int32.Parse(inputs[1]), Int32.Parse(inputs[2]));
            Int32 age = DateTime.Now.Subtract(date).Days / 365;

            Char? gender = null;

            if (inputs[3].CompareTo("F") == 0 || inputs[3].CompareTo("M") == 0)
            {
                gender = inputs[3][0];
                if (age >= 63 && gender == 'F' || age >= 65 && gender == 'M')
                {
                    Console.WriteLine("Retired");
                }
                else
                {
                    if (gender == 'F')
                    {
                        Console.WriteLine("She will retire at 63");
                    }
                    else
                    {
                        Console.WriteLine("He will retire at 65");
                    }
                }
            }
        }
    }
}
