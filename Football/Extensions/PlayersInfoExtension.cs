using Football.Common;
using Football.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Football.Extensions
{
    public static class PlayersInfoExtension
    {
        public static async Task<Team> GetTeams(this PlayersInfo info) => await Rest.Get<Team>(info.Links.Team.Href);
    }
}
