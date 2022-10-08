using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class AdditionalProperties
    {
        public String? Type { get; set; }
        public bool additionalProperties { get; set; }
        public List<String>? Required { get; set; }
        public Properties? Properties { get; set; }

        [JsonProperty("$id")]
        public String? Id { get; set; }

        public String? Description { get; set; }
        public Items? items { get; set; }
    }
}
