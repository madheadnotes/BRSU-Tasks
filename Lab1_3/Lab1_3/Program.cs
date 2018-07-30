using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диагональ квадрата:");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь квадрата равна: {0:0.####}", Math.Pow(d, 2) / 2);
            Console.WriteLine("Периметр квадрата равен: {0:0.####}", d * 2 * Math.Sqrt(2));
            Console.ReadLine();
        }
    }
}
