using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public class PersonalCount : Counts
    {
        public PersonalCount(double v1, string v2,  Expense startCount)
        {
            Sum = v1 + startCount.Sum;
            Name = v2;
            Transaction = new List<Transactions>();
            Transaction.Add(startCount);               
        }

        public string Name { get; set; }
        public int Type { get; set; }
        public double Sum { get; set; }
        public List<Transactions> Transaction { get; set; }
       
        public void AddTransaction(Transactions IncreaseOrExpense)
        {
            //Transaction.Add()
            Transaction.Add(IncreaseOrExpense);
            Sum += IncreaseOrExpense.Sum;
        }

        public void TransferBetweenCounts()
        {
            throw new NotImplementedException();
        }


    }
}
