using System;
using System.Net.Http;
using System.Threading.Tasks;
using Football.Common;
using Football.Models;
using Newtonsoft.Json;

namespace Football
{
    public abstract class Competition
    {
        public string EventId
        {
            get;
            set;
        }

        public Competition(string eventId)
        {
            EventId = eventId;
        }

        public async Task<CompetitionInfo> GetCompetitionInfo()
        {
            return await Rest.Get<CompetitionInfo>($"{Rest.BaseUrl}/{EventId}");
        }
    }
}
