using System;
using System.Collections.Generic;
using System.Text;

namespace simeltable
{
    class ScoreTableRow
    {
        public string _TeamName;
        public int GameCount;
        public int ScoredGoals;
        public int ConcededGoals;


        public ScoreTableRow(string teamName)
        {
            _TeamName = teamName;
        }

        public void Add(MatchResult matchResult, bool isHomeTeam)
        {
            GameCount++;
            ScoredGoals += isHomeTeam ? matchResult._HomeGoals : matchResult._AwayGoals;
            ConcededGoals += !isHomeTeam ? matchResult._HomeGoals : matchResult._AwayGoals;
        }
    }
}