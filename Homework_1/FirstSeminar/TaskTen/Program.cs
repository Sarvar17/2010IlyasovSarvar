using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTen
{
    class Program
    {
        public static void Main(string[] args)
        {
            string a = "";
            string b = "";
            string c = "";
            Console.WriteLine("Введите три слова нажимая на кнопку ENTER");
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            Console.WriteLine(a + "!" + b + "!" + c);
            Console.ReadKey();
        }
    }
}
