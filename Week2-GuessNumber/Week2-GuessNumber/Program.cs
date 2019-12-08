using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int nr = rnd.Next(1, 100);

            while (true)
            {
                Console.WriteLine("Please input your number:");
                string input = Console.ReadLine();
                int numberInput = int.Parse(input);
                if (numberInput == nr)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else if (numberInput < nr)
                {
                    Console.WriteLine("Your number is smaller");
                }
                else
                {
                    Console.WriteLine("Your number is bigger");
                }
            }
        }
    }
}
