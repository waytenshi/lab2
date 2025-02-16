using System;

class Program
{
    static void Main()
    {
        double A = 0, B = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Ввести A");
            Console.WriteLine("2. Ввести B");
            Console.WriteLine("3. Выполнить операцию '+'");
            Console.WriteLine("4. Выполнить операцию '-'");
            Console.WriteLine("5. Выполнить операцию '*'");
            Console.WriteLine("6. Выполнить операцию '/'");
            Console.WriteLine("0. Выход");

            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите значение для A: ");
                    A = Convert.ToDouble(Console.ReadLine());
                    break;
                case "2":
                    Console.Write("Введите значение для B: ");
                    B = Convert.ToDouble(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine($"A + B = {A + B}");
                    break;
                case "4":
                    Console.WriteLine($"A - B = {A - B}");
                    break;
                case "5":
                    Console.WriteLine($"A * B = {A * B}");
                    break;
                case "6":
                    if (B != 0)
                        Console.WriteLine($"A / B = {A / B}");
                    else
                        Console.WriteLine("Ошибка: деление на ноль!");
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
