using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public class Increase : ITransaction
    {
        public Increase(decimal sum, string category, DateTime today, string countPerson)
        {
            if (sum < 0)
            {
                throw new ArgumentException("Нельзя вводить отрицательные числа");
            }
            else
            {
                Sum = sum;
            }
            Category = category;
            Date = today;
            CountPerson = countPerson;

        }

        public decimal Sum { get; }
        public DateTime Date { get; }

        public string Category { get; set; }
        public string CountPerson { get; set; }
    }
}
