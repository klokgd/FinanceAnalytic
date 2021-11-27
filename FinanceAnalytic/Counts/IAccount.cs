using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public interface IAccount //интерфейс для всех счетов
    {
        decimal Balance { get; set; }
        string Name { get; set; }
        public List<ITransactions> Transaction { get; set; }

        void TransferBetweenCounts(Increase transferTransaction, IAccount transactionRecepient );

        void AddIncrease(Increase increase);
        //void AddExpense(Expense expense);
        void RenameAccount(string newName);
        

    }

}
