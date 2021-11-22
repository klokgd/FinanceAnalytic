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

        public const string _filePath = "../Itog.json";

        WorkSpace workSpace;
        //Counts count = new Counts(120000, "Семейный");

        public MainWindow()
        {

            InitializeComponent();
            
        }





        private void frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void button_Login_Click(object sender, RoutedEventArgs e)
        {

            string login = textBoxLogin.Text;
            string password = textBoxPassword.Password;

            SaveData saveData = SaveData.GetInstance();

            bool checkUser = saveData.Login(login, password);

            if (checkUser)
            {
                MainWindow wwww = new MainWindow();
                wwww.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Данные неверны или пользователя не существует!");
            }

        }

        private void button_Register_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Password;

            SaveData saveData = SaveData.GetInstance();

            saveData.Registration(login, password);

        }



        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}