
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Football.Models
{

    public partial class FixturesInfo
    {
        [JsonProperty("_links")]
        public FixturesInfoLinks Links { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("fixtures")]
        public List<Fixture> Fixtures { get; set; }
    }

    public partial class Fixture
    {
        [JsonProperty("_links")]
        public FixtureLinks Links { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("matchday")]
        public long Matchday { get; set; }

        [JsonProperty("homeTeamName")]
        public string HomeTeamName { get; set; }

        [JsonProperty("awayTeamName")]
        public string AwayTeamName { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("odds")]
        public Odds Odds { get; set; }
    }

    public partial class FixtureLinks
    {
        [JsonProperty("self")]
        public LinkInfo Self { get; set; }

        [JsonProperty("competition")]
        public LinkInfo Competition { get; set; }

        [JsonProperty("homeTeam")]
        public LinkInfo HomeTeam { get; set; }

        [JsonProperty("awayTeam")]
        public LinkInfo AwayTeam { get; set; }
    }

    public partial class Odds
    {
        [JsonProperty("homeWin")]
        public double HomeWin { get; set; }

        [JsonProperty("draw")]
        public double Draw { get; set; }

        [JsonProperty("awayWin")]
        public double AwayWin { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("goalsHomeTeam", NullValueHandling = NullValueHandling.Ignore)]
        public long GoalsHomeTeam { get; set; }

        [JsonProperty("goalsAwayTeam", NullValueHandling = NullValueHandling.Ignore)]
        public long GoalsAwayTeam { get; set; }

        [JsonProperty("halfTime", NullValueHandling = NullValueHandling.Ignore)]
        public HalfTime HalfTime { get; set; }
    }

    public partial class HalfTime
    {
        [JsonProperty("goalsHomeTeam")]
        public long GoalsHomeTeam { get; set; }

        [JsonProperty("goalsAwayTeam")]
        public long GoalsAwayTeam { get; set; }
    }

    public partial class FixturesInfoLinks
    {
        [JsonProperty("self")]
        public LinkInfo Self { get; set; }

        [JsonProperty("competition")]
        public LinkInfo Competition { get; set; }
    }
}
