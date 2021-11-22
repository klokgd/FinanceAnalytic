using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows;
//using System.Web.Script.Serializion;



namespace FinanceAnalytic
{
    public class WorkSpace : IWorkSpace
    {
        //public const string _filePath = "../Itog.json";

        public string Name { get; set;  }
        public string Password { get; set; }
        
        //public List<IWorkSpace> User { get; set; } = new List<IWorkSpace>();
        public WorkSpace(string name, string password)
        {
            Name = name;
            Password = password;
        }
        
        //int counts = 0;
        
        //public void Registration(string name, string password, SaveData saveData)
        //{


        //    string textFromFile = File.ReadAllText(saveData.FilePath);


        //    if (textFromFile.Contains(name))
        //    {
        //        throw new Exception("Name already exist");
        //    }
        //    else
        //    {   
        //        WorkSpace user = new WorkSpace(name, password);
        //        User.Add(user); 
        //    }

        //    JsonSerializerOptions options = new JsonSerializerOptions
        //    {
        //        Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
        //        WriteIndented = true
        //    };
            
        //    string jsonToWrite = JsonSerializer.Serialize(User[counts], options);
        //    File.AppendAllText(saveData.FilePath, jsonToWrite);
            
        //    counts++;
        //}
        
        //public bool Login(string name, string password, SaveData saveData)
        //{
        //    string[] textFromFile = File.ReadAllLines(saveData.FilePath);



        //    if (File.Exists(saveData.FilePath) != true)
        //    {
        //        MessageBox.Show("В системе нет ни одного пользователя, сначала зарегистрируйтесь");
        //        return false;
        //    }

        //    foreach (var item in textFromFile)
        //    {
        //        if (item.Contains(name) && item.Contains(password))
        //        {
        //            return true;
        //        }
                
        //    }
        //    return false;
        //}
    }
}

