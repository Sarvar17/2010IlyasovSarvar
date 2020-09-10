using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Задача 4. 
            Написать метод с целочисленным параметром, определяющий является ли значение аргумента кодом цифры, 
            кодом буквы русского алфавита (прописной либо строчной), или ни тем и ни другим. В основной программе, 
            вводя целые числа, выводить сообщения о них: «Это цифра!», «Это буква!», «Это ни буква, ни цифра!». 
            Для выхода из программы – ESC, для повторения решения - любой символ. При анализе цифрового кода 
            использовать тернарную операцию. Строку сообщения может возвращать метод, либо метод возвращает признак, 
            а строку формирует основная программа 
            */
            uint code=0;
            string input = "";
            string report = "";
            uint code_A = (uint)'А',
                code_a = (uint)'а',
                code_Ya = (uint)'Я',
                code_ya = (uint)'я',
                code_0 = (uint)'0',
                code_9 = (uint)'9';

            Inputting(ref code, ref input, ref code_A, ref code_a, ref code_Ya, ref code_ya, ref code_0, ref code_9);

            Reporting(ref code, ref report);

            Console.WriteLine("\r\nPress ESC to exit, or other button to repeat");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            //пока пользователь не нажмет кнопку ESC программа продолжить свою работу
            {
                Main(args);
            }
        }

        public static void Inputting(ref uint code, ref string input, ref uint code_A, ref uint code_a, ref uint code_Ya, ref uint code_ya, ref uint code_0, ref uint code_9)
        {
            // метод чтобы ввести наше число
            Console.WriteLine("Codes of symbols:");
            Console.Write($"code_A = {code_A}, \r\ncode_Я = {code_Ya}, \r\ncode_a = {code_a}, \r\ncode_я = {code_ya}, \r\ncode_0 = {code_0}, \r\ncode_9 = {code_9} \r\nEnter value of CODE:");
            input = Console.ReadLine();
            uint.TryParse(input, out code);
        }

        public static void Reporting(ref uint code, ref string report)
        {
            // метод чтобы обработать то число которое ввел пользователь
            report = code <= '9' && code >= '0' ? "This is Number: " + (char)code
            : code <= 'Я' && code >= 'А' ? "This is capital letter: " + (char)code
            : code <= 'я' && code >= 'а' ? "This is descender letter: " + (char)code
            : "Unknown symbol!";
            Console.WriteLine(report);
        }
    }
}
