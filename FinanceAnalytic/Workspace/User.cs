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
    public class User
    {

        public string Name { get; set; }
        public string Password { get; set; }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
            Accounts = new List<IAccount>();
        }

        public List<IAccount> Accounts { get; set; }

        public void AddAccountToList(IAccount counts)
        {

            Accounts.Add(counts);

        }

        public IAccount FindCount(string findCount)
        {
            IAccount necessaryCount = Accounts.Find(x => x.Name.Contains(findCount));
            return necessaryCount;

        }




    }
}


