using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public class Expense : Transactions
    {
        public Expense(double v1, int v2, DateTime today)
        {
            Sum = v1;
            Type = v2;
            Date = today;
        }

        public double Sum { get; }
        public int Type { get ; }
        public DateTime Date { get ; }
      
        //public Category Category { get ; set ; }
    }
}
