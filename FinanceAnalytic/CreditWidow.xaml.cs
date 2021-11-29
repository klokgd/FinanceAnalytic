using System;
using System.Linq;
using System.Windows;


namespace FinanceAnalytic
{
    /// <summary>
    /// Interaction logic for CreditWidow.xaml
    /// </summary>
    public partial class CreditWidow : Window
    {
        private User _user;
        public string FilePath { get; set; }

        public CreditWidow(User _count)
        {
            InitializeComponent();
            _user = _count;
        }

        private void ButtonEnterToAddCredit_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxNameCredit.Text;
            decimal balance = Convert.ToDecimal(textBoxSumCredit.Text);
            int loanTerm = Convert.ToInt32(textBoxTimeCredit.Text);
            decimal percent = Convert.ToDecimal(textBoxPercentCredit.Text);
            DateTime date = creditDatePicker.SelectedDate.Value;
            Credit newCredit = new Credit(balance, name, loanTerm, percent, date);
            Storage storage = Storage.GetInstance();
            _user.Credits.Add(newCredit);// AddAccountToList((IAccount)newCredit);
            AccountWindow countWindow = Owner as AccountWindow;
            countWindow.listBoxCredit.Items.Add(_user.Credits.Last().Name +" "+ _user.Credits.Last().Balance);
            OperationWindow count = new OperationWindow(_user);
            count.CountList.Items.Add(name);
            storage.SaveToFile();
            Hide();
        }

        private void Button_ClickAlreadyPay(object sender, RoutedEventArgs e)
        {
            Credit credit = new Credit(Convert.ToDecimal(textBoxSumCredit.Text), textBoxNameCredit.Text, Convert.ToInt32(textBoxTimeCredit.Text), Convert.ToInt32(textBoxPercentCredit.Text), (DateTime)creditDatePicker.SelectedDate);
            TextAlreadyPay.Text = Convert.ToString(credit.CalculatiAlreadyPayMonthsOfLoan());
        }
                
        private void Button_Click_MounthPricePredict(object sender, RoutedEventArgs e)
        {
            Credit credit = new Credit(Convert.ToDecimal(textBoxSumCredit.Text), textBoxNameCredit.Text, Convert.ToInt32(textBoxTimeCredit.Text), Convert.ToDecimal(textBoxPercentCredit.Text), (DateTime)creditDatePicker.SelectedDate);
            textBlockSumOfMonth.Text = String.Format("{0:f2}", credit.PayMonthAnnuityLoan());
        }

        private void Button_Click_PercentPredict(object sender, RoutedEventArgs e)
        {
            Credit credit = new Credit(Convert.ToDecimal(textBoxSumCredit.Text), textBoxNameCredit.Text, Convert.ToInt32(textBoxTimeCredit.Text), Convert.ToDecimal(textBoxPercentCredit.Text), (DateTime)creditDatePicker.SelectedDate);
            textBlockMonthPayPay.Text = String.Format("{0:f2}", credit.CalculateMonthPersent());
            
        }
        private void Button_MounthElse(object sender, RoutedEventArgs e)
        {
            Credit credit = new Credit(Convert.ToDecimal(textBoxSumCredit.Text), textBoxNameCredit.Text, Convert.ToInt32(textBoxTimeCredit.Text), Convert.ToDecimal(textBoxPercentCredit.Text), (DateTime)creditDatePicker.SelectedDate);
            textBlockMounthElse.Text = Convert.ToString(credit.CalculateRemainingMonths());
        }

        private void ButtonEnterToAnalyseMenu_Click(object sender, RoutedEventArgs e)
        {
            AnalyseWindow window = new AnalyseWindow();
            window.Show();
            this.Hide();
        }

        private void ButtonEnterToOperationMenu_Click(object sender, RoutedEventArgs e)
        {
            OperationWindow window = new OperationWindow(_user);
            window.Show();
            this.Hide();
        }
        private void ButtonEnterToCountMenu_Click(object sender, RoutedEventArgs e)
        {
            AccountWindow count = new AccountWindow(_user);
            count.Show();
            
        }
    }
}
