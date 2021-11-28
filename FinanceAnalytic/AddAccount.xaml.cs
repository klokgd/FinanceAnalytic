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

namespace FinanceAnalytic
{
    /// <summary>
    /// Interaction logic for AddAccount.xaml
    /// </summary>
    public partial class AddAccount : Window
    {
        private User _workSpace;
        public AddAccount()
        {
            InitializeComponent();
        }
        private void button_AddAccount_Click(object sender, RoutedEventArgs e)
        {

            string name = TextBoxAccounName.Text;
            decimal balance = Convert.ToDecimal( TextBoxSumAccount.Text);
            //PersonalAccount ps = new PersonalAccount(balance, name);
            Storage storage = Storage.GetInstance();
            
            storage.AddAccount(balance,name);
            CountWindow countWindow = Owner as CountWindow;

            countWindow.listBoxCount.Items.Add(storage.accountList);
            //mainWindow.ListBoxListOfUsers.Items.Add(storage.usersList.Last().Name);
            OperationWindow count = new OperationWindow(_workSpace);
            count.CountList.Items.Add(name);
            Hide();
        }
    }
}
