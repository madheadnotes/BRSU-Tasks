using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeTask();
            Console.WriteLine("Введите число:");
            int number;
            bool result = int.TryParse(Console.ReadLine(), out number);
            if (result)
            {
                if (number % 2 == 0)
                { Console.WriteLine("Число четное."); }
                else
                { Console.WriteLine("Число нечетное."); };
            }

            else
            {
                Console.WriteLine("Неверно введено число.");
            }

            Console.ReadLine();
        }
        public static void TypeTask()
        {
            Console.WriteLine("Определить, является ли число четным.");
            Console.WriteLine("______________________________");
            Console.WriteLine();

        }
    }
}
