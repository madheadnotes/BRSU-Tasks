using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение первого катета:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение второго катета:");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = System.Math.Sqrt(System.Math.Pow(a, 2) + System.Math.Pow(b, 2));
            double corner_a = Math.Atan(a / b);
            double corner_b = Math.Atan(b / a);
            Console.WriteLine("Значение гипотенузы: {0}; значения углов a: {1}, b: {2}, c: 90; ", c, corner_a * 180 / Math.PI, corner_b * 180 / Math.PI);
            Console.ReadLine();
        }
    }
}
