// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using NLU_Aggregator.Models;

namespace NLU_Aggregator.Models
{
    public class JSONNLP
    {
        [JsonProperty("$schema")]
        public String? Schema { get; set; }
        public String? Title { get; set; }
        public String? Type { get; set; }
        public Definitions? definitions { get; set; }
        public List<String>? Required { get; set; }
        public bool additionalProperties { get; set; }
        public Properties? properties { get; set; }

    }
}