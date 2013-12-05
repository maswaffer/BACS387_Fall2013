using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ada.Lovelace2._0; 


namespace AdaLovelace_Story_.Test
{
    [TestClass]
    public class StoryTest
    {
        [TestMethod]
        public void getLatestTenStories()
        {
            NewsService test = new NewsService("2Q2yOlhzs/CflQI7amq22KrGBgxX3OyQk2mjsYPmZy0");
            var stories = test.SearchFor();
            Assert.AreEqual(10, stories.Count);
        }
    }
}
