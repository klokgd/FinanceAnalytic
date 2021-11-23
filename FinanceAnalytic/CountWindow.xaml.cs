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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CountWindow : Window
    {
        //WorkSpace work;
        public CountWindow()
        {
            InitializeComponent();
            //work = new WorkSpace();
        }
        private void ButtonEnterToCountMenu_Click(object sender, RoutedEventArgs e)
        {
            CountWindow window = new CountWindow();
            window.Show();
            this.Hide();
        }

        private void ButtonEnterToOperationMenu_Click(object sender, RoutedEventArgs e)
        {
            Win window = new Win();
            window.Show();
            this.Hide();
        }
        private void ButtonEnterToAnalisMenu_Click(object sender, RoutedEventArgs e)
        {
            AnaliticWindow window = new AnaliticWindow();
            window.Show();
            this.Hide();
        }
        //public void OpenPage(pages page)
        //{
        //    //if (page == pages.login)
        //    //{
        //    //    frame_Navigated(new login(this));
        //    //}
        //}

        //private void button_Plus_Click(object sender, RoutedEventArgs e)
        //{
        //    TabControl tabControl = new TabControl();
        //    MessageBox.Show(tabControl.ToString());
        //    //count.PlusToSum(Convert.ToDouble(textBox.Text));
        //    //textBlock.Text = Convert.ToString($"Сумма в буджете {count.Name} равна {count.Sum}");
        //    //frame.Navigate(new Page1());
        //}





        //private void button_Minus_Click(object sender, RoutedEventArgs e)
        //{
        //    TabControl tabControl = new TabControl();
        //    MessageBox.Show(tabControl.ToString());
        //    //
        //    //tabControl.SelectedIndex = 1;
        //    //Main_tab.GetControl(1);
        //    //count.MinusToSum(Convert.ToDouble(textBox.Text));

        //    //textBlock.Text = Convert.ToString($"Сумма в буджете {count.Name} равна {count.Sum}");
        //}

        //private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    //if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9,]"))
        //    //{
        //    //    MessageBox.Show("Пожалуйста, вводите только числа");
        //    //    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
        //    //}


        //    //return value;
        //}

        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    Win taskWindow = new Win();
        //    taskWindow.Show();
        //    //TabControl tabControl = new TabControl();
        //    //TabControl tabControl1 = new TabControl();

        //    //taskWindow.ShowViewModel();
        //}

        //private void button1_Click(object sender, RoutedEventArgs e)
        //{
        //    Window1 pg = new Window1();
        //    pg.Show();
        //    this.Hide();
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    var wd = new Windows.NewVisualForMainWindw();
        //    wd.ShowDialog();
        //}


    }
}
