using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ArbetsprovV2.Models
{
    public class ArtistRequest
    {
        [JsonProperty("response")]
        public ArtistResponse Response { get; set; }
    }
    public class ArtistResponse
    {
        [JsonProperty("status")]
        public Status Status { get; set; }
        [JsonProperty("artists")]
        public List<Artist> Artists { get; set; }
    }
    public class Status
    {
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

    }

    public class Artist
    {
        [JsonProperty("hotttnesss")]
        public string Hotness { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
