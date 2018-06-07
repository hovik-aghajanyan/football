using Football.Common;
using Football.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Football.Extensions
{
    public static class TeamInfoExtension
    {
        public static async Task<CompetitionInfo> GetCompetition(this TeamsInfo info) => await Rest.Get<CompetitionInfo>(info.Links.Competition.Href);
    }
}
