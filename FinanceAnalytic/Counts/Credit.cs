using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public class Credit : IAccount
    {
        public decimal Balance { get; set; }
        public string Name { get; set; }
        public int LoanTerm { get; set; }
        public int ActualMonth { get; set; }
        public decimal Persent { get; set; }
        public DateTime ActualData { get; set; }

        public Credit(decimal sum, string name, int loanTerm, decimal persent, DateTime actualData)
        {
            Balance = sum;
            Name = name;
            LoanTerm = loanTerm;
            Persent = persent;
            Transaction = new List<ITransaction>();

            ActualData = actualData;
        }

        public List<ITransaction> Transaction { get; set; }


        public decimal CalculateBalanceOfLoan(decimal sum, List<ITransaction> Transaction)
        {

            decimal sumTransactuon = 0;
            int i = 0;

            foreach (var item in Transaction)
            {
                sumTransactuon += Transaction[i].Sum;// надо проссумировать все поступления на счет кредита
                i++;
            }
            decimal remainingAmount = sum - sumTransactuon; // остаток суммы кредита

            return remainingAmount;
        }

        public decimal CalculateMonthPersent() //расчет ежемесячной процентной ставки, в зависимости от выбранноых годовых %
        {
            decimal persentMonth = Persent / 1200;
            return persentMonth;

        }
        //  метод расчета сколько уже месяцев платим кредит
        public int CalculatiAlreadyPayMonthsOfLoan()
        {
            int alreadyPayMonths = 0;
            if (DateTime.Now < ActualData)
            {
                return 0;
            }
            DateTime d2 = ActualData.Date;
            alreadyPayMonths = (d2.Year - DateTime.Now.Year) * 12;
            alreadyPayMonths = alreadyPayMonths + d2.Month;
            alreadyPayMonths = alreadyPayMonths - DateTime.Now.Month;
            if (alreadyPayMonths < 0)
            {
                alreadyPayMonths = Math.Abs(alreadyPayMonths);
            }
            return alreadyPayMonths;
        }
        public int CalculateRemainingMonths() //расчет сколько месяцев надо платить еще
        {
            int alreadyPayMonths = CalculatiAlreadyPayMonthsOfLoan();
            int remainingMonths = 0;
            if (alreadyPayMonths == 0)
            {
                remainingMonths = LoanTerm;

            }
            else
            {
                remainingMonths = LoanTerm - alreadyPayMonths;
            }

            return remainingMonths;
        }
        public decimal PayMonthAnnuityLoan()
        {
            Transaction = new List<ITransaction>();
            decimal payOver = CalculateBalanceOfLoan(Balance, Transaction);
            int rMonth = CalculateRemainingMonths();
            decimal persentMonth = CalculateMonthPersent();
            decimal Annuitypay = 0; //размер ежемес платежа в аннуительном кредите
            decimal val = Convert.ToDecimal(1 / Math.Pow((1 + (double)persentMonth), rMonth));
            Annuitypay = payOver * (persentMonth / (1 - val));

            return Annuitypay;
        }


        public void AddExpense(ITransaction expense)
        {
            Transaction.Add(expense);
            Balance -= expense.Sum;
        }
        public void AddIncrease(ITransaction increase)
        {
            Transaction.Add(increase);
            Balance += increase.Sum;
        }

        public void TransferBetweenCounts(Increase transferTransaction, IAccount transactionRecepient)
        {
            Transaction.Add(transferTransaction);
            Balance -= transferTransaction.Sum;
            transactionRecepient.AddIncrease(transferTransaction);
        }

        public void RenameAccount(string newName)
        {
            Name = newName;
        }
    }
}
