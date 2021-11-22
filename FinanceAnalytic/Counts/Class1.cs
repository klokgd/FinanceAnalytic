using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic.Counts
{
    class Class1 : ICounts
    {
        public decimal Sum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ITransactions> Transaction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddIncrease(Increase increase)
        {
            throw new NotImplementedException();
        }

        public void RenameAccount(string newName)
        {
            throw new NotImplementedException();
        }

        public void TransferBetweenCounts(Increase transferTransaction, ICounts transactionRecepient)
        {
            throw new NotImplementedException();
        }
    }
}
