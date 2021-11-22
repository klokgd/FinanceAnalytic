using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
//using System.Web.Script.Serializion;



namespace FinanceAnalytic
{
    public class WorkSpace : IWorkSpace
    {
        public const string _filePath = "../Itog.json";

        public string Name { get; set;  }
        public string Password { get; set; }
        
        public List<IWorkSpace> User { get; set; } = new List<IWorkSpace>();
        public WorkSpace() { }
        public WorkSpace(string name, string password)
        {
            Name = name;
            Password = password;
        }
        
        int counts = 0;
        
        public void AddUser(string name, string password)
        {
            string textFromFile = File.ReadAllText(_filePath);
            if (textFromFile.Contains(name))
            {
                throw new Exception("Name already exist");
            }
            else
            {   
                WorkSpace user = new WorkSpace(name, password);
                User.Add(user);
                
            }
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonToWrite = JsonSerializer.Serialize(User[counts], options);
            File.AppendAllText(_filePath, jsonToWrite);
            
            counts++;
        }
        
        public bool Registration(string name, string password)
        {
            string[] textFromFile = File.ReadAllLines(_filePath);
            foreach (var item in textFromFile)
            {
                if (item.Contains(name) && item.Contains(password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}

