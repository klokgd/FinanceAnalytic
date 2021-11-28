using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
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

    public partial class OperationWindow : Window
    {
        List<IAccount> allCounts { get; set; }
        List<ITransactions> allTransaction { get; set; }
        public string FilePath { get; set; }

        public Category category { get; set; }

        private User _workSpace;
        public Account acc;


        public OperationWindow(User authentication)
        {
            InitializeComponent();
            category = new Category();
            acc = new Account();
            _workSpace = authentication;
                        
            for (int i = 1; i < 8; i++)
            {
                CategoryList.Items.Add((Category)i);
                
            } 
            //for (int i = 1; i < 5; i++)
            //{
            //    CountList.Items.Add((Account)i);
                
            //}
            
        }
        private void ButtonEnterToAddTransaction_Click(object sender, RoutedEventArgs e)
        {
            FilePath = "../ooperation.json";
            
            IAccount account  = _workSpace.FindCount(CountList.Text);
            if (account==null)
            {
                _workSpace.AddAccountToList(account);
            }
            allTransaction = account.Transaction;
            if (allCounts ==null)
            {
                allCounts = new List<IAccount>();
            }
            if (!File.Exists(FilePath))
            {
               File.Create(FilePath);
            }
            AddTransaction();

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string jsonToWrite = System.Text.Json.JsonSerializer.Serialize(allTransaction, options);
            File.AppendAllText(FilePath, jsonToWrite);
            
            Storage storage = Storage.GetInstance();
            
            storage.SaveToFile();
            
            IncreaseOrExpenseList.Text = "";
            textBoxSumTransaction.Text = "";
        }
        public void AddTransaction()
        {
            if (allTransaction == null)
            {
                allTransaction = new List<ITransactions>();
            }
            if (IncreaseOrExpenseList.Text == "Доход")
            {
                Increase expense = new Increase(Convert.ToDecimal(textBoxSumTransaction.Text), Convert.ToString(CategoryList.SelectedItem), (DateTime)datePicker.SelectedDate, CountList.Text);
                allTransaction.Add(expense);
                listBox.Items.Add($"Сумма: {expense.Sum},  Дата: {expense.Date.Year}-{expense.Date.Month}-{expense.Date.Day},  Категория: {expense.Category},  Cчет: {expense.CountPerson}");
            }
            else
            {
                Expense expense = new Expense(Convert.ToDecimal(textBoxSumTransaction.Text), Convert.ToString(CategoryList.SelectedItem), (DateTime)datePicker.SelectedDate, CountList.Text);
                allTransaction.Add(expense);
                listBox.Items.Add($"Сумма: -{expense.Sum},  Дата: {expense.Date.Year}-{expense.Date.Month}-{expense.Date.Day},  Категория: {expense.Category},  Cчет: {expense.CountPerson}");
            }
            if (allTransaction == null)
            {
                allTransaction = new List<ITransactions>();
            }
             
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
            CountWindow window = new CountWindow(_workSpace);
            window.Show();
            this.Hide();
        }
        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_SumTransaction(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_IncreaseTransaction(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_CountTransaction(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_CategoryTransaction(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_DateTransaction(object sender, TextChangedEventArgs e)
        {

        }
        void PrintText(object sender, SelectionChangedEventArgs args)
        {

        }
        private void OnMouseLeftButtonUp(object sender, RoutedEventArgs e)
        {

        }
        private void IncreaseOrExpenseList_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            datePicker.IsDropDownOpen = true;
        }
        private void datePicker_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
        private void CategoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
        }
    }
}
