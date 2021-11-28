using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    class DepositAccount : IAccount
    {
        public decimal Balance { get; set; }
        public decimal Percent { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int ActualMonth { get; set; }
        public List<ITransactions> Transaction { get; set; }

        

        public DepositAccount(decimal sum, string name, decimal percent)
        {
            Balance = sum;
            Name = name;
            Percent = percent / 100;
            ActualMonth = DateTime.Now.Month;
            Transaction = new List<ITransactions>();
        }

        public void TransferBetweenCounts(Increase transferTransaction, IAccount transactionRecepient)
        {
            Transaction.Add(transferTransaction);
            Balance -= transferTransaction.Sum;

            transactionRecepient.AddIncrease(transferTransaction);
        }

        

        public void AddIncrease(Increase increase)
        {
            Transaction.Add(increase);
            Balance += increase.Sum;
        }
        
        
        

        

        public void CheckIfBeginningMonth()
        {
            if (ActualMonth != DateTime.Now.Month)
            {
                RecalculateDeposit();
                ActualMonth = DateTime.Now.Month;
            }
           


        }

        public void RecalculateDeposit()
        {
            Balance = Balance * Percent + Balance;
        }

        

        public void RenameAccount(string newName)
        {
            Name = newName;
        }
    }
}
