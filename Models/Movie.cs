using Newtonsoft.Json;

namespace webimdb.Models
{
    public class Movie
    {
        [JsonProperty("Title")]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("Plot")]
        public string Plot { get; set; } = string.Empty;

        [JsonProperty("Poster")]
        public string Poster { get; set; } = string.Empty;

        [JsonProperty("Actors")]
        public string Actors { get; set; } = string.Empty;

        [JsonProperty("Response")]
        public string Response { get; set; } = string.Empty;

        [JsonProperty("Error")]
        public string Error { get; set; } = string.Empty;
    }
}