using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public class PersonalAccount : IAccount
    {
        public PersonalAccount(decimal sum, string name)
        {
            Balance = sum;
            Name = name;
            Transaction = new List<ITransactions>();
            
        }

        public string Name { get; set; }
        public int Type { get; set; }
        public decimal Balance { get; set; }
        public List<ITransactions> Transaction { get; set; }
       
        public void AddIncrease(ITransactions increase)
        {
            Transaction.Add(increase);
            Balance += increase.Sum;
        }
        public void AddExpense(ITransactions expense)
        {
            Transaction.Add(expense);
            Balance -= expense.Sum;
        }

        public void TransferBetweenCounts(Increase transferTransaction, IAccount transactionRecepient)
        {
            Transaction.Add(transferTransaction);
            Balance -= transferTransaction.Sum;
            transactionRecepient.AddIncrease(transferTransaction);
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
