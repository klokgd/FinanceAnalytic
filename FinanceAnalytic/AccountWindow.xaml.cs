using System.Windows;



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

            foreach (Credit item in _user.Deposit)
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
            DepozitWindow depozit = new DepozitWindow(_user);
            depozit.Owner = this;
            depozit.Show();
        }
        private void Button_ClickAddCount(object sender, RoutedEventArgs e)
        {
            AddAccount credits = new AddAccount(_user);
            credits.Owner = this;
            credits.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Owner = this;
            main.Show();
            this.Hide();
        }
    }
}
