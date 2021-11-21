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
        public Window1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            WorkSpace work = new WorkSpace();
            work.AddUser(Name_login.Text, Password_login.Text);
            

        }

        private void ButtonEnterToMainMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (Name_login.Text != " " && Password_login.Text != " ")
        //    {
        //        string CommandText = "SELECT [Логин], [password],Rule FROM [User] WHERE Логин = '" + login.Text + "' AND password = " + password.Password;
        //        SqlConnection connection = new SqlConnection(cns);
        //        SqlCommand Command = new SqlCommand(CommandText);
        //        Command.Connection = connection;
        //        Command.Connection.Open();
        //        //string rule = row_selected["Rule"].ToString();
        //        if (Command.ExecuteScalar() == null)
        //        {
        //            login.Clear();
        //            password.Clear();
        //            MessageBox.Show("Логин или пароль неверен");
        //        }
        //        else
        //        {
        //            if (rule == "Заказчик")
        //            {
        //                окно_2 окно_2 = new окно_2();
        //                окно_2.Show();
        //            }
        //            if (rule == "Менеджер")
        //            {
        //                Window1 w1 = new Window1();
        //                w1.Show();
        //            }
        //            Close();
        //        }
        //    }
        //}
    }
}
