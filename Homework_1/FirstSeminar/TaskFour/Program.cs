using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour
{
    class Program
    {
        public static void Main(string[] args)
        {
            double U;
            double R;
            Console.WriteLine("Write value of U");
            string u = Console.ReadLine();
            Console.WriteLine("Write value of R");
            string r = Console.ReadLine();
            bool ValidateU = double.TryParse(u, out U);
            bool ValidateR = double.TryParse(r, out R);
            if (ValidateU && ValidateR)
            {
                U = double.Parse(u);
                R = double.Parse(r);
                Console.WriteLine("I = U/R = " + (U / R));
                Console.WriteLine("P = U^2/R = " + (Math.Pow(U, 2)/R));
            }
            else
            {
                Console.WriteLine("Error, plz enter number");
            }
            Console.ReadKey();
        }
    }
}
