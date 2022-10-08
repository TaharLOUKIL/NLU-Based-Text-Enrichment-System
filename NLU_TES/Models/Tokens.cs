// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class Tokens
    {
        public String? type { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }

        public Items? items { get; set; }
        public int minItems { get; set; }
    }
}