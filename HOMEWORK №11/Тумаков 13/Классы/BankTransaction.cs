using System;

namespace Тумаков_13
{
    internal class BankTransaction
    {
        private double balance;
        /// <summary>
        /// Метод, который возвращает баланс
        /// </summary>
        public double Balance
        {
            get { return balance; }
        }
        private DateTime time;
        /// <summary>
        /// Метод, который возвращает время
        /// </summary>
        public DateTime Time
        {
            get { return time; }
        }
        /// <summary>
        /// Конструктор для заполнения полей 
        /// </summary>
        /// <param name="balance"></param>
        internal BankTransaction(double balance)
        {
            this.balance = balance;
            time = DateTime.Now;
        }
        /// <summary>
        /// Метод, который возвращает информацию об операции
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"Операция на сумму: {balance} была произведена в {time}";
        }
    }
}
