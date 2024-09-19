using System.Text.Json.Serialization;

namespace LinkeTrackNet.Models
{
    public class TrackEventItem
    {
        [JsonPropertyName("data")]
        public string Date { get; set; }
        [JsonPropertyName("hora")]
        public string Hour { get; set; }

        [JsonPropertyName("local")]
        public string Local { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [Obsolete("Este campo será descontinuado no futuro.")]
        [JsonPropertyName("subStatus")]
        public string[]? SubStatus { get; set; }

        [JsonIgnore]
        public DateTime Datetime { get => DateTime.ParseExact($"{Date} {Hour}", "dd/MM/yyyy HH:mm", null); }
    }
}
