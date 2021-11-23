using System;
using System.Collections.Generic;
using System.IO;
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
    
    public partial class OperationWindow : Window
    {    
        List<ITransactions> allCounts = new List<ITransactions>();
        string textFromFile = File.ReadAllText("../operation.json");

        public OperationWindow()
        {
            InitializeComponent();
        }
        private void ButtonEnterToOperationMenu_Click(object sender, RoutedEventArgs e)
        {
            OperationWindow window = this;
            window.Show();
            
        }
        private void ButtonEnterToAnalisMenu_Click(object sender, RoutedEventArgs e)
        {
            AnaliseWindow window = new AnaliseWindow();
            window.Show();
            this.Hide();
        }
        private void ButtonEnterToCountMenu_Click(object sender, RoutedEventArgs e)
        {
            CountWindow window = new CountWindow();
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
        private void ButtonEnterToAddTransaction_Click(object sender, RoutedEventArgs e)
        {

            Category category = new Category(CountList.Text);
            if (IncreaseOrExpenseList.Text == "Доход")
            {
                Increase expense = new Increase(Convert.ToDecimal(textBoxSumTransaction.Text), category, (DateTime)datePicker.SelectedDate);
                allCounts.Add(expense);
                listBox.Items.Add($"Сумма: {expense.Sum},  Счет: {CountList.Text},  Дата: {expense.Date.Day}.{expense.Date.Month}.{expense.Date.Year},  Категория: {CategoryList.Text}");

            }
            else
            {
                Expense expense = new Expense(Convert.ToDecimal(textBoxSumTransaction.Text), category, (DateTime)datePicker.SelectedDate);
                allCounts.Add(expense);
                listBox.Items.Add($"Сумма: -{expense.Sum},  Счет: {CountList.Text},  Дата: {expense.Date.Day}.{expense.Date.Month}.{expense.Date.Year},  Категория: {CategoryList.Text}");
            }
            
            IncreaseOrExpenseList.Text = "";
            textBoxSumTransaction.Text = "";
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
