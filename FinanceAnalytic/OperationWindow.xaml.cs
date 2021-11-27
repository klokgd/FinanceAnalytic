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
        //public string FilePath { get; set; } = "";
        public string FilePath { get; set; }

        public Category category { get; set; }

        private User _workSpace;

        public OperationWindow(User authentication)
        {
            InitializeComponent();
            category = new Category(CategoryList.Text);
            _workSpace = authentication;
            FilePath = "../operation.json";
            string[] readFromFile = File.ReadAllLines(FilePath);
            for (int i = 2; i < readFromFile.Length - 1; i += 7)
            {
                string sum = readFromFile[i].Remove(0, 10);
                string date = readFromFile[i + 1].Remove(0, 13);
                string category = readFromFile[i + 2].Remove(0, 17);
                string count = readFromFile[i + 3].Remove(0, 18);
                date = date.Replace("T00:00:00\"", "");
                category = category.Replace("\"", "");
                count = count.Replace("\"", "");
                listBox.Items.Add($"Сумма:{sum}  Дата: {date}  Категория: {category}  Счет: {count} ");
            }
        }
        private void ButtonEnterToAddTransaction_Click(object sender, RoutedEventArgs e)
        {
            FilePath = "../operation.json";
            allTransaction = new List<ITransactions>(allTransaction);
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }
            string readFromFile = File.ReadAllText(FilePath);
            //string filePathOfCount = "";
            List<ITransactions> lst = JsonSerializer.Deserialize<List<ITransactions>>(readFromFile);
            if (IncreaseOrExpenseList.Text == "Доход")
            {
                Increase expense = new Increase(
                    Convert.ToDecimal(textBoxSumTransaction.Text),
                    category, 
                    (DateTime)datePicker.SelectedDate, 
                    CountList.Text
                );
                allTransaction.Add(expense);
                listBox.Items.Add(
                    $"Сумма: {expense.Sum},  " +
                    $"Дата: {expense.Date.Year}-{expense.Date.Month}-{expense.Date.Day},  " +
                    $"Категория: {expense.Category},  " +
                    $"Cчет: {expense.CountPerson}");
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };

                string jsonToWrite = System.Text.Json.JsonSerializer.Serialize(allCounts, options);
                File.AppendAllText(FilePath, jsonToWrite);
                //File.AppendAllText(filePathOfCount, jsonToWrite);

                Storage storage = Storage.GetInstance();
                _workSpace.AddCount(new PersonalAccount(34, "rt"));
                IAccount cn = _workSpace.FindCount("jjjj");
                _workSpace.Accounts.Add(cn);
                storage.SaveToFile();
            }
            else
            {
                Expense expense = new Expense(Convert.ToDecimal(textBoxSumTransaction.Text), category, (DateTime)datePicker.SelectedDate, CountList.Text);
                allTransaction.Add(expense);
                listBox.Items.Add($"Сумма: -{expense.Sum},  Дата: {expense.Date.Year}-{expense.Date.Month}-{expense.Date.Day},  Категория: {expense.Category},  Cчет: {expense.CountPerson}");
            }

            IncreaseOrExpenseList.Text = "";
            textBoxSumTransaction.Text = "";
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
