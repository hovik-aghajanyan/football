using Football.Common;
using Football.Models;
using System.Threading.Tasks;

namespace Football
{
    public static class FixturesExtension
    {
        public static async Task<Team> GetAwayTeam(this Fixture info) => await Rest.Get<Team>(info.Links.AwayTeam.Href);

        public static async Task<Team> GetHomeTeam(this Fixture info) => await Rest.Get<Team>(info.Links.HomeTeam.Href);
    }
}
