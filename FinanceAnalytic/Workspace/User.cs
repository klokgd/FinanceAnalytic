using System.Collections.Generic;




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
            Credits = new List<Credit>();
            Deposit = new List<Credit>();
            Categories = new List<Category>();
        }

        public List<IAccount> Accounts { get; set; }
        public List<Credit> Credits { get; set; }
        public List<Credit> Deposit { get; set; }

        public List<Category> Categories { get; set; }

        public void AddAccountToList(IAccount counts)
        {
            Accounts.Add(counts);
        }

        public void AddCategoryToList(Category category)
        {
            Categories.Add(category);
        }

        public IAccount FindAccount(string findCount)
        {
            IAccount necessaryCount = Accounts.Find(x => x.Name.Contains(findCount));
            return necessaryCount;
        }
        public Credit FindCredit(string findCount)
        {
            Credit necessaryCount = Credits.Find(x => x.Name.Contains(findCount));

            return necessaryCount;
        }
        public Credit FindDeposit(string findCount)
        {
            Credit necessaryCount = Deposit.Find(x => x.Name.Contains(findCount));
            return necessaryCount;
        }
    }
}


