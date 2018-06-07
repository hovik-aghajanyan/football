using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Football.Models
{

    //https://app.quicktype.io/#l=cs&r=json2csharp
    public partial class CompetitionInfo
    {
        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("league")]
        public string League { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("currentMatchday")]
        public long CurrentMatchday { get; set; }

        [JsonProperty("numberOfMatchdays")]
        public long NumberOfMatchdays { get; set; }

        [JsonProperty("numberOfTeams")]
        public long NumberOfTeams { get; set; }

        [JsonProperty("numberOfGames")]
        public long NumberOfGames { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }
    }

    public class Links
    {
        [JsonProperty("self")]
        public LinkInfo Self { get; set; }

        [JsonProperty("teams")]
        public LinkInfo Teams { get; set; }

        [JsonProperty("fixtures")]
        public LinkInfo Fixtures { get; set; }

        [JsonProperty("leagueTable")]
        public LinkInfo LeagueTable { get; set; }
    }

}

