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

        [TestCase(1200, 14, 2000, 6, 13214)]
        [TestCase(0, 0, 0, 2, 0)]
        [TestCase(0, 14, -2000, 0, 14)]
        [TestCase(58, -14, 2, 1, 46)]

        public void AddTransactionTest(double count, double sum, double transaction, int length, double expected)
        {
            //act
            Expense expense = new Expense(sum, 0, DateTime.Today);
            PersonalCount personalCount = new PersonalCount(count, "zhopa", expense);
            for (int i = 0; i < length; i++)
            {
                personalCount.AddTransaction(new Expense(transaction, 0, DateTime.Today));
            }
            //assert
            Assert.AreEqual(personalCount.Sum, expected);
        }
        
        [TestCase (1200, 14, 2000, 6, 7)]
        [TestCase (0, 0, 0, 2,3)]
        [TestCase (0, 14, -2000, 0,1)]
        [TestCase (58, -14, 2, 1,2)]
        
        public void AddTransactionVersionTwoTest(double count, double sum, double transaction, int length, int expected)
        {
            //act
            Expense expense = new Expense(sum, 0, DateTime.Today);
            PersonalCount personalCount = new PersonalCount(count, "zhopa", expense);
            for (int i = 0; i < length; i++)
            {
                personalCount.AddTransaction(new Expense(transaction, 0, DateTime.Today));
            }
            
            //assert
            Assert.AreEqual(personalCount.Transaction.Count, expected);
        }
    }
}