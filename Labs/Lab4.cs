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

            Console.WriteLine("первые 10 элементов матрицы: \n");
            PrintArr(emas);

            for (int i = 0; i < emas.GetLength(0); i++)
            {
                for (int j = 0; j < emas.GetLength(1); j++)
                {
                    m1[c] = emas[i, j];
                    c++;
                }
            }

            Console.WriteLine("\n\nпервые 10 элементов массива: ");
            PrintArr(m1);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nизменение первых пяти элементов на 0...\n\n");
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

            Console.WriteLine("матрица с измененными элементами: \n");
            PrintArr(emas);


        }

        private static void PrintArr(int[,] ints)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(ints[i, j] + " ");
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
            Console.Write("Введите текст: ");
            string text = Console.ReadLine().ToLower();

            char[] from = new char[]
            {
            'а','б','в','г','д','е','ё','ж','з','и',
            'й','к','л','м','н','о','п','р','с','т',
            'у','ф','х','ц','ч','ш','щ','ъ','ы','ь',
            'э','ю','я'
            };

            char[] to = new char[]
            {
            '1','2','3','4','5','6','7','8','9','0',
            '!','@','#','$','%','^','&','*','(',')',
            '-','=','+','/','?','|','[',']','{',
            '}','~','_'
            };

            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                bool found = false;

                for (int j = 0; j < from.Length; j++)
                {
                    if (c == from[j])
                    {
                        result += to[j];
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    result += c;
                }
            }

            Console.WriteLine("Закодированный текст:");
            Console.WriteLine(result);
        }
        public static void Task3()
        {
            double[,] A = new double[5, 7];

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    A[i, j] = rnd.NextDouble() * 10;
                }
            }

            Console.Write("Введите целое число: ");
            int k = int.Parse(Console.ReadLine());

            if (k < 2 || k > 12)
            {
                Console.WriteLine($"Ошибка!!! Для данного числа k ({k}) решений нет");
                return;
            }

            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if ((i + 1) + (j + 1) == k)
                    {
                        sum += A[i, j];
                    }
                }
            }

            Console.WriteLine($"Сумма элементов: {sum}");

        }
        public static void Task4()
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[n, n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rnd.Next(1, 10);
                }
            }

            Console.WriteLine("Исходная матрица:");
            PrintArr(A);

            for (int i = 0; i < n; i++)
            {
                int diag = A[i, i];

                for (int j = 0; j < n; j++)
                {
                    A[i, j] += diag;
                }
            }

            Console.WriteLine("После изменения:");
            PrintArr(A);

        }


        public static void Task5()
        {
            int[] a = new int[3];

            Console.WriteLine("Введите a1, a2, a3:");

            for (int i = 0; i < 3; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int[,] b = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    b[i, j] = a[i] * (1 - 2 * a[j]);
                }
            }

            Console.WriteLine("Матрица b:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Task6()
        {
            Console.Write("Введите количество элементов: ");
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rnd.Next(-5, 6);
                }
            }

            Console.WriteLine("Матрица:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j > n - 1 && A[i, j] == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Количество нулей ниже побочной диагонали: {count}");
        }
    }
}
