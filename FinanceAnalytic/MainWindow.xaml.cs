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
<<<<<<< HEAD

            //string textFromFile = File.ReadAllText(_filePath);
            //WorkSpace main = JsonSerializer.Deserialize<WorkSpace>(textFromFile);
            //WorkSpace work = new WorkSpace();

            foreach (var item in storage.workSpaces)
            {
                ListBoxListOfUsers.Items.Add(item.Name);
            }
            
                 



            Category fgf = new Category("hi!");
            Expense startCount = new Expense(1200, fgf, DateTime.Today);
            //PersonalAccount goodTime = new PersonalAccount(200, "zhopa");
            Credit fff = new Credit(12000, "hjh", 12);
            decimal f=            fff.CalculateMonthPersent(12);

            Expense addToSum = new Expense(12, fgf, DateTime.Today);
            Expense addToSum1 = new Expense(30, fgf, DateTime.Today);
            Expense addToSum2 = new Expense(50, fgf, DateTime.Today);
            Expense addToSum3 = new Expense(409, fgf, DateTime.Today);
            //goodTime.AddTransaction(addToSum);
            //goodTime.AddTransaction(addToSum1);
            //goodTime.AddTransaction(addToSum2);
            //goodTime.AddTransaction(addToSum3);

            //JsonSerializerOptions options = new JsonSerializerOptions
            //{
            //    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            //    WriteIndented = true
            //};

            //string jsonToWrite = JsonSerializer.Serialize(work, options);

            //File.WriteAllText(_filePath, jsonToWrite);
            //string textFromFile = File.ReadAllText(_filePath);
            //WorkSpace main = JsonSerializer.Deserialize<WorkSpace>(textFromFile);
=======
>>>>>>> master

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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var wd = new Windows.NewVisualForMainWindw();
            wd.ShowDialog();
        }
    }
}