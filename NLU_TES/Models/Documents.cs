// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class Documents
    {
        public String? type { get; set; }

        [JsonProperty("$id")]
        public String? Id { get; set; }

        public AdditionalProperties? additionalProperties { get; set; }
    }

   
}