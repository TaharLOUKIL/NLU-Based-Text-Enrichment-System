// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class Embeddings
    {
        public String? description { get; set; }
        public String? type { get; set; }
        public Items? items { get; set; }

        [JsonProperty("$ref")]
        public String? Ref { get; set; }
    }

   
}