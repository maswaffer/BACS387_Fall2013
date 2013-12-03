using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watson
{
    public class PlaysForPlayer
    {
        private readonly string FileName = "2013COL.EVN";

        public List<Play> GetPlay(string playerID)
        {
            List<Play> Plays = new List<Play>();

            var allLines = File.ReadAllLines(FileName);

            foreach (var line in allLines)
            {
                var splitByComma = line.Split(',');

                if (splitByComma[0] == "play" & splitByComma[3] == playerID)
                {
                    var player = new Play
                    {
                        PlayerID = splitByComma[3],
                        PlayType = splitByComma[6]
                    };

                    Plays.Add(player);
                }

            }

            return Plays;
        }
    }
}
