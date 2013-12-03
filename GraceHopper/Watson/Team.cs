using System.Collections.Generic;
using System.IO;

namespace Watson
{
    public class Team
    {
        private readonly string FileName = "2013COL.EVN";

        public List<Team> GetPlayers()
        {
            List<Team> roster = new List<Team>();

            var allLines = File.ReadAllLines(FileName);

            foreach (var line in allLines)
            {
                if 
            }


        }
    }
}
