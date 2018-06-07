using Football.Common;
using Football.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public static class CompetitionInfoExtension
    {
        public static async Task<TeamsInfo> GetTeams(this CompetitionInfo info) => await Rest.Get<TeamsInfo>(info.Links.Teams.Href);

        public static async Task<FixturesInfo> GetFixtures(this CompetitionInfo info) => await Rest.Get<FixturesInfo>(info.Links.Fixtures.Href);

        public static async Task<LeagueTable> GetLeagueTable(this CompetitionInfo info) => await Rest.Get<LeagueTable>(info.Links.LeagueTable.Href);

        public static async Task<LeagueTable> GetLeagueTable(this CompetitionInfo info, int matchDay) => await Rest.Get<LeagueTable>($"{info.Links.LeagueTable.Href}?matchday={matchDay}");
    }
}
