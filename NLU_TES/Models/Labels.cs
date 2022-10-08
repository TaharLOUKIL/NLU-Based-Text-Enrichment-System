// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class Labels
    {
        public String? description { get; set; }
        public String? type { get; set; }
        public int minItems { get; set; }
        public Items? items { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

   
}