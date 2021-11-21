using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public interface ICounts //интерфейс для всех счетов
    {
        decimal Sum { get; set; }
        string Name { get; set; }
        public List<ITransactions> Transaction { get; set; }

        void TransferBetweenCounts(Increase transferTransaction, ICounts transactionRecepient);

        void AddIncrease(Increase increase);
        void RenameAccount(string newName);
        

    }

}
