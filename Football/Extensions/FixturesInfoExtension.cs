using Football.Common;
using Football.Models;
using System.Threading.Tasks;

namespace Football.Extensions
{
    public static class FixturesInfoExtension
    {
        public static async Task<CompetitionInfo> GetCompetition(this FixturesInfo info) => await Rest.Get<CompetitionInfo>(info.Links.Competition.Href);
    }
}
