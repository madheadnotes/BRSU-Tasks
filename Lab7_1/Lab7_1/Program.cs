using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[20];
            numbers[0] = 3; 
            double s = 0;
            Console.Write(numbers[0] + " ");
            for (int i = 1; i < 20; i++)
            {
                numbers[i] = numbers[i - 1] + 2.3;
                Console.Write(numbers[i] + " ");
            }
            for (int i = 2; i < 14; i++ )
            {
                s = s + numbers[i];
            };
            Console.WriteLine();
            Console.WriteLine("Сумма диапазона элементов: {0:0.##}", s);
            Console.ReadLine();
        }
    }
}
