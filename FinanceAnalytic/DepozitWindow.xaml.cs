using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace FinanceAnalytic
{
    /// <summary>
    /// Interaction logic for DepozitWindow.xaml
    /// </summary>
    public partial class DepozitWindow : Window
    {
        private User _user;
        public string FilePath { get; set; }
        public DepozitWindow()
        {
            InitializeComponent();
        }
        public DepozitWindow(User _count)
        {
            InitializeComponent();
            _user = _count;
        }

        private void ButtonEnterToAddTransaction_Click2(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TimeCredit(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonEnterToAddDeposit_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxNameDeposit.Text;
            decimal balance = Convert.ToDecimal(textBoxSumDeposit.Text);
            decimal percent = Convert.ToDecimal(textBoxPercentDeposit.Text);
            int loanTerm = Convert.ToInt32(textBoxTimeDeposit.Text);
            DateTime date = DepozitDatePicker.SelectedDate.Value;

            Credit deposAccount = new Credit(balance, name, loanTerm, percent, date);
            Storage storage = Storage.GetInstance();
            _user.Deposit.Add(deposAccount);
            AccountWindow countWindow = Owner as AccountWindow;
            countWindow.listBoxDeposite.Items.Add(_user.Deposit.Last().Name +" "+_user.Deposit.Last().Balance);
            OperationWindow count = new OperationWindow(_user);
            count.CountList.Items.Add(name);
            storage.SaveToFile();
            Hide();
        }

        private void SumInEndTime(object sender, RoutedEventArgs e)
        {
            double sum = GetIncomeFromDeposit(
                Convert.ToDouble(textBoxSumDeposit.Text),
                Convert.ToInt32(textBoxTimeDeposit.Text),
                Convert.ToInt32(textBoxPercentDeposit.Text)
            );
            textBlockItogSum.Text = String.Format("{0:f2}", sum);
        }

        public double GetIncomeFromDeposit(double sum, int mounth, int persent) 
        {
            double incomeFromDeposit = sum + (sum * persent *mounth*30/(365*100));
            return incomeFromDeposit;
        }

        private void ButtonEnterToOperationMenu_Click(object sender, RoutedEventArgs e)
        {
            OperationWindow window = new OperationWindow(_user);
            window.Show();
            this.Hide();
        }

        private void ButtonEnterToAnalyseMenu_Click(object sender, RoutedEventArgs e)
        {
            AnalyseWindow window = new AnalyseWindow();
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
