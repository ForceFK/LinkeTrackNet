using System.Text.Json.Serialization;

namespace LinkeTrackNet.Models
{
    public class TrackResult
    {
        [JsonPropertyName("codigo")]
        public string Code { get; set; }
        [JsonPropertyName("host")]
        public string Host { get; set; }
        [JsonPropertyName("eventos")]
        public TrackEventItem[] Events { get; set; }
        [JsonPropertyName("time")]
        public float Time { get; set; }
        [JsonPropertyName("quantidade")]
        public int Quantity { get; set; }
        [JsonPropertyName("servico")]
        public string Service { get; set; }
        [JsonPropertyName("ultimo")]
        public DateTimeOffset? LastUpdate { get; set; }

    }
}
