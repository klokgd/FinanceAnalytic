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
using System.Linq;

namespace FinanceAnalytic
{
    /// <summary>
    /// Interaction logic for Reg_Window.xaml
    /// </summary>
    public partial class Reg_Window : Window
    {
        public Reg_Window()
        {
            InitializeComponent();
        }

        private void button_Register_Click(object sender, RoutedEventArgs e)
        {

            string login = TextBoxUsername.Text;
            string password = PasswordBoxPass.Password;

            Storage storage = Storage.GetInstance();

            storage.Registration(login, password);

            MainWindow mainWindow = Owner as MainWindow;


            mainWindow.ListBoxListOfUsers.Items.Add(storage.usersList.Last().Name);

            Hide();
        }
    }
}
