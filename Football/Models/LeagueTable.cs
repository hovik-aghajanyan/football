// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Football.Models;
//
//    var leagueTable = LeagueTable.FromJson(jsonString);

namespace Football.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class LeagueTable
    {
        [JsonProperty("_links", NullValueHandling = NullValueHandling.Ignore)]
        public LeagueTableLinks Links { get; set; }

        [JsonProperty("leagueCaption", NullValueHandling = NullValueHandling.Ignore)]
        public string LeagueCaption { get; set; }

        [JsonProperty("matchday", NullValueHandling = NullValueHandling.Ignore)]
        public long? Matchday { get; set; }

        [JsonProperty("standing", NullValueHandling = NullValueHandling.Ignore)]
        public List<Standing> Standing { get; set; }
    }

    public partial class LeagueTableLinks
    {
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public LinkInfo Self { get; set; }

        [JsonProperty("competition", NullValueHandling = NullValueHandling.Ignore)]
        public LinkInfo Competition { get; set; }
    }
    
    public partial class Standing
    {
        [JsonProperty("_links", NullValueHandling = NullValueHandling.Ignore)]
        public StandingLinks Links { get; set; }

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public long? Position { get; set; }

        [JsonProperty("teamName", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamName { get; set; }

        [JsonProperty("crestURI")]
        public string CrestUri { get; set; }

        [JsonProperty("playedGames", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlayedGames { get; set; }

        [JsonProperty("points", NullValueHandling = NullValueHandling.Ignore)]
        public long? Points { get; set; }

        [JsonProperty("goals", NullValueHandling = NullValueHandling.Ignore)]
        public long? Goals { get; set; }

        [JsonProperty("goalsAgainst", NullValueHandling = NullValueHandling.Ignore)]
        public long? GoalsAgainst { get; set; }

        [JsonProperty("goalDifference", NullValueHandling = NullValueHandling.Ignore)]
        public long? GoalDifference { get; set; }

        [JsonProperty("wins", NullValueHandling = NullValueHandling.Ignore)]
        public long? Wins { get; set; }

        [JsonProperty("draws", NullValueHandling = NullValueHandling.Ignore)]
        public long? Draws { get; set; }

        [JsonProperty("losses", NullValueHandling = NullValueHandling.Ignore)]
        public long? Losses { get; set; }

        [JsonProperty("home", NullValueHandling = NullValueHandling.Ignore)]
        public TeamData Home { get; set; }

        [JsonProperty("away", NullValueHandling = NullValueHandling.Ignore)]
        public TeamData Away { get; set; }
    }

    public partial class TeamData
    {
        [JsonProperty("goals", NullValueHandling = NullValueHandling.Ignore)]
        public long? Goals { get; set; }

        [JsonProperty("goalsAgainst", NullValueHandling = NullValueHandling.Ignore)]
        public long? GoalsAgainst { get; set; }

        [JsonProperty("wins", NullValueHandling = NullValueHandling.Ignore)]
        public long? Wins { get; set; }

        [JsonProperty("draws", NullValueHandling = NullValueHandling.Ignore)]
        public long? Draws { get; set; }

        [JsonProperty("losses", NullValueHandling = NullValueHandling.Ignore)]
        public long? Losses { get; set; }
    }

    public partial class StandingLinks
    {
        [JsonProperty("team", NullValueHandling = NullValueHandling.Ignore)]
        public LinkInfo Team { get; set; }
    }
}
