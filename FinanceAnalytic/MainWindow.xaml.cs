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
        //private Window _window1;
        //private Window _window2;
        Count count = new Count(12000, "Семейный");
        public MainWindow()
        {
            

            InitializeComponent();

            textBlock.Text = Convert.ToString(count.Sum);
            
        }

        private void button_Plus_Click(object sender, RoutedEventArgs e)
        {
            
            count.PlusToSum(Convert.ToDouble(textBox.Text));
            textBlock.Text = Convert.ToString(count.Sum);
            //frame.Navigate(new Page1());
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
            
        }

        

        private void button_Minus_Click(object sender, RoutedEventArgs e)
        {
            count.MinusToSum(Convert.ToDouble(textBox.Text));
            
            textBlock.Text = Convert.ToString(count.Sum);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9,]"))
            {
                MessageBox.Show("Пожалуйста, вводите только числа");
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
            
            
            //return value;
        }
    }
}
