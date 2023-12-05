using System;
using System.Collections.Generic;

namespace Тумаков_13
{
    enum BankType
    {
        текущий,
        сберегательный
    }
    internal class Bank_account
    {
        private uint number;
        /// <summary>
        /// Метод, который возвращает уникальный номер
        /// </summary>
        public uint Number
        {
            get { return number; }
        }
        private BankType type;
        /// <summary>
        /// Метод, который возвращает типа банковского счёта
        /// </summary>
        public BankType Type
        {
            get { return type; }
        }
        private double balance;
        /// <summary>
        /// Метод, который возвращает баланс
        /// </summary>
        public double Balance
        {
            get { return balance; }
        }
        private string person_holder;
        /// <summary>
        /// Метод, который записывает и возвращает держателя карты
        /// </summary>
        public string PersonHolder
        {
            set { person_holder = value; }
            get { return person_holder; }
        }
        List<BankTransaction> transactions = new List<BankTransaction>();
        /// <summary>
        /// Метод, который записывает и возвращает банковские операции
        /// </summary>
        public List<BankTransaction> Transactions
        {
            set {  transactions = value; }
            get {return transactions;}
        }
        /// <summary>
        /// Метод, который возвращает операцию по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public BankTransaction this[int index]
        {
            get
            {
                return transactions[index];
            }
        }
        /// <summary>
        /// Конструктор для заполнение полей банковского счёта
        /// </summary>
        /// <param name="number"></param>
        /// <param name="type"></param>
        /// <param name="balance"></param>
        /// <param name="person_holder"></param>
        public Bank_account(uint number, BankType type, double balance, string person_holder)
        {
            this.number = number;
            this.type = type;
            this.balance = balance;
            this.person_holder = person_holder;
            GeneratNumn();
        }
        /// <summary>
        /// Конструктор для заполнения полей банковского счёта
        /// </summary>
        /// <param name="number"></param>
        /// <param name="type"></param>
        /// <param name="balance"></param>
        public Bank_account(uint number, BankType type, double balance)
        {
            this.number = number;
            this.type = type;
            this.balance = balance;
            person_holder = "Неизвестно";
        }
        /// <summary>
        /// Метод, который генерирует уникальный номер карты 
        /// </summary>
        private void GeneratNumn()
        {
            number++;
        }
        /// <summary>
        /// Метод, который позволяет положить деньги на счёт
        /// </summary>
        /// <param name="put_money"></param>
        public void PutMoney(double put_money)
        {
            BankTransaction transaction = new BankTransaction(put_money);
            transactions.Add(transaction);
            balance += put_money;
            Console.WriteLine($"Ваш баланс составляет {balance} рублей");
        }
        /// <summary>
        /// метод, который позволяет снять деньги со счёта
        /// </summary>
        /// <param name="takeoff_money"></param>
        public void TakeoffMoney(double takeoff_money)
        {
            if (takeoff_money <= balance)
            {
                BankTransaction transaction = new BankTransaction(takeoff_money);
                transactions.Add(transaction);
                balance -= takeoff_money;
                Console.WriteLine($"Ваш баланс составляет {balance} рублей");
            }
            else
            {
                Console.WriteLine("Вы не можете снять сумму, которая превышает ваш баланс");
            }
        }
        /// <summary>
        /// метод, который позволяет перевести деньги на другую карту
        /// </summary>
        /// <param name="money"></param>
        /// <param name="numb"></param>
        public void Transfer(double money, uint numb)
        {
            if (money <= balance)
            {
                BankTransaction transaction = new BankTransaction(money);
                transactions.Add(transaction);
                balance -= money;
                Console.WriteLine($"{person_holder} перевел(a) {money} рублей на номер карты {numb}, ваш счёт составляет {balance} рублей");
            }
            else
            {
                Console.WriteLine("Вы не можете перевести сумму, которая превышает ваш баланс");
            }
        }
        /// <summary>
        /// Метод, который выводить информацию об банковском счёте
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Ваш номер: {number}\nВаш тип банковского счёта: {type}\nВаш баланс составляет: {balance}\nдержатель карты: {person_holder}");
        }
    }
}
