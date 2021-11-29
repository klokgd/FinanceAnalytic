using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinanceAnalytic
{
    /// <summary>
    /// Interaction logic for AddAccount.xaml
    /// </summary>
    public partial class AddAccount : Window
    {
        private User _user;
        public AddAccount(User authentication)
        {
            InitializeComponent();
            _user = authentication;
        }
        private void button_AddAccount_Click(object sender, RoutedEventArgs e)
        {
            string name = TextBoxAccounName.Text;
            decimal balance = Convert.ToDecimal( TextBoxSumAccount.Text);
            PersonalAccount personalAccount = new PersonalAccount(balance, name);

            Storage storage = Storage.GetInstance();
            _user.AddAccountToList(personalAccount);
            AccountWindow countWindow = Owner as AccountWindow;
            countWindow.listBoxAccount.Items.Add($"Название: {_user.Accounts.Last().Name}\nСумма: {balance}");
            OperationWindow count = new OperationWindow(_user);
            count.CountList.Items.Add(name);
            storage.SaveToFile();
            Hide();
        }
    }
}
