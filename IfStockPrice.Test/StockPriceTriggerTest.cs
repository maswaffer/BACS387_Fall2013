using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IfStockPrice.Test
{
    [TestClass]
    public class StockPriceTriggerTest
    {
        private StockPriceTrigger trigger { get; set; }

        [TestInitialize]
        public void Setup()
        {
            trigger = new StockPriceTrigger("MSFT");
        }

        [TestMethod]
        public void ShouldTestTrigger()
        {
            var priceIsHighCriteria = new PriceIsHighCriteria();
            trigger.AddCriteria(priceIsHighCriteria);

            var isMet = trigger.CheckCondition();

            Assert.IsTrue(isMet);
        }
    }
}
