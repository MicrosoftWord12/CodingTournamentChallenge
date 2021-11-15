using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTournamentChallenge.Database.Select
{
    class SelectPlayerEmail
    {
        public string GetPlayerEmail(int id)
        {
            string sql = $"select player_email from players where playerid={id}";
            return DBCommand.Command(sql).ExecuteScalar().ToString();
        }
    }
}
