using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    class Deposit : ICounts
    {
        public double Sum { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }

        public void TransferBetweenCounts(ITransactions transferTransaction, ICounts transactionRecepient)
        {
            throw new NotImplementedException();
        }

        public void AddPercentForDeposit()
        {

        }

        public void AddIncrease(ITransactions Increase, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
