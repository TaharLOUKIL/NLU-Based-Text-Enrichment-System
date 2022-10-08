using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class Items
    {
        public String? type { get; set; }
        public bool additionalProperties { get; set; }
        public List<String>? required { get; set; }
        public Properties? properties { get; set; }
        public Items? items { get; set; }

        [JsonProperty("$id")]
        public String? Id { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }
}
