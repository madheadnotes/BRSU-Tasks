using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeTask();
            int x = 0;
            for (int i = 100; i <= 999; i++)
            {
                if (((i / 10) % 10 == 3) ^ (i % 10 == 9))
                // a = i % 10; находим цифру единиц
                // b = (i / 10) % 10; находим цифру десятков
                // c = i / 100; находим цифру сотен
                {
                    Console.Write(i.ToString() + ' ');
                    x++;
                }
            }
            Console.WriteLine("Всего чисел: {0}", x);
            Console.ReadLine();
        }
        public static void TypeTask()
        {
            Console.WriteLine("Найти все трехзначные числа, в запись которых во второй позиции входит цифра 3 или в третьей позиции – цифра 9. ");
            Console.WriteLine("______________________________");
            Console.WriteLine();

        }
    }
}
