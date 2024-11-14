﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Queries
{
    public class TeamQueries
    {
        public const string GetAllTeams = "SELECT * FROM Football.Team";

        public const string GetTeamNameById =
           """
              SELECT TeamName
              FROM Football.Team
              WHERE TeamID = @TeamID
            """;

        // Add more queries for other CRUD operations (INSERT, UPDATE, DELETE)
    }
}
