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
    
    public partial class Win : Window
    {
    
        List<PersonalAccount> allCounts = new List<PersonalAccount>();


        public Win()
        {
            InitializeComponent();

            //SumCount.Text = Convert.ToString($"100000");
        }

        //private void buttonBIG_Click(object sender, RoutedEventArgs e)
        //{
        //    MainWindow taskWindow = new MainWindow();
        //    taskWindow.Show();
        //}

        private void SumNewCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(SumNewCount.Text, "[^0-9,]"))
            //{
            //    MessageBox.Show("Пожалуйста, вводите только числа");
            //    SumNewCount.Text = SumNewCount.Text.Remove(SumNewCount.Text.Length - 1);
            //}
        }

        public void addListCount(PersonalAccount count)
        {
            //allCounts.Add(count);
        }

        public void DisplayCountsInTextBox()
        {
            //int index = 0;
            //foreach (var item in allCounts)
            //{
            //    index++;
            //    textBlock2.Text += $" {index} Счёт: {item.Name} Денег: {item.Sum} \n";
            //}
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
        //    Expense startCount = new Expense(Convert.ToDouble(SumCount.Text), 0, DateTime.Today);
        //    PersonalAccount goodTime = new PersonalAccount(Convert.ToDouble(SumNewCount.Text), NameNewCount.Text, startCount);
        //    double sum = Convert.ToDouble(SumCount.Text) + Convert.ToDouble(SumNewCount.Text);
        //    addListCount(goodTime);
        //    DisplayCountsInTextBox();
        //    SumCount.Text = $"{sum}";
        }


        private void NameNewCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            //SumNewCount.Text = SumNewCount.Text;
        }

        private void ButtonEnterToOperationMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEnterToAnalisMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEnterToCountMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_SumTransaction(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_IncreaseTransaction(object sender, TextChangedEventArgs e)
        {
            if (textBoxIncreaseTransaction.Text == "доход" || textBoxIncreaseTransaction.Text == "Доход" || textBoxIncreaseTransaction.Text == "ДОХОД" )
            {
                Category category = new Category(CountList.Text);
                
                Increase expense = new Increase(Convert.ToDecimal(textBoxSumTransaction), category , DateTime.Today);
                PersonalAccount goodTime = new PersonalAccount(200, "zhopa");
                goodTime.AddIncrease(expense);
            }
        }

        private void TextBox_CountTransaction(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_DateTransaction(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonEnterToAddTransaction_Click(object sender, RoutedEventArgs e)
        {

        }
        private void OnMouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            datePicker.IsDropDownOpen = true;
        }

        private void datePicker_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
