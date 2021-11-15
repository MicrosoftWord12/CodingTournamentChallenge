using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTournamentChallenge.Database.Select
{
    class SelectSubscribed
    {
        public string GetSubscribedPerson(int id)
        {
            string sql = $"select player_email from players where playerid={id}";
            return DBCommand.Command(sql).ExecuteScalar().ToString();
        }
    }
}
