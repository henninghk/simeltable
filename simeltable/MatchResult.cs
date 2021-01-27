using System;
using System.Collections.Generic;
using System.Text;

namespace simeltable
{
    class MatchResult
    {
        public Team _HomeTeam;
        public Team _AwayTeam;
        public int _HomeGoals;
        public int _AwayGoals;

        public MatchResult(Team homeTeam, Team awayTeam, int homeGoals, int awayGoals)
        {
            _AwayGoals = awayGoals;
            _HomeGoals = homeGoals;
            _AwayTeam = awayTeam;
            _HomeTeam = homeTeam;
        }
    }
}