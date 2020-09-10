using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Задан круг с центром в начале координат и радиусом R=10.   
            Ввести  координаты точки и вывести сообщение:   «Точка внутри круга!» или «Точка вне круга!».
            Предусмотреть проверку входных данных и цикл повторения решений. */

            const double R = 10;
            string inputOne = "";
            string inputTwo = "";
            double x = 0,
                   y = 0;

            Console.Write("Radius of circle is 10. \r\nEnter x : ");
            inputOne = Console.ReadLine();
            Console.Write("Enter y : ");
            inputTwo = Console.ReadLine();

            if(!Validation(ref inputOne, ref inputTwo, ref x, ref y))
            {
                Console.WriteLine("ERROR while entering points");
            }
            else
            {
                FindPoint(ref x, ref y, R);
            }


            Console.WriteLine("\r\nPress ENTER to exit, or other button to repeat");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            //пока пользователь не нажмет кнопку ESC программа продолжить свою работу
            {
                Main(args);
            }
        }

        public static bool Validation(ref string inputOne, ref string inputTwo, ref double x, ref double y)
        {
            //метод чтобы проверить правильно ввел пользователь точки или нет

            bool output = true;
            if (!double.TryParse(inputOne, out x) || !double.TryParse(inputTwo, out y))
            {
                output = false;
            }
            return output;
        }

        public static void FindPoint(ref double x, ref double y, double R)
        {
            //метод чтобы определить где находится точка

            if (x*x+y*y > R*R)
            {
                Console.WriteLine("The Point is outside circle!");
            }
            else
            {
                Console.WriteLine("The Point is inside circle!");
            }
        }
    }
}
