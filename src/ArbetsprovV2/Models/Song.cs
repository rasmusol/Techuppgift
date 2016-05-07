using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArbetsprovV2.Models
{
    public class SongRequest
    {
        [JsonProperty("response")]
        public SongResponse Response { get; set; }
    }
    public class SongResponse
    {
        [JsonProperty("status")]
        public SongStatus Status { get; set; }
        [JsonProperty("songs")]
        public List<Song> Song { get; set; }
    }
    public class SongStatus
    {
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

    }

    public class Song
    {
        [JsonProperty("artist_id")]
        public string ArtistId { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("artist_name")]
        public string ArtistName { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
