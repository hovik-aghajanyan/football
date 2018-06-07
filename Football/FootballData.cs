using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Football.Common;
using Football.Models;

namespace Football
{
    //https://api.football-data.org/v1/competitions
    public class FootballData
    {
        public static void Init(string token){
            Rest.Token = token;
        }

        public static async Task<List<CompetitionInfo>> GetOngoingCompetitions(){
            return await Rest.Get<List<CompetitionInfo>>(Rest.BaseUrl);
        }
    }
}
