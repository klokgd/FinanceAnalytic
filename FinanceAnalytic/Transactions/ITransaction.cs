using System;

namespace FinanceAnalytic
{
    public interface ITransaction
    {
        decimal Sum { get; }
        //int Type { get; }
        DateTime Date { get; }
        string Category {get; set; }
        string CountPerson { get; set; }
    }
}
