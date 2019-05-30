using System;
using Newtonsoft.Json;

namespace PoEMapsModel.API
{
    public partial class LeagueModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("realm")]
        public string Realm { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("startAt")]
        public DateTimeOffset StartAt { get; set; }

        [JsonProperty("endAt")]
        public DateTimeOffset? EndAt { get; set; }

        [JsonProperty("delveEvent")]
        public bool DelveEvent { get; set; }

        [JsonProperty("rules")]
        public Rule[] Rules { get; set; }

        [JsonProperty("registerAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RegisterAt { get; set; }

        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Event { get; set; }
    }

    public partial class Rule
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}