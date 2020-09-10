using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Выделение отдельных цифр натурального числа
            Задача. 
            Ввести трехзначное натуральное число и напечатать его цифры "столбиком".*/

            int abc = 0,
                a = 0,
                b = 0,
                c = 0;
            string input;

            Console.Write("Enter three-digit number : ");
            input = Console.ReadLine();

            if(!Validation(ref input, ref abc))
            {
                Console.WriteLine("ERROR: Incorrect number, REENTER!");
            }
            else
            {
                FindingDigits(ref abc, ref a, ref b, ref c, ref input);

                Console.WriteLine($"First  digit is {a} \r\nSecond digit is {b} \r\nLast   digit is {c}");
            }
            
            Console.ReadKey();
        }

        public static bool Validation(ref string input, ref int abc)
        {
            //метод чтобы проверить правильное число ввел пользователь или нет

            bool output = true;

            if (!int.TryParse(input, out abc) || int.Parse(input)<100 || int.Parse(input)>999)
            {
                output = false;
            }

            return output;
        }

        public static void FindingDigits(ref int abc, ref int a, ref int b, ref int c, ref string input)
        {
            //метод чтобы найти нужные нам числа
            a = abc / 100;
            b = (abc - a*100) / 10;
            c = abc - a*100 - b*10;
        }
    }
}
