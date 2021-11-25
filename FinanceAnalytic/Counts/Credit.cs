using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public class Credit
    {
         public decimal Sum { get; set; }
        public string Name { get; set; }
        public int LoanTerm { get; set; }
        public int ActualMonth { get; set; }
        public decimal Persent { get; set; }
        public DateTime ActualData { get; set; }

        public Credit(decimal sum, string name, int loanTerm, decimal persent, DateTime actualData)
        {
            Sum = sum;
            Name = name;
            LoanTerm = loanTerm;
            Persent = persent;

            
            ActualData = actualData;
        }

        public List<ITransactions> Transaction { get; set; }

        //как указать с какого актива будет списан кредит


        //int loanTerm = 0;//это переменная, которую введет пользователь -срок кредита в месяцах
        //decimal sumnewcredit = 0; //переменная в которую попадет сумма нового кредита
        //decimal persent = 0; //переменная с выбранным годовым процентом, написать метод для ввода числа извне
        //                     //TODO ЗАПИСЬ ДАТ ВСЕХ ДОБАВЛЕНИЙ ДЕНЕГ




        public decimal CalculateBalanceOfLoan(decimal sum, List<ITransactions> Transaction)
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
        public int CalculatiAlreadyPayMonthsOfLoan(DateTime ActualData)
        {
            int alreadyPayMonths = 0;

            DateTime d2 = DateTime.Now;


            alreadyPayMonths = (ActualData.Year - d2.Year) * 12;
            alreadyPayMonths = alreadyPayMonths + d2.Month;
            alreadyPayMonths = alreadyPayMonths - ActualData.Month;

            return alreadyPayMonths;
        }
        public int CalculateRemainingMonths() //расчет сколько месяцев надо платить еще
        {
            int alreadyPayMonths = CalculatiAlreadyPayMonthsOfLoan(DateTime.Now);
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
        public decimal PayMonthAnnuityLoan( )
        {
            Transaction = new List<ITransactions>();
            decimal payOver = CalculateBalanceOfLoan(Sum, Transaction);
            int rMonth = CalculateRemainingMonths();
            decimal persentMonth = CalculateMonthPersent();
            decimal Annuitypay = 0; //размер ежемес платежа в аннуительном кредите
            decimal val = Convert.ToDecimal(1 / Math.Pow((1 + (double)persentMonth), rMonth));
            Annuitypay = payOver * (persentMonth / (1 -  val));

            return Annuitypay;
        }

        private void endCredit(decimal sumnewcredit, decimal sumTransactuon)
        {
            if (sumnewcredit == sumTransactuon)
            {
                //поздравить с выплаченным кредитом и удалить запись о кредите
            }
        }
            
    }
}
