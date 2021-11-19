using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public interface ITransactions
    {
        double Sum { get; }
        //int Type { get; }
        DateTime Date { get; }
        string Category {get; set; }
    }
}
