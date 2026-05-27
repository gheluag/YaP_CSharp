using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_CSharp.Labs
{
    public class Lab2
    {
        public static void Task1()
        {
            Console.Write("Введите 1 или 0: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("Пока!");
                    break;
                case 1:
                    Console.WriteLine("Привет!");
                    break;
                default:
                    Console.WriteLine("Некорректное число");
                    break;
            }

        }
        public static void Task2()
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            string res = num % 2 == 0 ? "четное" : "не четное";
            Console.WriteLine($"число {num} {res}");
        }
        public static void Task3()
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            string res = num % 10 == 0 ? "делится на 10" : "не делится на 10";
            Console.WriteLine($"число {num} {res}");
        }
        public static void Task4()
        {
            Console.Write("Введите целое положительное число до 1000: ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 9)
                Console.WriteLine("Однозначное число");
            else if (num <= 99)
                Console.WriteLine("Двухзначное число");
            else if (num <= 999)
                Console.WriteLine("Трехзначное число");
            else
                Console.WriteLine("Четырехзначное число");
        }
        public static void Task5()
        {
            Console.Write("Введите целое четырехзначное число: ");
            int num = int.Parse(Console.ReadLine());
            int origNum = num;
            int sum = 0;

            int lastNum = num % 10;
            int firstNum = num;

            while (firstNum >= 10)
                firstNum /= 10;


            while (num != 0)
            {
                int digit = num % 10;
                if (digit % 2 != 0)
                    sum += digit;
                num /= 10;
            }
            Console.WriteLine($"Сумма нечетных цифр числа {origNum}: {sum}");
            if (firstNum > lastNum)
                Console.WriteLine($"Первая цифра в числе больше последней");
            else if (firstNum < lastNum)
                Console.WriteLine($"Последняя цифра в числе больше первой");
            else
                Console.WriteLine($"Последняя и первая цифры равны");
        }
        public static void Task6()
        {
            Console.Write("Введите целое число: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Таблица умножения числа {num}: \n");
            for (int i = 1; i < 11; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");

        }
        public static void Task7()
        {
            Console.Write("Введите сторону треугольника: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону треугольника: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону треугольника: ");
            int c = int.Parse(Console.ReadLine());

            bool isTrian =
                 a + b > c &&
                 a + c > b &&
                 b + c > a;

            bool isRavn =
                a != b &&
                a != c &&
                b != c;

            if (isTrian && isRavn)
            {
                int minNum = Math.Min(a, Math.Min(b, c));
                int maxNum = Math.Max(a, Math.Max(b, c));
                int midNum = a + b + c - minNum - maxNum;

                Console.WriteLine($"\nстороны треугольника: {minNum}, {midNum}, {maxNum}");

                double p = (minNum + midNum + maxNum) / 2;
                double s = Math.Sqrt(p * (p - minNum) * (p - midNum) * (p - maxNum));

                Console.WriteLine($"Площадь треугольника: {s:F2}");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nТреугольник не разносторонний");
                Console.ResetColor();
            }
        }
    }
}
