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
    public partial class Window1 : Window
    {
        WorkSpace work;
        public Window1()
        {
            InitializeComponent();
            work = new WorkSpace();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            work.AddUser(Name_login.Text, Password_login.Text);
            MessageBox.Show("Пользователя добавлен");
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            bool reg = work.Registration(Name_login.Text, Password_login.Text);
            if (reg)
            {
                MainWindow wwww = new MainWindow();
                wwww.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пользователя не существует, зарегистрируйтесь!");
            }
        }
    }
}
