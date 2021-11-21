using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace FinanceAnalytic
{
    public class WorkSpace : IWorkSpace
    {
        public const string _filePath = "../Itog.json";

        public string Name { get; set;  }
        public string Password { get; set; }
        
        public List<IWorkSpace> User { get; set; }
       
        public WorkSpace()
        {
            
            User = new List<IWorkSpace>();
            




        }
        public WorkSpace(string name, string password)
        {
            Name = name;
            Password = password;
            
            
            

        }

        public void AddUser(string name, string password) 
        {

            
            
            string textFromFile = File.ReadAllText(_filePath);
            if (textFromFile.Contains(name))
            {
                throw new Exception("Name already exist");
            }
            else
            {
                WorkSpace user = new WorkSpace(name,  password);
                User.Add(user);
                
               
            }

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonToWrite = JsonSerializer.Serialize(User, options);
            File.AppendAllText(_filePath, jsonToWrite);
            

        }
        


        public void LogAuntification(string name, string password)
        {
            //if (name != " " && password != " ")
            //{
            //    string textFromFile = File.ReadAllText(_filePath);
                
            //    if (Name == null)
            //    {
            //        login.Clear();
            //        password.Clear();
            //        MessageBox.Show("Логин или пароль неверен");
            //    }
            //    else
            //    {
            //        if (rule == "Заказчик")
            //        {
            //            окно_2 окно_2 = new окно_2();
            //            окно_2.Show();
            //        }
            //        if (rule == "Менеджер")
            //        {
            //            Window1 w1 = new Window1();
            //            w1.Show();
            //        }
            //        Close();
            //    }
            //}
        }
    }
}
