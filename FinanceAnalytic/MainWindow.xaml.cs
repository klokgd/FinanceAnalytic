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

        SaveData saveData = new SaveData();
        //Counts count = new Counts(120000, "Семейный");

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
        //public enum pages
        //{
        //    login,
        //    registration
        //}

        //public void OpenPage(pages page)
        //{
        //    //if (page == pages.login)
        //    //{
        //    //    frame_Navigated(new login(this));
        //    //}
        //}

        //private void button_Plus_Click(object sender, RoutedEventArgs e)
        //{
        //    TabControl tabControl = new TabControl();
        //    MessageBox.Show(tabControl.ToString());
        //    //count.PlusToSum(Convert.ToDouble(textBox.Text));
        //    //textBlock.Text = Convert.ToString($"Сумма в буджете {count.Name} равна {count.Sum}");
        //    //frame.Navigate(new Page1());
        //}





        //private void button_Minus_Click(object sender, RoutedEventArgs e)
        //{
        //    TabControl tabControl = new TabControl();
        //    MessageBox.Show(tabControl.ToString());
        //    //
        //    //tabControl.SelectedIndex = 1;
        //    //Main_tab.GetControl(1);
        //    //count.MinusToSum(Convert.ToDouble(textBox.Text));

        //    //textBlock.Text = Convert.ToString($"Сумма в буджете {count.Name} равна {count.Sum}");
        //}

        //private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    //if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9,]"))
        //    //{
        //    //    MessageBox.Show("Пожалуйста, вводите только числа");
        //    //    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
        //    //}


        //    //return value;
        //}

        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    Win taskWindow = new Win();
        //    taskWindow.Show();
        //    //TabControl tabControl = new TabControl();
        //    //TabControl tabControl1 = new TabControl();

        //    //taskWindow.ShowViewModel();
        //}

        //private void button1_Click(object sender, RoutedEventArgs e)
        //{
        //    Window1 pg = new Window1();
        //    pg.Show();
        //    this.Hide();
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    var wd = new Windows.NewVisualForMainWindw();
        //    wd.ShowDialog();
        //}


    }
}