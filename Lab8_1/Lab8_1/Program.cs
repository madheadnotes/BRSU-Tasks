using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов массива: ");
            int q = int.Parse(Console.ReadLine());
            int[] numbers = new int[q];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-8, -3);
                sum = sum + numbers[i];
            }
            int a = sum / q; bool answer = false;
            foreach (int s in numbers)
            {
                Console.Write(s.ToString() + " ");
                if (s == a) { answer = true; };
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое элементов массива: {0}", a);
            if (answer == true) { Console.WriteLine("В данном массиве имеется число, равное среднему арифметическому элементов массива."); }
            else { Console.WriteLine("В данном массиве нет числа, равного среднему арифметическому элементов массива."); };
            Console.ReadLine();
        }
    }
}
