using System;
using System.Collections.Generic;
using System.Windows;


namespace FinanceAnalytic
{

    public partial class OperationWindow : Window
    {
        List<ITransaction> allTransaction { get; set; }
        private User _user;

        public OperationWindow(User authentication)
        {
            InitializeComponent();
            _user = authentication;

            if (_user.Categories.Count > 0)
            {
                foreach (var item in _user.Categories)
                {
                    CategoryList.Items.Add(item.Name);
                }
            }


            foreach (var item in _user.Accounts)
            {
                CountList.Items.Add(item.Name);
            }
            foreach (var item in _user.Credits)
            {
                CountList.Items.Add(item.Name);
            }
            foreach (var item in _user.Deposit)
            {
                CountList.Items.Add(item.Name);
            }
        }

        private void ButtonEnterToAddTransaction_Click(object sender, RoutedEventArgs e)
        {
            IAccount account = _user.FindAccount(CountList.Text);
            Credit credit = _user.FindCredit(CountList.Text);
            Credit deposit = _user.FindDeposit(CountList.Text);
            if (account == null && credit == null && deposit ==null )
            {
                MessageBox.Show("Сначала создайте счёт!");
            }
            else if (account != null )
            {
                AddTransaction(account);
            }
            else if (credit !=null)
            {
                AddTransaction(credit);
            }
            else
            {
                AddTransaction(deposit);
            }
           
            Storage storage = Storage.GetInstance();
            storage.SaveToFile();

            IncreaseOrExpenseList.Text = "";
            textBoxSumTransaction.Text = "";

        }

        public void AddTransaction(IAccount account)
        {
            if (account is PersonalAccount)
            {
                PersonalAccount personalAccount = (PersonalAccount)account;
                if (IncreaseOrExpenseList.Text == "Доход")
                {
                    SendIncrease(personalAccount);                   

                }
                else
                {
                    SendExpense(personalAccount);                

                }
            }
            else if (account is DepositAccount)
            {
                DepositAccount depositAccount = (DepositAccount)account;

                if (IncreaseOrExpenseList.Text == "Доход")
                {
                    SendIncrease(depositAccount);
                }
                else
                {
                    MessageBox.Show("В \"Депозит\" нельзя записывать расходы!");
                }
            }
            else if (account is Credit)
            {
                Credit credit = (Credit)account;
                if (IncreaseOrExpenseList.Text == "Доход")
                {
                    SendIncrease(credit);
                }                
            }
        }

        public void SendIncrease(IAccount account)
        {
            Increase increase = new Increase(Convert.ToDecimal(textBoxSumTransaction.Text), Convert.ToString(CategoryList.SelectedItem), (DateTime)datePicker.SelectedDate, CountList.Text);
            account.AddIncrease(increase);
            listBox.Items.Add($"Сумма: {increase.Sum},  Дата: {increase.Date.Year}-{increase.Date.Month}-{increase.Date.Day},  Категория: {increase.Category},  Cчет: {increase.CountPerson}");
        }

        public void SendExpense(PersonalAccount account)
        {
            Expense expense = new Expense(Convert.ToDecimal(textBoxSumTransaction.Text), Convert.ToString(CategoryList.SelectedItem), (DateTime)datePicker.SelectedDate, CountList.Text);
            account.AddExpense(expense);
            listBox.Items.Add($"Сумма: -{expense.Sum},  Дата: {expense.Date.Year}-{expense.Date.Month}-{expense.Date.Day},  Категория: {expense.Category},  Cчет: {expense.CountPerson}");
        }
        public void SendExpense(SavingAccount account)
        {
            Expense expense = new Expense(Convert.ToDecimal(textBoxSumTransaction.Text), Convert.ToString(CategoryList.SelectedItem), (DateTime)datePicker.SelectedDate, CountList.Text);
            account.AddExpense(expense);
            listBox.Items.Add($"Сумма: -{expense.Sum},  Дата: {expense.Date.Year}-{expense.Date.Month}-{expense.Date.Day},  Категория: {expense.Category},  Cчет: {expense.CountPerson}");
        }        

        private void AddCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            Category category = new Category(CategoryNameTextBox.Text);
            _user.AddCategoryToList(category);
            CategoryList.Items.Add(category.Name);

            Storage storage = Storage.GetInstance();
            storage.SaveToFile();
            MessageBox.Show("Категория добавлена!");
        }

        private void ButtonEnterToOperationMenu_Click(object sender, RoutedEventArgs e)
        {
            OperationWindow window = this;
            window.Show();
        }
        private void ButtonEnterToAnalyseMenu_Click(object sender, RoutedEventArgs e)
        {
            AnalyseWindow window = new AnalyseWindow();
            window.Show();
            this.Hide();
        }

        private void ButtonEnterToCountMenu_Click(object sender, RoutedEventArgs e)
        {
            AccountWindow window = new AccountWindow(_user);
            window.Show();
            this.Hide();
        }
    }
}
