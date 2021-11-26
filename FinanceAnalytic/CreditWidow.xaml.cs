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
    /// Interaction logic for CreditWidow.xaml
    /// </summary>
    public partial class CreditWidow : Window
    {
        public CreditWidow()
        {
            InitializeComponent();
        }

        private void ButtonEnterToOperationMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEnterToAnalyseMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEnterToCountMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEnterToAddTransaction_Click(object sender, RoutedEventArgs e)
        {
            Credit credit = new Credit(Convert.ToDecimal(textBoxSumCredit.Text), textBoxNameCredit.Text, Convert.ToInt32( textBoxTimeCredit.Text), Convert.ToDecimal( textBoxPersentCredit.Text), (DateTime)creditDatePicker.SelectedDate);
            //textBlockSumOfMonth.Text = Convert.ToString(credit.CalculateMonthPersent());
        }

        private void ButtonEnterToAddTransaction_Click2(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_PersentCredit(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TimeCredit(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_SumCredit(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_NameCredit(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Credit credit = new Credit(Convert.ToDecimal(textBoxSumCredit.Text), textBoxNameCredit.Text, Convert.ToInt32(textBoxTimeCredit.Text), Convert.ToDecimal(textBoxPersentCredit.Text), (DateTime)creditDatePicker.SelectedDate);
            textBlockPay.Text = Convert.ToString(credit.CalculatiAlreadyPayMonthsOfLoan());
        }

        
        private void Button_Click_MounthPrice(object sender, RoutedEventArgs e)
        {
            Credit credit = new Credit(Convert.ToDecimal(textBoxSumCredit.Text), textBoxNameCredit.Text, Convert.ToInt32(textBoxTimeCredit.Text), Convert.ToDecimal(textBoxPersentCredit.Text), (DateTime)creditDatePicker.SelectedDate);
            textBlockSumOfMonth.Text = Convert.ToString(credit.PayMonthAnnuityLoan());
        }

        private void Button_Click_Percent(object sender, RoutedEventArgs e)
        {
            Credit credit = new Credit(Convert.ToDecimal(textBoxSumCredit.Text), textBoxNameCredit.Text, Convert.ToInt32(textBoxTimeCredit.Text), Convert.ToDecimal(textBoxPersentCredit.Text), (DateTime)creditDatePicker.SelectedDate);
            textBlockMonthPayPay.Text = Convert.ToString(credit.CalculateMonthPersent());
            
        }
        private void OnMouseLeftButtonUp(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click22(object sender, RoutedEventArgs e)
        {
            Credit credit = new Credit(Convert.ToDecimal(textBoxSumCredit.Text), textBoxNameCredit.Text, Convert.ToInt32(textBoxTimeCredit.Text), Convert.ToDecimal(textBoxPersentCredit.Text), (DateTime)creditDatePicker.SelectedDate);
            textBlockPay_Copy.Text = Convert.ToString(credit.CalculateRemainingMonths());
        }
    }
}
