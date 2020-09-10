using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEleven
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите три слова нажимая на ENTER");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            Console.WriteLine("-" + a + "-");
            Console.WriteLine("-" + b + "-");
            Console.WriteLine("-" + c + "-");
            Console.ReadKey();

        }
    }
}
