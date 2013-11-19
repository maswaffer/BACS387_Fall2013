using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ida.Rhodes;

namespace Ida.Rhodes_Weather_.Test
{
    [TestClass]
    public class RainCriteriaTest
    {
        private RainCriteria criteria { get; set; }
        private ForecastTrigger trigger { get; set; }

        [TestInitialize]
        public void Setup()
        {
            criteria = new RainCriteria();
            trigger = new ForecastTrigger("80634");
        }

        [TestMethod]
        public void RainCriteriaMet()
        {
            criteria.userPrecipValue = 50;

            var forecast = new Forecast
            {
                ChanceOfPrecip = 50
            };

            var isMet = criteria.Check(forecast);

            Assert.IsTrue(isMet);
        }
    }
}
