using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAP_CSharp.Labs;

namespace YAP_CSharp
{
    public class Utils
    {
        public static void PrintLab(int labCount)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nЛабораторная работа {labCount}");
            Console.ResetColor();
        }

        public static void PrintTask(int taskNum)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nЗадание {taskNum}\n");
            Console.ResetColor();
        }

        public static void PrintBlock(int blockNum)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Блок {blockNum}");
            Console.ResetColor();
        }

        public static void PrintJaba()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
────▄▄──▄▀▀▄▀▀▄──▄▄───
───▐▒▒▀▐░██░██░▌▀▒▒▌──
────▀▄▒▒▀▀▀▀▀▀▀▒▒▄▀───
────▄▄▌▄▒▐▀▀▀▌▒▄▐▄▄───
───▐▄▄▐▄▄▌▀▀▀▐▄▄▌▄▄▌──");
            Console.ResetColor();
        }

        public static void ChoiceTask(int choice)
        {
            switch (choice)
            {
                case 1:
                    PrintLab(1);
                    PrintTask(1);
                    Lab1.Task1();

                    PrintTask(2);
                    Lab1.Task2();
                    break;
                case 2:
                    PrintLab(2);
                    PrintBlock(1);
                    PrintTask(1);
                    Lab2.Task1();

                    PrintTask(2);
                    Lab2.Task2();

                    PrintTask(3);
                    Lab2.Task3();

                    PrintTask(4);
                    Lab2.Task4();

                    PrintTask(5);
                    Lab2.Task5();

                    PrintTask(6);
                    Lab2.Task6();

                    Console.WriteLine();
                    PrintBlock(2);
                    PrintTask(4);
                    Lab2.Task7();
                    break;

                case 3:
                    PrintLab(3);
                    PrintBlock(1);
                    PrintTask(1);
                    Lab3.Task1();

                    PrintTask(2);
                    Lab3.Task2();

                    Console.WriteLine();
                    PrintTask(3);
                    Lab3.Task3();

                    PrintTask(4);
                    Lab3.Task4();

                    Console.WriteLine();
                    PrintBlock(2);
                    PrintTask(4);
                    Lab3.Task5();

                    PrintTask(4);
                    Lab3.Task6();
                    break;
                case 4:
                    PrintLab(4);
                    PrintTask(1);
                    Lab4.Task1();

                    PrintTask(2);
                    Lab4.Task2();

                    PrintTask(3);
                    Lab4.Task3();

                    PrintTask(4);
                    Lab4.Task4();

                    PrintTask(5);
                    Lab4.Task5();

                    PrintTask(6);
                    Lab4.Task6();
                    break;

                case 5:
                    PrintLab(5);
                    PrintTask(1);
                    Lab5.Task1();

                    PrintTask(2);
                    Lab5.Task2();
                    break;

                case 6:
                    PrintLab(6);
                    PrintTask(1);
                    Lab6.Task1();

                    PrintTask(2);
                    Lab6.Task2();
                    break;
            }
        }


    }
}
