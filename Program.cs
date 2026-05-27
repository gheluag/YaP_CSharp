using YAP_CSharp.Labs;
using YAP_CSharp;


// методы с заданиями
int choice;

while (true)
{
    Console.Clear();
    Utils.PrintJaba();
    Console.WriteLine("\n***Лабораторные работы***");
    Console.WriteLine("1. ввод-вывод\n2. условия" +
        "\n3. циклы\n4.массивы" +
        "\n5.\n6." +
        "\n0. выход");
    Console.Write("введите номер лабораторной работы: ");
    choice = int.Parse(Console.ReadLine());
    if (choice == 0)
        break;

    Utils.ChoiceTask(choice);
    Console.ReadKey();
}









