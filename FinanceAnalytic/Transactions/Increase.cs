using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    class Increase : ITransactions
    {
        public Increase(double sum, Category category, DateTime today)
        {
            Sum = sum;
            Category = category.Name;
            Date = today;
        }

        public double Sum { get; }
        public DateTime Date { get; }

        public string Category { get; set; }
    }
}
