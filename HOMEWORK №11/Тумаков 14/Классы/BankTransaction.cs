using System;

namespace Тумаков_14
{
    internal class BankTransaction
    {
        public double sum { get; private set; }
        public DateTime date { get; private set; }
        /// <summary>
        /// конструктор для суммы и даты
        /// </summary>
        /// <param name="sum"></param>
        public BankTransaction(double sum)
        {
            this.sum = sum;
            date = DateTime.Now;
        }
        public BankTransaction() { }
        /// <summary>
        /// Возвращает информацию об операции
        /// </summary>
        /// <returns></returns>
        public string Print_data()
        {
            string infor = $"Операция на сумму {sum} произошла в {date}";
            Console.WriteLine($"Операция на сумму {sum} произошла в {date}");
            return infor;
        }
    }
}
