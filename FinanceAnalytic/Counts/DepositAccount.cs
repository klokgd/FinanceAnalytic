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
        public DateTime CurrentDateTime { get; set; }
        public List<ITransactions> Transaction { get; set; }

        

        public DepositAccount(decimal sum, string name, decimal percent, DateTime currentDateTime)
        {
            Sum = sum;
            Name = name;
            Percent = percent / 100;
            CurrentDateTime = currentDateTime;
            Transaction = new List<ITransactions>();
        }

        public void TransferBetweenCounts(Increase transferTransaction, ICounts transactionRecepient, Category category)
        {
            Transaction.Add(transferTransaction);
            Sum -= transferTransaction.Sum;
            transactionRecepient.AddIncrease(transferTransaction, category);
        }

        public void AddPercentForDeposit()
        {

        }

        public void AddIncrease(Increase increase, Category category)
        {
            Transaction.Add(increase);
            Sum += increase.Sum;
        }

        

        public void CheckIfBeginningMonth()
        {
            if (CurrentDateTime.Month != DateTime.Now.Month)
            {
                RecalculateDeposit();
                CurrentDateTime = DateTime.Now;
            }
           


        }

        public void RecalculateDeposit()
        {
            Sum = Sum * Percent + Sum;
        }

        public decimal CalculateDepositThroughPeriod( decimal percent, int amountMonth)
        {
            int estimatedSum = 0;
            return Sum;
        }

        public void RenameAccount(string newName)
        {
            Name = newName;
        }
    }
}
