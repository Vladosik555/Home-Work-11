using System;

namespace Тумаков_14
{
    internal class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Упражнение 14.1");
            Console.WriteLine("Использование условного атрибута");

            Bank_account bank = new Bank_account(10000);
            Console.WriteLine("Выберите операцию: " +
                "\nДля того чтобы положить деньги на баланс, нажмите 0" + 
                "\nДля того чтобы снять деньги с баланса, нажмите 1" +
                "\nДля того чтобы перевести деньги, нажмите 2");
            bool flag = uint.TryParse(Console.ReadLine(), out uint number);
            if (flag)
            {
                switch (number)
                {
                    case 0:
                        Console.Write("Напишите сумму, которую хотите положить на счёт: ");
                        bool flag_1 = double.TryParse(Console.ReadLine(),out  double money);
                        if (flag_1)
                        {
                            bank.Put_Money(money);
                            bank.DumpToScreen();
                        }
                        else
                        {
                            Console.WriteLine("Нельзя вводить строки, символы и отрицательны числа");
                        }
                        break;
                    case 1:
                        Console.Write("Напишите сумму, которую хотите снять со счёт: ");
                        bool flag_2 = double.TryParse(Console.ReadLine(), out double money_1);
                        if (flag_2)
                        {
                            bank.Withdraw_Money(money_1);
                            bank.DumpToScreen();
                        }
                        else
                        {
                            Console.WriteLine("Нельзя вводить строки, символы и отрицательны числа");
                        }
                        break;
                    case 2:
                        Console.Write("Напишите сумму, которую хотите перевести на другой счёт: ");
                        bool flag_3 = double.TryParse(Console.ReadLine(), out double money_2);
                        if (flag_3)
                        {
                        }
                        else
                        {
                            Console.WriteLine("Нельзя вводить строки, символы и отрицательны числа");
                        }
                        Console.Write("Напишите номер карты, на которую вы хотите перевести деньги: ");
                        bool flag_4 = uint.TryParse(Console.ReadLine(), out uint id);
                        if (flag_4)
                        {
                        }
                        else
                        {
                            Console.WriteLine("Нельзя вводить строки, символы и отрицательны числа");
                        }
                        bank.Transfer(money_2, id);
                        bank.DumpToScreen();
                        break;
                    default:
                        Console.WriteLine("Такой операции не существует");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Нельзя вводить строки, символы и отрицательны числа");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Упражнение 14.2");
            Console.WriteLine("Создать пользовательский атрибут");
            Rational_numbers number_1 = new Rational_numbers(10, 5);
            Console.WriteLine();
            Console.WriteLine($"{number_1}");
            var type = typeof(Rational_numbers);
            var attributes = type.GetCustomAttributes(false);
            foreach (DeveloperInfoAttribute attribute in attributes )
            {
                Console.WriteLine($"Имя разработчика: {attribute.name}");
                Console.WriteLine($"Дата создания класса: {attribute.time}");
            }
            Console.WriteLine();
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Домашнее задание 14.1");
            Console.WriteLine("Создать пользовательский атрибут для класса из домашнего задания 13.1");
            Console.WriteLine();
            Creator_Build build = new Creator_Build(100, 50, 400, 5);
            Console.WriteLine($"Высота одного этажа: {build.Heigth(100, 50)} метров");
            Console.WriteLine($"\nКоличество этажей на один подъезд: {build.Quantity_apart_inENTR(50, 5)}");
            Console.WriteLine($"\nКоличество квартир на одном этаже: {build.Quantity_apart_infloor(400, 50)}");
            Console.WriteLine();
            var type_1 = typeof(Creator_Build);
            var attributes_1 = type_1.GetCustomAttributes(false);
            foreach(Developer_Attribute attribute_1 in attributes_1)
            {
                Console.WriteLine($"Имя разработчика: {attribute_1.name}");
                Console.WriteLine($"Название организации: {attribute_1.name_organization}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
        }
    }
}
