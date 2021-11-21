using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    class DepositAccount : ICounts
    {
        public decimal Sum { get; set; }
        public decimal Percent { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int ActualMonth { get; set; }
        public List<ITransactions> Transaction { get; set; }

        

        public DepositAccount(decimal sum, string name, decimal percent)
        {
            Sum = sum;
            Name = name;
            Percent = percent / 100;
            ActualMonth = DateTime.Now.Month;
            Transaction = new List<ITransactions>();
        }

        public void TransferBetweenCounts(Increase transferTransaction, ICounts transactionRecepient, Category category)
        {
            Transaction.Add(transferTransaction);
            Sum -= transferTransaction.Sum;

            transactionRecepient.AddIncrease(transferTransaction);
        }

        

        public void AddIncrease(Increase increase)
        {
            Transaction.Add(increase);
            Sum += increase.Sum;
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
            Sum = Sum * Percent + Sum;
        }

        

        public void RenameAccount(string newName)
        {
            Name = newName;
        }
    }
}
