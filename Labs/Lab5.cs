using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_CSharp.Labs
{
    public class Lab5
    {
        struct Student
        {
            public string FullName;
            public string Group;
            public int Age;
            public int Score;
        }
        public static void Task1()
        {
            Random rnd = new Random();
            Student[] students = new Student[8];

            students[0] = new Student { FullName = "Иванов И.И.", Group = "7201-11", Age = 18, Score = 0 };
            students[1] = new Student { FullName = "Петров П.П.", Group = "7201-11", Age = 19, Score = 0 };
            students[2] = new Student { FullName = "Сидоров С.С.", Group = "7201-11", Age = 20, Score = 0 };
            students[3] = new Student { FullName = "Кузнецов А.А.", Group = "7201-11", Age = 18, Score = 0 };
            students[4] = new Student { FullName = "Попов Д.Д.", Group = "7201-12", Age = 21, Score = 0 };
            students[5] = new Student { FullName = "Васильева М.М.", Group = "7201-12", Age = 18, Score = 0 };
            students[6] = new Student { FullName = "Морозов Н.Н.", Group = "7201-12", Age = 20, Score = 0 };
            students[7] = new Student { FullName = "Фёдоров В.В.", Group = "7201-12", Age = 19, Score = 0 };

            Console.WriteLine($"{"ФИО",-25} {"Группа",-12} {"Возраст",-8} {"Баллы",-6}");
            Console.WriteLine(new string('-', 55));

            foreach (var s in students)
                Console.WriteLine($"{s.FullName,-25} {s.Group,-12} {s.Age,-8} {s.Score,-6}");

            Console.WriteLine("\n\n\t\tРозыгрыши");

            for (int i = 0; i < 25; i++)
            {
                int index = rnd.Next(0, 8);

                students[index].Score++;

                Console.WriteLine(
                    $"Розыгрыш {i + 1}: победил " +
                    $"{students[index].FullName}, баллы = {students[index].Score}"
                );
            }
            int maxIndex = 0;

            for (int i = 1; i < 8; i++)
            {
                if (students[i].Score > students[maxIndex].Score)
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine("\nПобедитель розыгрыша:");
            Console.WriteLine($"{students[maxIndex].FullName} — {students[maxIndex].Score} баллов");

        }

        public static unsafe void Task2()
        {
            int[] A = new int[20];
            int*[] A_ptr = new int*[20];

            Random rand = new Random();

            fixed (int* pA = A)
            {
                for (int i = 0; i < 20; i++)
                {
                    A[i] = rand.Next(-50, 51);
                    A_ptr[i] = &pA[i]; 
                }

                Console.WriteLine("Массив A:");
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(A[i] + " ");
                }

                Console.WriteLine("\n");

                for (int i = 0; i < 19; i++)
                {
                    for (int j = i + 1; j < 20; j++)
                    {
                        if (*A_ptr[i] > *A_ptr[j])
                        {
                            int* temp = A_ptr[i];
                            A_ptr[i] = A_ptr[j];
                            A_ptr[j] = temp;
                        }
                    }
                }

                Console.WriteLine("Адреса элементов в массиве A_ptr:");
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine((long)A_ptr[i] + " ");
                }

                Console.WriteLine("\nОтсортированные значения через указатели:");

                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine(*A_ptr[i] + " ");
                }
            }
        }
    }
}
