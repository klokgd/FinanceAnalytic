using NUnit.Framework;
using FinanceAnalytic;
using System;

namespace Tests
{
    public class IncreaseAndExpenseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-1300)]

        public void CreateIncreaseNegativeTest(decimal sum)
        {
            //act
            DateTime toDay = DateTime.Today;
            Category category = new Category("eda");
            Assert.Throws(typeof(ArgumentException), () => new Increase(sum, category, toDay));

        }
    }
}
