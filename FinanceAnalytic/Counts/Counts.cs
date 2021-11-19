using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public interface ICounts //интерфейс для всех счетов
    {
        double Sum { get; set; }
        string Name { get; set; }
        void TransferBetweenCounts(ITransactions transferTransaction, ICounts transactionRecepient, Category category);

        void AddIncrease(ITransactions Increase, Category category);
        

    }

}
