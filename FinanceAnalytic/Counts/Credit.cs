using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public class Credit
    {
        public double Sum { get; set; }
        public string Name { get; set; }
        public int LoanTerm { get; set; }
        public int ActualMonth { get; set; }

        public Credit (double sum, string name, int loanTerm)
        {
            Sum = sum;
            Name = name;
            LoanTerm = loanTerm;
            ActualMonth = DateTime.Now.Month;
        }

        public List<ITransactions> Transaction { get; set; }

        //как указать с какого актива будет списан кредит

       
        int loanTerm = 0;//это переменная, которую введет пользователь -срок кредита в месяцах, надо метод написать
        decimal sumnewcredit = 0; //переменная в которую попадет сумма нового кредита
        decimal persent = 0; //переменная с выбранным годовым процентом, написать метод для ввода числа извне
        //TODO ЗАПИСЬ ДАТ ВСЕХ ДОБАВЛЕНИЙ ДЕНЕГ
        
       
       
        
        private decimal CalculateBalanceOfLoan(decimal sumnewcredit, List<ITransactions> Transaction)
        {
            decimal sumTransactuon = 0;
            int i = 0;
            
            foreach (var item in Transaction)
            {
            sumTransactuon += Transaction[i].Sum;// надо проссумировать все поступления на счет кредита
                i++;
            }
            decimal remainingAmount = sumnewcredit- sumTransactuon; // остаток суммы кредита
           
            return remainingAmount;
        }

        public decimal CalculateMonthPersent(decimal persent) //расчет ежемесячной процентной ставки, в зависимости от выбранноых годовых %
        {
            decimal persentMonth = persent/1200;
            return persentMonth;

        }
        // нужен метод расчета сколько уже месяцев платим кредит

        private int CalculateRemainingMonths(int month) //расчет сколько месяцев надо платить еще
        {
            int remainingMonths = 0;
            if (month== loanTerm)
            {
                remainingMonths = month;

            }
            else
            {
                remainingMonths = loanTerm - month;
            }

            return remainingMonths;
        }
        public decimal PayMonthAnnuityLoan(decimal remainingAmount, decimal persentMonth, int remainingMonths)
        {
            decimal Annuitypay = 0; //размер ежемес платежа в аннуительном кредите
            decimal val = Convert.ToDecimal(1 / Math.Pow((1 + (double)persentMonth), remainingMonths)); 
            Annuitypay = remainingAmount * (persentMonth / (1-(1+ persentMonth))); 

            return Annuitypay;
        }

        private void endCredit(decimal sumnewcredit, decimal sumTransactuon)
        {
           if  (sumnewcredit== sumTransactuon)
            {
                //поздравить с выплаченным кредитом и удалить запись о кредите
            }
        }
            
    }
}
