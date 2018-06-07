using Football.Common;
using Football.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public static class TeamExtension
    {
        public static async Task<PlayersInfo> GetPlayers(this Team info) => await Rest.Get<PlayersInfo>(info.Links.Players.Href);

        public static async Task<FixturesInfo> GetFixtures(this Team info) => await Rest.Get<FixturesInfo>(info.Links.Fixtures.Href);

    }
}
