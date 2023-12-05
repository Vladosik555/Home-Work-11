using System;

namespace Тумаков_13
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Упражнение 13.1 и 13.2");
            Console.WriteLine("Удалить методы, возвращающие значение, и добавить свойства только для чтения" +
                "\nДобавить индексатор в класс банковский счет для получения доступа к любому объекту BankTransaction");
            Console.WriteLine();
            Bank_account bank_1 = new Bank_account(123456, BankType.текущий, 10000, "Владислав Шолохов");
            Console.WriteLine($"На вашем {BankType.текущий} счёте {10000} рублей");
            Console.WriteLine("\nВыберите операцию:" +
                "\nесли желаете положить деньги на счёт, нажмите 1" +
                "\nесли желаете снять деньги со счёта, нажмите 2" +
                "\nесли желаете перевести деньги на другую карту, нажмите 3");
            bool flag = int.TryParse(Console.ReadLine(), out int operation);
            if (flag)
            {
                switch (operation)
                {
                    case 1:
                        Console.Write("Напишите сумму, которую хотите положить: ");
                        bool flag1 = double.TryParse(Console.ReadLine(), out double put_money);
                        if (flag1)
                        {
                            bank_1.PutMoney(put_money);
                        }
                        else
                        {
                            Console.WriteLine("Нельзя вводить отрицательные числа, строки и символы");
                        }
                        Console.WriteLine(bank_1[0].Print());
                        break;
                    case 2:
                        Console.Write("Напишите сумму, которую хотите снять: ");
                        bool flag2 = double.TryParse(Console.ReadLine(), out double takeoff_money);
                        if (flag2)
                        {
                            bank_1.TakeoffMoney(takeoff_money);
                        }
                        else
                        {
                            Console.WriteLine("Нельзя вводить отрицательные числа, строки и символы");
                        }
                        Console.WriteLine(bank_1[0].Print());
                        break;
                    case 3:
                        Console.Write("Напишите сумму, которую хотите перевести на другую карту: ");
                        bool flag3 = double.TryParse(Console.ReadLine(), out double money);
                        Console.Write("Напишите номер карты: ");
                        bool flag4 = uint.TryParse(Console.ReadLine(), out uint numb);
                        if (flag3 && flag4)
                        {
                            bank_1.Transfer(money, numb);
                        }
                        else
                        {
                            Console.WriteLine("Нельзя вводить отрицательные числа, строки и символы");
                        }
                        Console.WriteLine(bank_1[0].Print());
                        break;
                    default:
                        Console.WriteLine("Вы не выбрали команду");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Такой команды не существует");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 13.1 и 13.2");
            Console.WriteLine("Создать методы для заполнения и получения значений полей заменить на свойства." + 
                "Создать массив из 10 зданий");
            
            Console.WriteLine();
            Build build = new Build();
            build.Collection(new Creator_Build(1, 2, 3, 4));
            build.Collection(new Creator_Build(2, 3, 4, 5));
            build.Collection(new Creator_Build(3, 4, 5, 6));
            build.Collection(new Creator_Build(4, 5, 6, 7));
            build.Collection(new Creator_Build(5, 6, 7, 8));
            build.Collection(new Creator_Build(6, 7, 8, 9));
            build.Collection(new Creator_Build(7, 8, 9, 10));
            build.Collection(new Creator_Build(8, 9, 10, 11));
            build.Collection(new Creator_Build(9, 10, 11, 12));
            build.Collection(new Creator_Build(10, 11, 12, 13));
            for (int i = 0; i < build.Builds.Length; i++)
            {
                Console.WriteLine($"Номер здания: {build[i].Number}" +
                    $"\nВысота здания: {build[i].Height}" +
                    $"\nКоличество этажей: {build[i].Floor}" +
                    $"\nКоличество квартир: {build[i].Quantity_apart}" +
                    $"\nКоличество подъездов: {build[i].Quantity_entr}");
                Console.WriteLine();
            }
            
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
        }
    }
}
