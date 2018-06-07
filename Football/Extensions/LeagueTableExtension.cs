using Football.Common;
using Football.Models;
using System.Threading.Tasks;

namespace Football.Extensions
{
    public static class LeagueTableExtension
    {
        public static async Task<CompetitionInfo> GetCompetition(this LeagueTable info) => await Rest.Get<CompetitionInfo>(info.Links.Competition.Href);
    }
}
