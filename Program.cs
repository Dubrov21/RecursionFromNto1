//Задача 66. Задайте значение N. Напишите программу, которая выведет все натуральные числа
//в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

namespace RecursionFromNto1
{
    static public class Program
    {
        static public string PrintNumbers(int start, int end)
        {
            if(start == end)
            {
                return end.ToString();
            }
            return start + ", " + PrintNumbers(start-1, end);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PrintNumbers(num, 1));
        }
    }
}
