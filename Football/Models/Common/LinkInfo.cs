using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Football.Models
{

    public class LinkInfo
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
