using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public interface Transactions
    {
        double Sum { get; }
        //int Type { get; }
        DateTime Date { get; }
        Category Category {get; set; }
    }
}
