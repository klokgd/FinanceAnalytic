using System.IO;
using System.Windows;
using System.Windows.Controls;


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

            foreach (var item in storage.usersList)
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
                User workSpace = storage.GetWorkSpace(login);
                AccountWindow countWindow = new AccountWindow(workSpace);
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