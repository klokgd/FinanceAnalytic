using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows;

namespace FinanceAnalytic
{
    public sealed class SaveData
    {
        public SaveData()
        {
            FilePath = "../Itog.json";
            workSpaces = new List<User>();
        }
        private static SaveData _instance;

        public static SaveData GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SaveData();
            }
            return _instance;
        }
        public string FilePath { get; }
        List<User> workSpaces { get; set; }

        int counts = 0;

        public bool Registration(string name, string password)
        {
            string textFromFile = File.ReadAllText(FilePath);

            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
                textFromFile = File.ReadAllText(FilePath);
            }
            if (textFromFile.Contains(name))
            {
                return false;
            }
            else
            {
                User user = new User(name, password);
                workSpaces.Add(user);
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };

                string jsonToWrite = JsonSerializer.Serialize(workSpaces[counts], options);
                File.AppendAllText(FilePath, jsonToWrite);
                counts++;
                return true;
            }
        }

        public bool Login(string name, string password)
        {
            string[] textFromFile = File.ReadAllLines(FilePath);
            if (File.Exists(FilePath) != true)
            {
                MessageBox.Show("В системе нет ни одного пользователя, сначала зарегистрируйтесь");
                return false;
            }
            foreach (var item in textFromFile)
            {
                if (item.Contains(name) && item.Contains(password) && name != "" && password != "" )
                {
                    return true;
                }
            }
            return false;
        }
    }
}

