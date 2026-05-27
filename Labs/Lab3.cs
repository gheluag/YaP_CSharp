using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_CSharp.Labs
{
    public class Lab3
    {
        public static void Task1()
        {
            Console.Write("Введите целое число: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Таблица умножения числа {num}: \n");
            for (int i = 1; i < 201; i++)
            {
                Console.Write($"{num * i}\t");

                if (i % 10 == 0)
                    Console.WriteLine();
            }

        }
        public static void Task2()
        {
            Console.Write("Числа кратные 6 и 27 и равной суммой крайних и средних цифр: \n");
            for (int num = 1000; num <= 9999; num++)
            {
                int a = num / 1000;
                int b = (num / 100) % 10;
                int c = (num / 10) % 10;
                int d = num % 10;

                bool usl1 = (a + d) == (b + c);
                bool usl2 = num % 27 == 0 && num % 6 == 0;

                if (usl1 && usl2)
                    Console.Write($"{num} ");


            }
        }
        public static void Task3()
        {
            Console.Write("Нажмите 1 для перевода шкалы Цельсия в шкалу Фаренгейта, " +
                "2 для перевода шкалы Фаренгейта в шкалу Цельсия: ");
            int choice = int.Parse(Console.ReadLine());
            double temp;
            switch (choice)
            {
                case 1:
                    Console.Write("Введите температуру в градусах Цельсия: ");
                    temp = int.Parse(Console.ReadLine());
                    double far = temp * 9 / 5 + 32;
                    Console.WriteLine($"{temp} градусов цельсия в фаренгейтах: {far}");
                    break;
                case 2:
                    Console.Write("Введите температуру в градусах Фаренгейта: ");
                    temp = int.Parse(Console.ReadLine());
                    double cel = (temp - 32) * 5 / 9;
                    Console.WriteLine($"{temp} градусов фаренгейта в цельсия: {cel}");
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }

        }
        public static void Task4()
        {

        }
        public static void Task5()
        {
            Console.Write("Введите целое число: ");
            int num = int.Parse(Console.ReadLine());
            int origNum = num;

            Console.Write($"\nпростые множители числа {num}: ");

            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
            }

            string res = num % 15 == 0 ?
                $"\nчисло {origNum} делится на 15" :
                $"\nчисло {origNum} не делится на 15";

            Console.WriteLine(res);
        }
        public static void Task6()
        {
            Console.Write("Введите количество бросков: ");
            int num = int.Parse(Console.ReadLine());
            Random rnd = new();
            int count = 0;

            for(int i = 0; i < num; i++)
            {
                int dice = rnd.Next(1, 7);

                if (dice == 3)
                    count++;
            }

            double veroyat = count / num;

            Console.WriteLine($"Вероятность падения кубика на грань 3: {veroyat:F3}");
        }
    }
}
