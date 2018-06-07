using System;
using System.Linq;
using System.Threading.Tasks;
using Football;
using Newtonsoft.Json;

namespace TestFootball
{
    class Program
    {
        static void Main(string[] args)
        {
            //Without token requests limited read at football-data.org
            FootballData.Init("<token provided by football-data.org (optional)>");
            MainAsync().GetAwaiter().GetResult();
            Console.ReadLine();
        }

        static async Task MainAsync(){
            var cups = await FootballData.GetOngoingCompetitions();
            foreach (var item in cups)
            {
                Console.WriteLine(item.Caption);
            }
            var wc = await new WorldCup2018().GetCompetitionInfo();
            Console.WriteLine(JsonConvert.SerializeObject(wc));
            var teams = await wc.GetTeams();
            Console.WriteLine(JsonConvert.SerializeObject(teams));

            var fix = await wc.GetFixtures();
            Console.WriteLine(JsonConvert.SerializeObject(fix));

            var lt = await wc.GetLeagueTable();
            Console.WriteLine(JsonConvert.SerializeObject(lt));

            var home = await fix.Fixtures[2].GetHomeTeam();
            var away = await fix.Fixtures[5].GetAwayTeam();
        }
    }
}
