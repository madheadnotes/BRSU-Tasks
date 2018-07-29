using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeTask();
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение z:");
            double z = Convert.ToDouble(Console.ReadLine());
            double t = ((2 * (Math.Cos(x - (Math.PI / 6)))) / (0.5 + Math.Pow(Math.Sin(y), 2))) * (1 + ((Math.Pow(z, 2)) / (3 - Math.Pow(z, 2) / 5)));
            Console.WriteLine("Значение t:{0:0.######}", t);
            Console.ReadLine();
        }



        public static void TypeTask()
        {
            Console.WriteLine("   2cos(x-Pi/6)       z^2     ");
            Console.WriteLine("t= ----------- *(1+ ------- )     ");
            Console.WriteLine("   0.5+sin^2*y      3-z^2/5   ");
            Console.WriteLine();
            Console.WriteLine("Контрольные значения: x=14.26, y=-1.22, z=0.035; контрольный результат: 0.564849");
            Console.WriteLine("______________________________");
            Console.WriteLine();

        }
    }
}
