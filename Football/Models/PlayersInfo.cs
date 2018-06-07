// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Football.Models;
//
//    var playersInfo = PlayersInfo.FromJson(jsonString);

namespace Football.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class PlayersInfo
    {
        [JsonProperty("_links", NullValueHandling = NullValueHandling.Ignore)]
        public PlayersInfoLinks Links { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        [JsonProperty("players", NullValueHandling = NullValueHandling.Ignore)]
        public List<Player> Players { get; set; }
    }

    public partial class PlayersInfoLinks
    {
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public LinkInfo Self { get; set; }

        [JsonProperty("team", NullValueHandling = NullValueHandling.Ignore)]
        public LinkInfo Team { get; set; }
    }
    
    public partial class Player
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        [JsonProperty("jerseyNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? JerseyNumber { get; set; }

        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateOfBirth { get; set; }

        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        [JsonProperty("contractUntil", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ContractUntil { get; set; }

        [JsonProperty("marketValue")]
        public object MarketValue { get; set; }
    }
}
