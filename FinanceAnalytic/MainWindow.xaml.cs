﻿using System;
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
        //Counts count = new Counts(120000, "Семейный");

        public MainWindow()
        {
            //<TextBox x:Name="textBox" HorizontalAlignment="Left" FontSize="24" Margin="384,35,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="109" Height="32" TextChanged="textBox_TextChanged" />
        //    <TextBox x:Name="textBox_Copy" HorizontalAlignment="Left" FontSize="24" Margin="519,34,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="104" Height="33" TextChanged="textBox_TextChanged" />
        //<TextBox x:Name="textBox_Copy1" HorizontalAlignment="Left" FontSize="24" Margin="650,34,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="100" Height="34" TextChanged="textBox_TextChanged" />

            Expense startCount = new Expense(1200, Category.Food, DateTime.Today);
            PersonalCount goodTime = new PersonalCount(200, "zhopa", startCount);
            Expense addToSum = new Expense(12, Category.HCS, DateTime.Today);
            Expense addToSum1 = new Expense(30, Category.Food, DateTime.Today);
            Expense addToSum2 = new Expense(50, Category.Clothes, DateTime.Today);
            Expense addToSum3 = new Expense(409, 0, DateTime.Today);
            goodTime.AddTransaction(addToSum);
            goodTime.AddTransaction(addToSum1);
            goodTime.AddTransaction(addToSum2);
            goodTime.AddTransaction(addToSum3);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string jsonToWrite = JsonSerializer.Serialize(goodTime, options);
            File.WriteAllText(_filePath, jsonToWrite);
            InitializeComponent();

            //textBlock.Text = Convert.ToString($"Сумма в буджете {count.Name} равна {count.Sum}");

        }

        private void button_Plus_Click(object sender, RoutedEventArgs e)
        {
            TabControl tabControl = new TabControl();
            MessageBox.Show(tabControl.ToString());
            //count.PlusToSum(Convert.ToDouble(textBox.Text));
            //textBlock.Text = Convert.ToString($"Сумма в буджете {count.Name} равна {count.Sum}");
            //frame.Navigate(new Page1());
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {

        }



        private void button_Minus_Click(object sender, RoutedEventArgs e)
        {
            TabControl tabControl = new TabControl();
            MessageBox.Show(tabControl.ToString());
            //
            //tabControl.SelectedIndex = 1;
            //Main_tab.GetControl(1);
            //count.MinusToSum(Convert.ToDouble(textBox.Text));

            //textBlock.Text = Convert.ToString($"Сумма в буджете {count.Name} равна {count.Sum}");
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9,]"))
            //{
            //    MessageBox.Show("Пожалуйста, вводите только числа");
            //    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            //}


            //return value;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Win taskWindow = new Win();
            taskWindow.Show();
            //TabControl tabControl = new TabControl();
            //TabControl tabControl1 = new TabControl();
            
            //taskWindow.ShowViewModel();
        }

        //private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
            
           
        //}
    }
}