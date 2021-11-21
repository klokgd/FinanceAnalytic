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

namespace FinanceAnalytic.Windows
{
    /// <summary>
    /// Interaction logic for NewVisualForMainWindw.xaml
    /// </summary>
    public partial class NewVisualForMainWindw : Window
    {
        public NewVisualForMainWindw()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            LabelTest.Content = "Привет:)";
        }
    }
}
