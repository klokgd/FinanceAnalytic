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
    /// </summary>y
    public partial class CountWindow : Window
    {
        private WorkSpace _workSpace;

        public CountWindow(WorkSpace authentication)
        {
            InitializeComponent();
            _workSpace = authentication;
        }
        private void ButtonEnterToCountMenu_Click(object sender, RoutedEventArgs e)
        {
            CountWindow window = this;
            window.Show();
            
        }
        private void ButtonEnterToOperationMenu_Click(object sender, RoutedEventArgs e)
        {
            OperationWindow window = new OperationWindow(_workSpace);
            window.Show();
            this.Hide();
        }
        private void ButtonEnterToAnalisMenu_Click(object sender, RoutedEventArgs e)
        {
            AnalyseWindow window = new AnalyseWindow();
            window.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreditWidow credits = new CreditWidow();
            credits.Show();
            this.Hide();
        }
    }
}
