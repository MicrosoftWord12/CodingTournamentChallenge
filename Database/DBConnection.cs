using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
namespace CodingTournamentChallenge.Database
{
    class DBConnection
    {

        public NpgsqlConnection Connection()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=1832;Database=CodingTournamentChallenge";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            return conn;
        }

    }
}
