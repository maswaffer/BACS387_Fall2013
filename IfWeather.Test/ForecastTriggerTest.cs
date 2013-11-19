using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ida.Rhodes;

namespace IfWeather.Test
{
    [TestClass]
    public class ForecastTriggerTest
    {

        private ForecastTrigger trigger { get; set; }

        [TestInitialize]
        public void Setup()
        {
            trigger = new ForecastTrigger(80634);
        }

        [TestMethod]
        public void TestForecastTrigger()
        {
            var RainCriteria = new RainCriteria();
            trigger.AddCriteria(RainCriteria);



        }
    }
}
