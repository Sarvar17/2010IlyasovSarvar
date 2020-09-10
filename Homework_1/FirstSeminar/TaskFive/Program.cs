using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive
{
    class Program
    {
        public static void Main(string[] args)
        {
            double one;
            double two;
            Console.WriteLine("Enter first cathetus value");
            string One = Console.ReadLine();
            Console.WriteLine("Enter second cathetus value");
            string Two = Console.ReadLine();
            bool ValidateOne = double.TryParse(One, out one);
            bool ValidateTwo = double.TryParse(Two, out two);
            if (ValidateOne && ValidateTwo)
            {
                one = double.Parse(One);
                two = double.Parse(Two);
                Console.WriteLine("Hypotenuse's value is " + (Math.Sqrt(Math.Pow(one,2)+Math.Pow(two,2))));
            }
            else
            {
                Console.WriteLine("You made mistake while entering values");
            }
            Console.ReadKey();
        }
    }
}
