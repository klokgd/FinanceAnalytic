using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    class Credit : ICounts
    {
        public double Sum { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }

        public void TransferBetweenCounts(ITransactions transferTransaction, ICounts transactionRecepient, Category category)
        {
            throw new NotImplementedException();
        }

        public void PayCredit()
        {

        }

        public void RecalculateCredit()
        {

        }

        public void AddIncrease(ITransactions Increase, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
