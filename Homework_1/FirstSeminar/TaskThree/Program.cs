using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input;
            int integer;

            Console.WriteLine("Enter number from 32 to 127");
            input = Console.ReadLine();

            bool ValidateInput = int.TryParse(input, out integer);
            if (!ValidateInput || int.Parse(input) < 32 || int.Parse(input) > 127)
            {
                Console.WriteLine("Some ERROR while entering value");
            }
            else
            {
                Console.WriteLine((char)integer);
            }
            Console.ReadKey();
        }
    }
}
