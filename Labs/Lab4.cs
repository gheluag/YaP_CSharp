using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_CSharp.Labs
{
    public static class Lab4
    {
        public static void Task1()
        {
            int[,] emas = new int[100, 100];
            int[] m1 = new int[10000];
            int c = 0;

            Random rnd = new();

            for (int i = 0; i < emas.GetLength(0); i++)
            {
                for (int j = 0; j < emas.GetLength(1); j++)
                {
                    emas[i, j] = rnd.Next(1, 101);
                }
            }

            Console.WriteLine("первые 10 элементов матрицы: ");
            PrintArr(emas);

            for (int i = 0; i < emas.GetLength(0); i++)
            {
                for (int j = 0; j < emas.GetLength(1); j++)
                {
                    m1[c] = emas[i, j];
                    c++;
                }
            }

            Console.WriteLine("первые 10 элементов массива: ");
            PrintArr(m1);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("изменение первых пяти элементов на 0...");
            Console.ResetColor();
            for (int i = 0; i < 5; i++)
            {
                m1[i] = 0;
            }

            c = 0;

            for (int i = 0; i < emas.GetLength(0); i++)
            {
                for (int j = 0; j < emas.GetLength(1); j++)
                {
                    emas[i, j] = m1[c];
                    c++;
                }
            }

            Console.WriteLine("матрица с измененными элементами: ");
            PrintArr(emas);


        }

        private static void PrintArr(int[,] ints)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(ints[i, j]);
                }

                Console.WriteLine();
            }
        }
        private static void PrintArr(int[] ints)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(ints[i] + " ");
            }
        }

        public static void Task2()
        {

        }
        public static void Task3()
        {

        }
        public static void Task4()
        {

        }
        public static void Task5()
        {

        }
        public static void Task6()
        {

        }
    }
}
