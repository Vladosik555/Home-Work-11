using System;
using System.Diagnostics;

namespace Тумаков_14
{
    internal class Bank_account
    {
        private readonly uint number = 1;
        private double balance {  get; set; }
        /// <summary>
        /// Конструктор для номера банка
        /// </summary>
        /// <param name="balance"></param>
        public Bank_account(double balance)
        {
            number++;
            if (balance < 0)
            {
                this.balance = 0;
            }
            else
            {
                this.balance = balance;
            }
        }
        /// <summary>
        /// Метод, который позволяет положить деньги на счёт 
        /// </summary>
        /// <param name="money"></param>
        public void Put_Money(double money)
        {
            if(money < 0)
            {
                Console.WriteLine("Вы не можете положить отрицательное значение денег");
            }
            else
            {
                balance += money;
            }
        }
        /// <summary>
        /// Метод, который позволяет снять деньги со счёта 
        /// </summary>
        /// <param name="money"></param>
        public void Withdraw_Money(double money)
        {
            if (money < 0)
            {
                Console.WriteLine("Вы не можете снять отрицательное значение денег");
            }
            else if(money > balance)
            {
                Console.WriteLine("Вы не можете снять сумму, которая превышает ваш баланс");
            }
            else
            {
                balance -= money;
            }
        }
        /// <summary>
        /// Метод, который позволяет перевести деньги на другой счёт
        /// </summary>
        /// <param name="money"></param>
        /// <param name="id"></param>
        public void Transfer(double money, uint id)
        {
            if(balance < money)
            {
                Console.WriteLine("Вы не можете перевести сумму больше вашей");
            }
            else
            {
                Console.WriteLine($"Вы перевели {money} на номер карты {id}");
            }
        }
        /// <summary>
        /// Атрибут, который выводит информацию о счёте по уникальному слову 
        /// </summary>
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"Номер вашего счёта: {number}");
            Console.WriteLine($"Ваш баланс: {balance}");
        }
    }
}
