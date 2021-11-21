using System;

namespace FinanceAnalytic
{
    public interface ITransactions
    {
        decimal Sum { get; }
        //int Type { get; }
        DateTime Date { get; }
        string Category {get; set; }
    }
}
