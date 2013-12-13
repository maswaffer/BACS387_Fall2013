using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IfStockPrice.Test
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void CheckIfServiceWorks()
        {
            var service = new TraderService();
            var quote = service.GetStockQuote("MSFT");

            Assert.IsNotNull(quote);
        }
    }
}
