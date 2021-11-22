﻿using System;
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
        private SaveData()
        {
            FilePath = "H:/settings.json";
            workSpaces = new List<WorkSpace>();
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

        List<WorkSpace> workSpaces { get; set; }


        int counts = 0;

        public void Registration(string name, string password)
        {
            string textFromFile = '';

            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
                string textFromFile = File.ReadAllText(FilePath);
            }


            if (textFromFile.Contains(name))
            {
                throw new Exception("Name already exist");
            }
            else
            {
                WorkSpace user = new WorkSpace(name, password);
                workSpaces.Add(user);
            }

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string jsonToWrite = JsonSerializer.Serialize(workSpaces[counts], options);
            File.AppendAllText(FilePath, jsonToWrite);

            counts++;
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


    }
}