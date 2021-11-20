using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public class PersonalAccount : ICounts
    {
        public PersonalAccount(decimal sum, string name)
        {
            Sum = sum;
            Name = name;
            Transaction = new List<ITransactions>();
        }

        public string Name { get; set; }
        public int Type { get; set; }
        public decimal Sum { get; set; }
        public List<ITransactions> Transaction { get; set; }
       
        public void AddIncrease(Increase increase, Category category)
        {
            Transaction.Add(increase);
            Sum += increase.Sum;
        }
        public void AddExpense(Expense expense, Category category)
        {
            Transaction.Add(expense);
            Sum -= expense.Sum;
        }

        public void TransferBetweenCounts(Increase transferTransaction, ICounts transactionRecepient, Category category)
        {
            Transaction.Add(transferTransaction);
            Sum -= transferTransaction.Sum;
            transactionRecepient.AddIncrease(transferTransaction, category);
        }

        public void SaveData()
        {

        }

        public void RenameAccount(string newName)
        {
            Name = newName;
        }
    }
}
