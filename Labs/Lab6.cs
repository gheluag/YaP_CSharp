using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_CSharp.Labs
{
    public class Lab6
    {
        public static unsafe void Task1()
        {
            Console.Write("Введите количество элементов: ");
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                A[i] = rand.Next(20, 41);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] > A[j])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив с помощью индексов:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }

            Console.WriteLine("\n");

            fixed (int* pA = A)
            {
                Console.WriteLine("Отсортированный массив с помощью указателей:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(*(pA + i) + " ");
                }
            }
        }

        public static unsafe void Task2()
        {
            Console.Write("Введите количество элементов: ");
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            int[] B = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                A[i] = rnd.Next(5, 31);
                B[i] = rnd.Next(5, 31);
            }

            Console.WriteLine("Массив A:");
            PrintArr(A);

            Console.WriteLine("Массив B:");
            PrintArr(B);


            int maxA = 0, minA = 0;
            int maxB = 0, minB = 0;

            for (int i = 1; i < n; i++)
            {
                if (A[i] > A[maxA]) maxA = i;
                if (A[i] < A[minA]) minA = i;

                if (B[i] > B[maxB]) maxB = i;
                if (B[i] < B[minB]) minB = i;
            }

            int temp = A[maxA];
            A[maxA] = B[maxB];
            B[maxB] = temp;

            temp = A[minA];
            A[minA] = B[minB];
            B[minB] = temp;

            Console.WriteLine("\nПосле обмена:");

            Console.WriteLine("A:");
            PrintArr(A);

            Console.WriteLine("B:");
            PrintArr(B);


            fixed (int* pA = A, pB = B)
            {
                long diffBytes = (long)(pA - pB) * sizeof(int);

                Console.WriteLine($"\nРасстояние между массивами: {Math.Abs(diffBytes)} байт");
            }
        }

        private static void PrintArr(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + " ");
            }
        }


    }
}
