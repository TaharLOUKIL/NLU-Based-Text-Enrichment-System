// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class Features
    {
        public String? description { get; set; }
        public String? type { get; set; }
        public PatternProperties patternProperties { get; set; }
        public bool additionalProperties { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

   
}