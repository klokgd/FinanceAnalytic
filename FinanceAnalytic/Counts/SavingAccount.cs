using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    class SavingAccount : ICounts
    {
        public decimal Sum { get ; set  ; }
        public string Name { get ; set ; }
        public List<ITransactions> Transaction { get; set; }
        public int ActualMonth { get; set; }

        public SavingAccount(decimal sum, string name)
        {
            Sum = sum;
            Name = name;
            ActualMonth = DateTime.Now.Month;
            Transaction = new List<ITransactions>();
        }

       public void AddIncrease(Increase increase, Category category)
        {
            Transaction.Add(increase);
            Sum += increase.Sum;
        }


        public void TransferBetweenCounts(Increase transferTransaction, ICounts transactionRecepient, Category category)
        {
            Transaction.Add(transferTransaction);
            Sum -= transferTransaction.Sum;
            transactionRecepient.AddIncrease(transferTransaction, category);
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
