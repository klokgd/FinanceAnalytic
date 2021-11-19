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
    
        List<PersonalCount> allCounts = new List<PersonalCount>();


        public Win()
        {
            InitializeComponent();

            SumCount.Text = Convert.ToString($"100000");
            }

        //private void buttonBIG_Click(object sender, RoutedEventArgs e)
        //{
        //    MainWindow taskWindow = new MainWindow();
        //    taskWindow.Show();
        //}

        private void SumNewCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SumNewCount.Text, "[^0-9,]"))
            {
                MessageBox.Show("Пожалуйста, вводите только числа");
                SumNewCount.Text = SumNewCount.Text.Remove(SumNewCount.Text.Length - 1);
            }
        }

        public void addListCount(PersonalCount count)
        {
            allCounts.Add(count);
        }

        public void DisplayCountsInTextBox()
        {
            int index = 0;
            foreach (var item in allCounts)
            {
                index++;
                textBlock2.Text += $" {index} Счёт: {item.Name} Денег: {item.Sum} \n";
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Expense startCount = new Expense(Convert.ToDouble(SumCount.Text), 0, DateTime.Today);
            PersonalCount goodTime = new PersonalCount(Convert.ToDouble(SumNewCount.Text), NameNewCount.Text, startCount);
            double sum = Convert.ToDouble(SumCount.Text) + Convert.ToDouble(SumNewCount.Text);
            addListCount(goodTime);
            DisplayCountsInTextBox();
            SumCount.Text = $"{sum}";
        }


        private void NameNewCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            SumNewCount.Text = SumNewCount.Text;
        }
    }
}
