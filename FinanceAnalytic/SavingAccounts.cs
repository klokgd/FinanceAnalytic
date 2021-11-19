using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    class SavingAccounts : Counts
    {
        public double Sum { get ; set  ; }
        public string Name { get ; set ; }
        public List<Transactions> Transaction { get; set; }

        public SavingAccounts(double v1, string v2, Expense startCount)
        {
            Sum = v1 + startCount.Sum;
            Name = v2;
            Transaction = new List<Transactions>();
            Transaction.Add(startCount);
        }

        public void TransferBetweenCounts()
        {
            
        }

        public void IncreaseToSum(Transactions IncreaseOrExpense)
        {
            //Transaction.Add()
            Transaction.Add(IncreaseOrExpense);
            Sum += IncreaseOrExpense.Sum;
        }

        public void ExpenseToSum(Transactions IncreaseOrExpense)
        {
            //Transaction.Add()
            Transaction.Add(IncreaseOrExpense);
            Sum -= IncreaseOrExpense.Sum;
            //DateTime.DaysInMonth;
        }

        private decimal InterestRateInput(decimal val)
        {

            decimal persentDay = 0;
            if (DateTime.IsLeapYear(DateTime.Now.Year))
            {
                persentDay = val / 366; // Високосный
            }
            else
            {
                persentDay = val / 365; // Не високосный
            }

            return persentDay;

        }


        private double AddAccruedInterest(double sum)
        {
            //int t= DateTime.
            
            return sum;
        }
    }
}
