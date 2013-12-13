using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IfStockPrice.Test
{
    [TestClass]
    public class PriceChangeGreaterThanTest
    {
        private PriceChangeGreaterThan criteria { get; set; }

        [TestInitialize]
        public void Setup()
        {
            criteria = new PriceChangeGreaterThan();
        }

        [TestMethod]
        public void ShouldBeMetPositivePercent()
        {
            //Set Criteria
            criteria.PercentChange = .1M;

            //Set data (only set relevant fields)
            var stock = new Stock{
                ChangePercent = .11M
            };

            var isMet = criteria.Check(stock);

            Assert.IsTrue(isMet);
        }

        [TestMethod]
        public void ShouldNotBeMetPositivePercent()
        {
            //Set Criteria
            criteria.PercentChange = .1M;

            //Set data (only set relevant fields)
            var stock = new Stock
            {
                ChangePercent = .09M
            };

            var isMet = criteria.Check(stock);

            Assert.IsFalse(isMet);
        }

        [TestMethod]
        public void ShouldBeMetNegativePercent()
        {
            //Set Criteria
            criteria.PercentChange = -.1M;

            //Set data (only set relevant fields)
            var stock = new Stock
            {
                ChangePercent = -.11M
            };

            var isMet = criteria.Check(stock);

            Assert.IsTrue(isMet);
        }

        [TestMethod]
        public void ShouldBeMetNegativePercent2()
        {
            //Set Criteria
            criteria.PercentChange = -3M;

            //Set data (only set relevant fields)
            var stock = new Stock
            {
                ChangePercent = -3.9M
            };

            var isMet = criteria.Check(stock);

            Assert.IsTrue(isMet);
        }

        [TestMethod]
        public void ShouldNotBeMetNegativePercent()
        {
            //Set Criteria
            criteria.PercentChange = -.1M;

            //Set data (only set relevant fields)
            var stock = new Stock
            {
                ChangePercent = -.09M
            };

            var isMet = criteria.Check(stock);

            Assert.IsFalse(isMet);
        }

        [TestMethod]
        public void ShouldNotBeMetMixedPercent()
        {
            //Set Criteria
            criteria.PercentChange = -.1M;

            //Set data (only set relevant fields)
            var stock = new Stock
            {
                ChangePercent = .09M
            };

            var isMet = criteria.Check(stock);

            Assert.IsFalse(isMet);
        }
    }
}
