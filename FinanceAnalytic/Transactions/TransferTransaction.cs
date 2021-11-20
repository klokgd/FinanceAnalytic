using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    class TransferTransaction : ITransactions
    {
        public TransferTransaction(decimal sum, Category category, DateTime today)
        {
            Sum = sum;
            Category = category.Name;
            Date = today;
        }

        public decimal Sum { get; }
        public DateTime Date { get; }

        public string Category { get; set; }
    }
}
