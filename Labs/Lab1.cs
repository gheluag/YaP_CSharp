using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_CSharp.Labs
{
    public static class Lab1
    {
        public static void Task1()
        {
            int sumNum = 0;
            int sumDen = 0;
            Console.Write("Введите первую дробь: ");
            string input = Console.ReadLine();

            int a = int.Parse(input.Split('/')[0]);
            int b = int.Parse(input.Split('/')[1]);

            Console.Write("\nВведите вторую дробь: ");
            input = Console.ReadLine();

            int c = int.Parse(input.Split('/')[0]);
            int d = int.Parse(input.Split('/')[1]);

            sumNum = a * d + b * c;
            sumDen = b * d;
            Console.WriteLine($"\nСумма дробей {a}/{b} и {c}/{d} равна {sumNum}/{sumDen}");

        }
        public static void Task2()
        {
            Console.Write("Введите значение x: ");
            double x = int.Parse(Console.ReadLine());
            double y = 0;

            y = Math.Pow(x, 1.0 / 5) - 11 * Math.Sqrt(x) * Math.Sin(0.08 * x);
            Console.WriteLine($"y({x}) = {y:F3}");

        }
    }
}
