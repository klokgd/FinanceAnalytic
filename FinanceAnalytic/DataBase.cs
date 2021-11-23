using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public class DataBase
    {
        public List<Increase> Increases = new List<Increase>();
        public List<Expense> Expenses = new List<Expense>();
        public List<Category> Categories = new List<Category>();
        public List<Credit> Credits = new List<Credit>();
        public List<SavingAccount> SavingAccounts = new List<SavingAccount>();
        //TODO : реализовать как паттерн синглтон
    }
}
