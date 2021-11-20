using NUnit.Framework;
using FinanceAnalytic;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1200, "ρεμόÿ", 2400)]

        public void AddTransactionTest(decimal sum, string name, double expected)
        {
            //act
            PersonalAccount personalCount = new PersonalAccount(sum, name);
            Category family = new Category("Ρεμόÿ");
            for (int i = 0; i < 3; i++)
            {
                personalCount.AddIncrease(new Increase(1000, family, DateTime.Today));
            }
            //assert
            Assert.AreEqual(personalCount.Sum, expected);
        }

        //[TestCase (1200, 14, 2000, 6, 7)]
        //[TestCase (0, 0, 0, 2,3)]
        //[TestCase (0, 14, -2000, 0,1)]
        //[TestCase (58, -14, 2, 1,2)]

        //public void AddTransactionVersionTwoTest(double count, double sum, double transaction, int length, int expected)
        //{
        //    //act
        //    Expense expense = new Expense(sum, 0, DateTime.Today);
        //    PersonalAccount personalCount = new PersonalAccount(count, "zhopa", expense);
        //    for (int i = 0; i < length; i++)
        //    {
        //        personalCount.AddIncrease(new Expense(transaction, 0, DateTime.Today));
        //    }

        //    //assert
        //    Assert.AreEqual(personalCount.Transaction.Count, expected);
        //}
    }
}