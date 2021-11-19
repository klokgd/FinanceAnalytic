using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public class PersonalCount : ICounts
    {
        public PersonalCount(double v1, string v2,  Expense startCount)
        {
            Sum = v1 + startCount.Sum;
            Name = v2;
            Transaction = new List<ITransactions>();
            Transaction.Add(startCount);
        }

        public string Name { get; set; }
        public int Type { get; set; }
        public double Sum { get; set; }
        public List<ITransactions> Transaction { get; set; }
       
        public void AddIncrease(ITransactions Increase, Category category)
        {
            Transaction.Add(Increase);
            Sum += Increase.Sum;
        }
        public void AddExpense(ITransactions Expense, Category category)
        {
            Transaction.Add(Expense);
            Sum -= Expense.Sum;
        }

        public void TransferBetweenCounts(ITransactions transferTransaction, ICounts transactionRecepient, Category category)
        {
            Transaction.Add(transferTransaction);
            Sum -= transferTransaction.Sum;
            transactionRecepient.AddIncrease(transferTransaction, category);
        }

        public void SaveData()
        {

        }

        
    }
}
