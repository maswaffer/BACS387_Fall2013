using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Watson_Pitch_.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReadFileTeam()
        {
            var File = new Watson.Team();
            var Roster = File.GetPlayers();
            Assert.AreEqual(1458, Roster.Count);
        }

        [TestMethod]
        public void ShouldReadFilePlaysForPlayer()
        {
            var File = new Watson.PlaysForPlayer();
            var TotalPlays = File.GetPlay("tulot001");
            Assert.AreEqual(318, TotalPlays.Count);
        }

    }
}
