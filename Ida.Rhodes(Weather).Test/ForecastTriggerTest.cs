using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ida.Rhodes;

namespace Ida.Rhodes_Weather_.Test
{
    [TestClass]
    public class ForecastTriggerTest
    {
        private ForecastTrigger trigger { get; set; }
        //private RainCriteria rainCriteria { get; set; }
        //private ColdCriteria coldCriteria { get; set; }

        [TestInitialize]
        public void Setup()
        {
            //rainCriteria = new RainCriteria();
            //coldCriteria = new ColdCriteria();
            trigger = new ForecastTrigger("80634");
        }

        [TestMethod]
        public void TestForecastTrigger()
        {
            var rainCriteria = new RainCriteria();
            rainCriteria.userPrecipValue = 45;
            var coldCriteria = new TempCriteria();
            coldCriteria.tempAboveOrBelow = "Below";
            coldCriteria.userTempValue = 35;
            trigger.AddCriteria(rainCriteria);
            trigger.AddCriteria(coldCriteria);


            var isMet = trigger.CheckCondition();

            Assert.IsTrue(isMet);
        }
    }
}
