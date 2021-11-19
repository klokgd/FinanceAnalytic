using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinanceAnalytic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Counts count = new Counts(120000, "Семейный");

        public MainWindow()
        {
            //<TextBox x:Name="textBox" HorizontalAlignment="Left" FontSize="24" Margin="384,35,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="109" Height="32" TextChanged="textBox_TextChanged" />
        //    <TextBox x:Name="textBox_Copy" HorizontalAlignment="Left" FontSize="24" Margin="519,34,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="104" Height="33" TextChanged="textBox_TextChanged" />
        //<TextBox x:Name="textBox_Copy1" HorizontalAlignment="Left" FontSize="24" Margin="650,34,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="100" Height="34" TextChanged="textBox_TextChanged" />

            Expense startCount = new Expense(1200, 0, DateTime.Today);
            PersonalCount goodTime = new PersonalCount(200, "zhopa", startCount);
            Expense addToSum = new Expense(12, 0, DateTime.Today);
            Expense addToSum1 = new Expense(30, 0, DateTime.Today);
            Expense addToSum2 = new Expense(50, 1, DateTime.Today);
            Expense addToSum3 = new Expense(409, 0, DateTime.Today);
            goodTime.AddTransaction(addToSum);
            goodTime.AddTransaction(addToSum1);
            goodTime.AddTransaction(addToSum2);
            goodTime.AddTransaction(addToSum3);

            InitializeComponent();

            //textBlock.Text = Convert.ToString($"Сумма в буджете {count.Name} равна {count.Sum}");

        }

        private void button_Plus_Click(object sender, RoutedEventArgs e)
        {

            //count.PlusToSum(Convert.ToDouble(textBox.Text));
            //textBlock.Text = Convert.ToString($"Сумма в буджете {count.Name} равна {count.Sum}");
            //frame.Navigate(new Page1());
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {

        }



        private void button_Minus_Click(object sender, RoutedEventArgs e)
        {
            //count.MinusToSum(Convert.ToDouble(textBox.Text));

            //textBlock.Text = Convert.ToString($"Сумма в буджете {count.Name} равна {count.Sum}");
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9,]"))
            //{
            //    MessageBox.Show("Пожалуйста, вводите только числа");
            //    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            //}


            //return value;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Win taskWindow = new Win();
            taskWindow.Show();
            //taskWindow.ShowViewModel();
        }

    }
}