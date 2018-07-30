using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение гипотенузы:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение угла:");
            double corner_a = Convert.ToDouble(Console.ReadLine());
            double corner_b = 90 - corner_a;
            double a = c * Math.Sin(corner_a);
            double b = c * Math.Sin(corner_b);
            double area = (a * b) / 2;
            Console.WriteLine("Площадь треугольника равна: {0:0.####}", area);
            Console.ReadLine();
        }
    }
}
