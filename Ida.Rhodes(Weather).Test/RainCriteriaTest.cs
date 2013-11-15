using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ida.Rhodes;

namespace Ida.Rhodes_Weather_.Test
{
    [TestClass]
    public class RainCriteriaTest
    {
        private RainCriteria criteria { get; set; }

        [TestInitialize]
        public void Setup()
        {
            criteria = new RainCriteria();
        }

        [TestMethod]
        public void RainCriteriaMet()
        {
            criteria.UserPrecipThreshold = 50;

            var forecast = new Forecast
            {
                ChanceOfPrecip = 50
            };

            var isMet = criteria.Check(forecast);

            Assert.IsTrue(isMet);
        }
    }
}
