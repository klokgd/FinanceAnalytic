using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Text.Unicode;
using System.Windows;

namespace FinanceAnalytic
{
    public sealed class Storage
    {
        private Storage()
        {
            FilePath = "../settings.json";

            if (File.Exists(FilePath))
            {
                usersList = new List<User>();
                string json = File.ReadAllText(FilePath);


                usersList = JsonConvert.DeserializeObject<List<User>>(json);
            }

            else
                usersList = new List<User>();
        }
        private static Storage _instance;

        public static Storage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Storage();
            }
            return _instance;
        }
        public string FilePath { get; }

        public List<User> usersList { get; set; }
        public List<PersonalAccount> accountList { get; set; }


        int counts = 0;

        public void Registration(string name, string password)
        {

            if (!File.Exists(FilePath))
            {
                var myFiles = File.Create(FilePath);
                myFiles.Close();
            }

            string textFromFile = File.ReadAllText(FilePath);

            if (textFromFile.Contains(name))
            {
                MessageBox.Show("Пользователь с таким именем уже зарегистрирован");
            }
            else
            {
                User user = new User(name, password);

                usersList.Add(user);

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };

                string jsonToWrite = System.Text.Json.JsonSerializer.Serialize(usersList, options);
                File.WriteAllText(FilePath, jsonToWrite);

                counts++;
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
                if (item.Contains(name) && item.Contains(password))
                {
                    return true;
                }

            }
            return false;
        }

        public void SaveToFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string jsonToWrite = System.Text.Json.JsonSerializer.Serialize(usersList, options);
            File.WriteAllText(FilePath, jsonToWrite);
        }

        public User GetWorkSpace(string findName)
        {
            User necessaryUser = usersList.Find(x => x.Name.Contains(findName));
           
             

            return necessaryUser;

        }

        public void AddAccount(decimal sum, string name )
        {
            PersonalAccount newAcc = new PersonalAccount(sum, name);
            if (accountList ==null)
            {
                accountList = new List<PersonalAccount>();
            }
            accountList.Add(newAcc);
            //SaveToFile();
        }
    }
}