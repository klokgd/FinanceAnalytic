using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Unicode;
using System.Windows;

namespace FinanceAnalytic
{
    public sealed class Storage
    {
        private Storage()
        {
            FilePath = "./settings.json";

            if (File.Exists(FilePath))
            {
                usersList = new List<User>();
                string json = File.ReadAllText(FilePath);

                usersList = JsonConvert.DeserializeObject<List<User>>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    NullValueHandling = NullValueHandling.Ignore,
                });
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

        public void RegisterUser(string name, string password)
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

                //JsonSerializerOptions options = new JsonSerializerOptions
                //{
                //    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                //    WriteIndented = true,

                //};

                //string jsonToWrite = System.Text.Json.JsonSerializer.Serialize(usersList, options);

                string jsonTypeNameAll = JsonConvert.SerializeObject(usersList, Formatting.Indented, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });

                ////File.WriteAllText(FilePath, jsonToWrite);
                //string FilePath2 = "./settings2.json";
                File.WriteAllText(FilePath, jsonTypeNameAll);
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
            //JsonSerializerOptions options = new JsonSerializerOptions
            //{
            //    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            //    WriteIndented = true
            //};

            //string jsonToWrite = System.Text.Json.JsonSerializer.Serialize(usersList, options);
            //File.WriteAllText(FilePath, jsonToWrite);
            //string FilePath2 = "./settings2.json";

            string jsonTypeNameAll = JsonConvert.SerializeObject(usersList, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });

            File.WriteAllText(FilePath, jsonTypeNameAll);
        }

        public User GetWorkSpace(string findName)
        {
            User necessaryUser = usersList.Find(x => x.Name.Contains(findName));
            return necessaryUser;
        }
    }
}