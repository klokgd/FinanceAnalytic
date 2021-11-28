using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public class SavingAccount : IAccount
    {
        public decimal Balance { get ; set  ; }
        public string Name { get ; set ; }
        public List<ITransaction> Transaction { get; set; }
        public int ActualMonth { get; set; }

        public SavingAccount(decimal sum, string name)
        {
            Balance = sum;
            Name = name;
            ActualMonth = DateTime.Now.Month;
            Transaction = new List<ITransaction>();
        }

       public void AddIncrease(ITransaction increase)
        {
            Transaction.Add(increase);
            Balance += increase.Sum;
        }
        public void AddExpense(ITransaction increase)
        {
            Transaction.Add(increase);
            Balance -= increase.Sum;
        }


        public void TransferBetweenCounts(Increase transferTransaction, IAccount transactionRecepient)
        {
            Transaction.Add(transferTransaction);
            Balance -= transferTransaction.Sum;
            transactionRecepient.AddIncrease(transferTransaction);
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
            //Sum = Sum * Percent + Sum;
        }



        public void RenameAccount(string newName)
        {
            Name = newName;
        }
    }
}
