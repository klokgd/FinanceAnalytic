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

        public string Name { get; set; }
        public string Password { get; set; }

        public WorkSpace(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public List<ITransactions> Counts { get; set; }

        public void AddCount(ITransactions counts) 
        {
            Counts = new List<ITransactions>();
            Counts.Add(counts);
        }

        


    }
}

