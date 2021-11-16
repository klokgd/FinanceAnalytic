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
    /// Interaction logic for Win.xaml
    /// </summary>
    public partial class Win : Window
    {
        //Counts familyCount = new Counts(120000, "Семейный");
        //Counts myCount = new Counts(400, "Под подушкой");
        //Counts ipotekaCount = new Counts(-4500000, "Кредит");
        public Win()
        {
            InitializeComponent();

            //textBlock.Text = Convert.ToString($"Сумма в буджете {familyCount.Name} равна {familyCount.Sum}");
            //textBlock1.Text = Convert.ToString($"Сумма в буджете {myCount.Name} равна {myCount.Sum}");
            //textBlock2.Text = Convert.ToString($"Сумма в буджете {ipotekaCount.Name} равна {ipotekaCount.Sum}");
        }

        private void buttonBIG_Click(object sender, RoutedEventArgs e)
        {
            MainWindow taskWindow = new MainWindow();
            taskWindow.Show();
        }
    }
}
