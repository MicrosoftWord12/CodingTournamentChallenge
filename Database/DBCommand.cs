using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
namespace CodingTournamentChallenge.Database
{
    class DBCommand
    {
        public static NpgsqlCommand Command(String SQL)
        {
            DBConnection conn = new DBConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(SQL, conn.Connection());
            return cmd;
        }
    }
}
