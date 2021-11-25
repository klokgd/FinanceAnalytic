using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Text.Encodings.Web;
using System.Windows.Controls;

using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.Unicode;

namespace FinanceAnalytic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {

            InitializeComponent();
            Storage storage = Storage.GetInstance();

            foreach (var item in storage.workSpaces)
            {
                ListBoxListOfUsers.Items.Add(item.Name);
            }
            
                 

        }






        private void button_Login_Click(object sender, RoutedEventArgs e)
        {

            string login = ListBoxListOfUsers.SelectedItem.ToString();
            string password = textBoxPassword.Password;

            Storage storage = Storage.GetInstance();

            bool checkUser = storage.Login(login, password);

            if (checkUser)
            {
                WorkSpace workSpace = storage.GetWorkSpace(login);
                CountWindow countWindow = new CountWindow(workSpace);
                countWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Данные неверны или пользователя не существует!");
            }

        }

        private void button_AddUser_Click(object sender, RoutedEventArgs e)
        {
            Reg_Window reg_Window = new Reg_Window();
            reg_Window.Owner = this;
            reg_Window.Show();



        }
        private void ListBoxListOfUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Storage storage = Storage.GetInstance();

            if (!File.Exists(storage.FilePath))
            {

            }
        }


    }
}