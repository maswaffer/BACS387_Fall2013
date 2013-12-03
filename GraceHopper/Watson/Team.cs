using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace Watson
{
    public class Team
    {
        private readonly string FileName = "2013COL.EVN";

        public List<Player> GetPlayers()
        {
            List<Player> roster = new List<Player>();

            var allLines = File.ReadAllLines(FileName);

            foreach (var line in allLines)
            {
                var splitByComma = line.Split(',');
                
                if (splitByComma[0] == "start")
                {
                    var player = new Player
                    {
                        playerID = splitByComma[1],
                        Name = splitByComma[2]
                    };

                    roster.Add(player);
                }
                
            }

            return roster;
        }

        public List<Play> GetPlay()
        {
            List<Play> Plays = new List<Play>();

            var allLines = File.ReadAllLines(FileName);

            foreach (var line in allLines)
            {
                var splitByComma = line.Split(',');

                if (splitByComma[0] == "play")
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
