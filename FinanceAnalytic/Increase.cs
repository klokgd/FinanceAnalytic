using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    class Increase : Transactions
    {
        public int Type { get ; set ; }
        public DateTime Date { get ; set ; }
        public Category Category { get ; set ; }

        double Transactions.Sum => throw new NotImplementedException();
    }
}
