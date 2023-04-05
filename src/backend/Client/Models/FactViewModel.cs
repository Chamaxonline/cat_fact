using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Models
{
    public class FactViewModel
    {
        [JsonProperty("length")]
        public int Length  { get; set; }
        [JsonProperty("fact")]
        public string Fact { get; set; }
    }
}
