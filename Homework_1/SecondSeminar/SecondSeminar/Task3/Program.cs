using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Task3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 0, y = 0, z = 0;
            string X, Y, Z;

            Console.WriteLine("\r\nEnter three integers");

            X = Console.ReadLine();
            Y = Console.ReadLine();
            Z = Console.ReadLine();

            if (!Validation(ref X, ref Y, ref Z))
            {
                // если пользователь введет неправильные числа то выйдет строка где говорится что произошла ошибка
                Console.WriteLine("ERROR while entering values");
            }
            else
            {
                x = int.Parse(X);
                y = int.Parse(Y);
                z = int.Parse(Z);
                Console.WriteLine(" x = {0} \r\n y = {1} \r\n z = {2}", x, y, z);

                SortingValues(ref x, ref y, ref z);

                Console.WriteLine($"{x} <= {y} <= {z}");
            }

            Console.WriteLine("\r\nPress ESC to exit, or other button to repeat");
            while (Console.ReadKey().Key != ConsoleKey.Escape) 
                //пока пользователь не нажмет кнопку ESC программа продолжить свою работу
            {
                Main(args);
            }
        }

        public static void SortingValues(ref int x, ref int y, ref int z)
        {
            // в этом методе создается массив в который входит три числа (которые ввел пользователь), и находит макс. и мин. чтобы их упорядочить

            int a1, a2, a3;
            int[] integers = { x, y, z };
            a1 = integers.Min();
            a3 = integers.Max();
            a2 = ((a1 == x && a3 == z) || (a1 == z && a3 == x)) ? (y) : ( ((a1 == x && a3 == y) || (a1 == y && a3 == x)) ? (z) : ( ((a1 == y && a3 == z) || (a1 == z && a3 == y)) ? (x) : (x)) );

            x = a1;
            y = a2;
            z = a3;
        }

        public static bool Validation(ref string X, ref string Y, ref string Z)
        {
            // этот метод проверяет правильное число ввел пользователь или нет

            bool output = true;

            int x, y, z;

            if (!int.TryParse(X, out x))
            {
                output = false;
            }
            if (!int.TryParse(Y, out y))
            {
                output = false;
            }
            if (!int.TryParse(Z, out z))
            {
                output = false;
            }

            return output;
        }
    }
}
