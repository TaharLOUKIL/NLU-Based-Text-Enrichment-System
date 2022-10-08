// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class Clauses
    {
        public String? Type { get; set; }

        [JsonProperty("$id")]
        public String? Id { get; set; }

        public AdditionalProperties? additionalProperties { get; set; }
    }

   
}