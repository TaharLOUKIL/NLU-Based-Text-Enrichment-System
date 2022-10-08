// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class Meta
    {
        public String? type { get; set; }
        public bool additionalProperties { get; set; }
        public List<String>? required { get; set; }
        public Properties? properties { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

   
}