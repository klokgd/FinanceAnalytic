using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;


namespace FinanceAnalytic
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>y
    public partial class AccountWindow : Window
    {
        private User _user;

        public AccountWindow(User authentication)
        {
            InitializeComponent();
            _user = authentication;



            foreach (PersonalAccount item in _user.Accounts)
            {
                listBoxAccount.Items.Add($"Название: {item.Name}\nСумма: {item.Balance}");
            }
            foreach (Credit item in _user.Credits)
            {
                listBoxCredit.Items.Add($"Название: {item.Name}\nСумма: {item.Balance}");
            }
            foreach (DepositAccount item in _user.Accounts)
            {
                listBoxDeposite.Items.Add($"Название: {item.Name}\nСумма: {item.Balance}");
            }

        }
        private void ButtonEnterToCountMenu_Click(object sender, RoutedEventArgs e)
        {
            AccountWindow window = this;
            window.Show();

        }
        private void ButtonEnterToOperationMenu_Click(object sender, RoutedEventArgs e)
        {
            OperationWindow window = new OperationWindow(_user);
            window.Show();
            this.Hide();
        }
        private void ButtonEnterToAnalisMenu_Click(object sender, RoutedEventArgs e)
        {
            AnalyseWindow window = new AnalyseWindow();
            window.Show();
            this.Hide();
        }


        private void Button_ClickAddCredit(object sender, RoutedEventArgs e)
        {
            CreditWidow credits = new CreditWidow(_user);
            credits.Owner = this;
            credits.Show();
            //this.Hide();
        }
        private void Button_ClickAddDeposit(object sender, RoutedEventArgs e)
        {

        }
        private void Button_ClickAddCount(object sender, RoutedEventArgs e)
        {
            AddAccount credits = new AddAccount(_user);
            credits.Owner = this;
            credits.Show();


        }

        private void listBoxAccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void listBoxCredit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listBoxDeposite_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
