using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Football.Models
{
    public partial class TeamsInfo
    {
        [JsonProperty("_links")]
        public TeamsInfoLinks Links { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }
    }

    public partial class TeamsInfoLinks
    {
        [JsonProperty("self")]
        public LinkInfo Self { get; set; }

        [JsonProperty("competition")]
        public LinkInfo Competition { get; set; }
    }

    public partial class Team
    {
        [JsonProperty("_links")]
        public TeamLinks Links { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("squadMarketValue")]
        public string SquadMarketValue { get; set; }

        [JsonProperty("crestUrl")]
        public string FlagUrl { get; set; }
    }

    public partial class TeamLinks
    {
        [JsonProperty("self")]
        public LinkInfo Self { get; set; }

        [JsonProperty("fixtures")]
        public LinkInfo Fixtures { get; set; }

        [JsonProperty("players")]
        public LinkInfo Players { get; set; }
    }
}

