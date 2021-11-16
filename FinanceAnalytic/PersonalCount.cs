using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    class PersonalCount : Counts
    {
        public PersonalCount(double v1, string v2, int v3, Expense startCount)
        {
            Sum = v1;
            Name = v2;
            Type = v3;
            Transaction = startCount;
        }

        public double Sum { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public List<Transactions> Transaction { get; set; }
       
        public void AddTransaction(Transactions IncreaseOrExpense)
        {
            Transaction.Add(IncreaseOrExpense);
            Sum += IncreaseOrExpense.Sum;
        }

        public void TransferBetweenCounts()
        {
            throw new NotImplementedException();
        }


    }
}
