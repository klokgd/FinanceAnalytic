using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    class TransferTransaction : ITransactions
    {
        public TransferTransaction(decimal sum, Category category, DateTime today, string countPerson)
        {
            Sum = sum;
            Category = category.Name;
            Date = today;
            CountPerson = countPerson;
        }

        public decimal Sum { get; }
        public DateTime Date { get; }

        public string Category { get; set; }
        public string CountPerson { get; set; }
    }
}
