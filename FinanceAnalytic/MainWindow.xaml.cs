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

        SaveData saveData = new SaveData();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Login_Click(object sender, RoutedEventArgs e)
        {
            bool log = saveData.Login(textBoxLogin.Text, textBoxPassword.Password);
            if (log == true)
            {
                CountWindow window = new CountWindow();
                window.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверное имя или пароль");
            }
        }
        private void button_Register_Click(object sender, RoutedEventArgs e)
        {
            bool reg = saveData.Registration(textBoxLogin.Text, textBoxPassword.Password);
            if (reg == true)
            {
                MessageBox.Show("Пользователь добавлен");
            }
            else
            {
                MessageBox.Show("Пользователь с таким именем уже существует");

            }
        }
        private void TextBox_TextChanged_2(object sender, RoutedEventArgs e)
        {

        }
    }
}