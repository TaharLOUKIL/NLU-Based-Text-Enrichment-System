// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class Constituents
    {
        [JsonProperty("$id")]
        public String? Id { get; set; }

        public String? type { get; set; }
        public Items? items { get; set; }
    }

   
}