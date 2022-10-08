// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace NLU_Aggregator.Models
{
    public class Text
    {
        [JsonProperty("$id")]
        public String? Id { get; set; }

        public String? type { get; set; }
        public String? description { get; set; }
        public List<String>? examples { get; set; }
        public String? pattern { get; set; }
    }

   
}