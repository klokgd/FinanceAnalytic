using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace FinanceAnalytic
{
    public class PersonalAccount : IAccount
    {
        public string FilePath { get; set; }
        
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
        
        

        public void AddIncrease(Increase increase)
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

        public void RenameAccount(string newName)
        {
            Name = newName;
        }
    }
}
